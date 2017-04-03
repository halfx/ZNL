using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ZNLCRM.Controls
{
    public class ExWebBrowser : System.Windows.Forms.WebBrowser
    {
        public object TagA { get; set; }
        public object TagB { get; set; }

        private SHDocVw.IWebBrowser2 Iwb2;
        protected override void AttachInterfaces(object nativeActiveXObject)
        {
            Iwb2 = (SHDocVw.IWebBrowser2)nativeActiveXObject;
            Iwb2.Silent = true;
            base.AttachInterfaces(nativeActiveXObject);
        }

        protected override void DetachInterfaces()
        {
            Iwb2 = null;
            base.DetachInterfaces();
        }

        System.Windows.Forms.AxHost.ConnectionPointCookie cookie;
        WebBrowserExtendedEvents events;

        protected override void CreateSink()
        {
            base.CreateSink();
            events = new WebBrowserExtendedEvents(this);
            cookie = new System.Windows.Forms.AxHost.ConnectionPointCookie(this.ActiveXInstance, events, typeof(DWebBrowserEvents2));
        }

        protected override void DetachSink()
        {
            if (null != cookie)
            {
                cookie.Disconnect();
                cookie = null;
            }
            base.DetachSink();
        }

        public event EventHandler BeforeNavigate;
        /// <summary>
        /// 可用于替代原来的NewWindow事件，新增了事件的Url参数支持。
        /// </summary>
        [CategoryAttribute("操作"), DescriptionAttribute("经过扩展的NewWindow事件，使用继承后的WebBrowserExtendedNavigatingEventArgs类型参数实现Url参数支持")]
        public event EventHandler BeforeNewWindow;
        protected void OnBeforeNewWindow(string url, out bool cancel)
        {
            EventHandler h = BeforeNewWindow;
            WebBrowserExtendedNavigatingEventArgs args = new WebBrowserExtendedNavigatingEventArgs(url, null);
            if (null != h)
            {
                h(this, args);
            }
            cancel = args.Cancel;
        }

        protected void OnBeforeNavigate(string url, string frame, out bool cancel)
        {
            EventHandler h = BeforeNavigate;
            WebBrowserExtendedNavigatingEventArgs args = new WebBrowserExtendedNavigatingEventArgs(url, frame);
            if (null != h)
            {
                h(this, args);
            }

            cancel = args.Cancel;
        }

        class WebBrowserExtendedEvents : System.Runtime.InteropServices.StandardOleMarshalObject, DWebBrowserEvents2
        {
            ExWebBrowser _Browser;
            public WebBrowserExtendedEvents(ExWebBrowser browser) { _Browser = browser; }

            public void BeforeNavigate2(object pDisp, ref object URL, ref object flags, ref object targetFrameName, ref object postData, ref object headers, ref bool cancel)
            {
                _Browser.OnBeforeNavigate((string)URL, (string)targetFrameName, out cancel);
            }

            public void NewWindow3(object pDisp, ref bool cancel, ref object flags, ref object URLContext, ref object URL)
            {
                _Browser.OnBeforeNewWindow((string)URL, out cancel);
            }
        }

        [System.Runtime.InteropServices.ComImport(), System.Runtime.InteropServices.Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D"),
        System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIDispatch),
        System.Runtime.InteropServices.TypeLibType(System.Runtime.InteropServices.TypeLibTypeFlags.FHidden)]
        public interface DWebBrowserEvents2
        {
            [System.Runtime.InteropServices.DispId(250)]
            void BeforeNavigate2(
                [System.Runtime.InteropServices.In,
                System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)] object pDisp,
                [System.Runtime.InteropServices.In] ref object URL,
                [System.Runtime.InteropServices.In] ref object flags,
                [System.Runtime.InteropServices.In] ref object targetFrameName, [System.Runtime.InteropServices.In] ref object postData,
                [System.Runtime.InteropServices.In] ref object headers,
                [System.Runtime.InteropServices.In,
                System.Runtime.InteropServices.Out] ref bool cancel);
            [System.Runtime.InteropServices.DispId(273)]

            void NewWindow3(
                [System.Runtime.InteropServices.In,
                System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)] object pDisp,
                [System.Runtime.InteropServices.In, System.Runtime.InteropServices.Out] ref bool cancel,
                [System.Runtime.InteropServices.In] ref object flags,
                [System.Runtime.InteropServices.In] ref object URLContext,
                [System.Runtime.InteropServices.In] ref object URL);
        }

        //1.定义代理信息的结构体
        public struct Struct_INTERNET_PROXY_INFO
        {
            public int dwAccessType;
            public IntPtr proxy;
            public IntPtr proxyBypass;
        };

        //You can change the proxy with InternetSetOption method from the wininet.dll, here is a example to set the proxy
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        //strProxy为代理IP:端口
        public void InternetSetOption(string strProxy)
        {
            //设置代理选项
            const int INTERNET_OPTION_PROXY = 38;

            //设置代理类型
            const int INTERNET_OPEN_TYPE_PROXY = 3;

            //设置代理类型，直接访问，不需要通过代理服务器了
            const int INTERNET_OPEN_TYPE_DIRECT = 1;

            Struct_INTERNET_PROXY_INFO struct_IPI;
            //Filling in structure 
            struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY;

            //把代理地址设置到非托管内存地址中 
            struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy);

            //代理通过本地连接到代理服务器上
            struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local");

            //关联到内存
            IntPtr intptrStruct = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI));
            if (string.IsNullOrEmpty(strProxy) || strProxy.Trim().Length == 0)
            {
                strProxy = string.Empty;
                struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_DIRECT;
            }

            //把结构体转换到句柄
            Marshal.StructureToPtr(struct_IPI, intptrStruct, true);
            bool iReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, Marshal.SizeOf(struct_IPI));
        } 
    }

    public class WebBrowserExtendedNavigatingEventArgs : CancelEventArgs
    {
        private string _Url;
        public string Url
        {
            get { return _Url; }
        }

        private string _Frame;
        public string Frame
        {
            get { return _Frame; }
        }

        public WebBrowserExtendedNavigatingEventArgs(string url, string frame)
            : base()
        {
            _Url = url;
            _Frame = frame;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Net;
using System.Text.RegularExpressions;

namespace ZNLCRM.Utility
{
    public class EnvironmentHandler
    {
        #region 获得MAC及硬盘序列号

        /// <summary>
        /// 获取当前网卡IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetNetCardIP()
        {
            string ipAddress = string.Empty;
            try
            {
                System.Net.IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
                if (addressList.Length > 0)
                {
                    foreach (System.Net.IPAddress ip in addressList)
                    {
                        if (IPCheck(ip.ToString()))
                        {
                            ipAddress = ip.ToString();
                            break;
                        }
                    }
                }
            }
            catch { }
            return ipAddress;
        }

        /// <summary>
        /// 判断是否IP地址
        /// </summary>
        /// <param name="IP"></param>
        /// <returns></returns>
        public static bool IPCheck(string IP)
        {
            string num = "(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)";
            return Regex.IsMatch(IP, ("^" + num + "\\." + num + "\\." + num + "\\." + num + "$"));
        }

        /// <summary>
        /// 获取网卡MAC地址
        /// </summary>
        /// <returns></returns>
        public static string GetNetCardMAC()
        {
            try
            {
                string stringMAC = "";
                ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection MOC = MC.GetInstances();
                foreach (ManagementObject MO in MOC)
                {
                    if ((bool)MO["IPEnabled"] == true)
                    {
                        stringMAC += MO["MACAddress"].ToString();
                        break;

                    }
                }
                return stringMAC;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 根据IP获取Mac地址
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public static string GetNetCardMAC(string ipAddress)
        {
            try
            {
                string stringMAC = "";
                ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection MOC = MC.GetInstances();
                foreach (ManagementObject MO in MOC)
                {
                    if ((bool)MO["IPEnabled"] == true)
                    {
                        string[] ipAddr = MO["IPAddress"] as string[];
                        if (ipAddr.Length > 0 && ipAddr[0] == ipAddress)
                        {
                            stringMAC += MO["MACAddress"].ToString();
                            break;
                        }
                    }
                }
                return stringMAC;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 获得硬盘序列号
        /// </summary>
        /// <returns></returns>
        public static string GetHardSN()
        {
            try
            {
                String strHardDiskID = String.Empty; ;
                ManagementClass cimobject = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc = cimobject.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    strHardDiskID = (string)mo.Properties["Model"].Value;
                    break;
                }
                return strHardDiskID;
            }
            catch
            {
                return "";
            }
        }
        #endregion
        #region 版本控制
        /// <summary>
        /// 软件版本比较
        /// </summary>
        /// <param name="verNo1"></param>
        /// <param name="verNo2"></param>
        /// <returns>0：相等，1：大于,-1:小于</returns>
        public static int CompareVerNo(string verNo1, string verNo2)
        {
            int iRet = 0;
            if (verNo1 == null) verNo1 = "";
            if (verNo2 == null) verNo2 = "";
            if (verNo1 != verNo2)
            {
                string[] vers1 = verNo1.Split('.');
                string[] vers2 = verNo2.Split('.');
                int compIndex = 0;
                for (int i = 0; i < vers1.Length && i < vers2.Length && i < 4; i++)
                {
                    compIndex++;
                    int ver1 = -1;
                    int ver2 = -1;
                    int.TryParse(vers1[i], out ver1);
                    int.TryParse(vers2[i], out ver2);
                    if (ver1 > ver2)
                    {
                        iRet = 1;
                        break;
                    }
                    else if (ver1 < ver2)
                    {
                        iRet = -1;
                        break;
                    }
                }
                if (iRet == 0)
                {
                    //4次比较相等认为是相同的
                    if (compIndex < 4)
                    {
                        //小于4次，谁后面还有子版本号，谁就算大
                        if (vers1.Length > vers2.Length)
                        {
                            iRet = 1;
                        }
                        else if (vers1.Length < vers2.Length)
                        {
                            iRet = -1;
                        }
                    }
                }
            }
            return iRet;
        }

        /// <summary>
        /// 获取给定版本号下一个版本号
        /// 每一个子版本号不超100
        /// </summary>
        /// <param name="verNo"></param>
        /// <returns></returns>
        public static string GetNextVerNo(string verNo)
        {
            if (string.IsNullOrEmpty(verNo)) return "1.0.0.1";
            string[] vers = verNo.Split('.');
            int[] newVers = new int[] { 0, 0, 0, 0 };
            for (int i = 0; i < vers.Length && i < 4; i++)
            {
                int.TryParse(vers[i], out newVers[i]);
            }
            newVers[3]++;
            for (int i = 3; i >= 1; i--)
            {
                if (newVers[i] >= 100)
                {
                    newVers[i] = 99;
                    newVers[i - 1]++;
                }
            }
            return string.Format("{0}.{1}.{2}.{3}", newVers[0], newVers[1], newVers[2], newVers[3]);
        }

        public static string GetCurrentDirectory()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        #endregion
    }
}

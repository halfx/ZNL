using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ZNLCRM.Controls
{
    public partial class UcLabel : Label
    {
        bool _isMustChar = false;
        Label _isMustLabe = null;

        public UcLabel()
        {
            InitializeComponent();
            SetStyle();
            setFormLoadEvent();
        }

        public UcLabel(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
                SetStyle();
                setFormLoadEvent();
            }
            
        }

        bool _isFirsPaint = true;
        bool _hasAttachPaintEvent = false;

        void setFormLoadEvent()
        {
            if (!_hasAttachPaintEvent)
            {
                this.Paint += new PaintEventHandler(UcLabel_Paint);
                _hasAttachPaintEvent = true;
            }
        }

        void UcLabel_Paint(object sender, PaintEventArgs e)
        {
            if (_isFirsPaint)
            {
                setMustChar();
                _isFirsPaint = false;
            }
        }
        
        private void SetStyle()
        {
            this.ForeColor = Color.Gray;
            this.Font = new Font("宋体", 9);
        }
        [Category("属性"), DefaultValue(false)]
        /// <summary>
        /// 是否在必输字符
        /// </summary>
        public bool IsMustChar
        {
            get
            {
                return _isMustChar;
            }
            set
            {
                _isMustChar = value;
            }
        }

        void setMustChar()
        {
            if (_isMustChar)
            {
                if (_isMustLabe == null) _isMustLabe = new Label();
                _isMustLabe.ForeColor = Color.Red;
                _isMustLabe.Text = "*";
                _isMustLabe.AutoSize = true;
                _isMustLabe.Name = this.Name + "__IsMust";
                _isMustLabe.Width = 10;
                _isMustLabe.Location = new Point(this.Location.X - _isMustLabe.Width + 3, this.Location.Y + 1);
                this.Parent.Controls.Add(_isMustLabe);
                _isMustLabe.SendToBack();
            }
            else
            {
                if (_isMustLabe != null)
                {
                    this.Parent.Controls.Remove(_isMustLabe);
                    _isMustLabe.Dispose();
                    _isMustLabe = null;
                }
            }
        }
    }
}

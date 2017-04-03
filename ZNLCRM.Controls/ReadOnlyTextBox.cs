using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ZNLCRM.Controls
{
    public partial class ReadOnlyTextBox : Control
    {

        StringFormat format;
        public ReadOnlyTextBox()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                format = new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.FitBlackBox | StringFormatFlags.MeasureTrailingSpaces);
                format.LineAlignment = StringAlignment.Center;
                Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.Height = 10;
                this.Width = 10;

                this.Padding = new Padding(2);
            }
        }

        public ReadOnlyTextBox(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
                this.TextChanged += new EventHandler(ReadOnlyTextBox_TextChanged);
            }
        }

        private void ReadOnlyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(formatString) && !string.IsNullOrEmpty(Text))
            {
                Text = string.Format(formatString, Text);
            }
        }

        private Color borderColor = Color.Black;

        private bool isSummary;
        public bool IsSummary
        {
            get { return isSummary; }
            set { isSummary = value; }
        }

        private bool isLastColumn;
        public bool IsLastColumn
        {
            get { return isLastColumn; }
            set { isLastColumn = value; }
        }

        private string formatString;
        public string FormatString
        {
            get { return formatString; }
            set { formatString = value; }
        }


        private HorizontalAlignment textAlign = HorizontalAlignment.Left;
        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlign
        {
            get { return textAlign; }
            set
            {
                textAlign = value;
                setFormatFlags();
            }
        }

        private StringTrimming trimming = StringTrimming.None;
        [DefaultValue(StringTrimming.None)]
        public StringTrimming Trimming
        {
            get { return trimming; }
            set
            {
                trimming = value;
                setFormatFlags();
            }
        }

        private void setFormatFlags()
        {
            format.Alignment = TextHelper.TranslateAligment(TextAlign);
            format.Trimming = trimming;
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int subWidth = 0;
            Rectangle textBounds;

            if (!string.IsNullOrEmpty(formatString) && !string.IsNullOrEmpty(Text))
            {
                Text = String.Format("{0:" + formatString + "}", Convert.ToDecimal(Text));
            }

            textBounds = new Rectangle(this.ClientRectangle.X + 2, this.ClientRectangle.Y + 2, this.ClientRectangle.Width - 2, this.ClientRectangle.Height - 2);
            using (Pen pen = new Pen(borderColor))
            {
                if (isLastColumn)
                    subWidth = 1;

                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
                e.Graphics.DrawRectangle(pen, this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - subWidth, this.ClientRectangle.Height - 1);
                e.Graphics.DrawString(Text, Font, Brushes.Black, textBounds, format);
            }
        }
    }

    public static class TextHelper
    {
        public static StringAlignment TranslateAligment(HorizontalAlignment aligment)
        {
            if (aligment == HorizontalAlignment.Left)
                return StringAlignment.Near;
            else if (aligment == HorizontalAlignment.Right)
                return StringAlignment.Far;
            else
                return StringAlignment.Center;
        }

        public static HorizontalAlignment TranslateGridColumnAligment(DataGridViewContentAlignment aligment)
        {
            if (aligment == DataGridViewContentAlignment.BottomLeft || aligment == DataGridViewContentAlignment.MiddleLeft || aligment == DataGridViewContentAlignment.TopLeft)
                return HorizontalAlignment.Left;
            else if (aligment == DataGridViewContentAlignment.BottomRight || aligment == DataGridViewContentAlignment.MiddleRight || aligment == DataGridViewContentAlignment.TopRight)
                return HorizontalAlignment.Right;
            else
                return HorizontalAlignment.Left;
        }

        public static TextFormatFlags TranslateAligmentToFlag(HorizontalAlignment aligment)
        {
            if (aligment == HorizontalAlignment.Left)
                return TextFormatFlags.Left;
            else if (aligment == HorizontalAlignment.Right)
                return TextFormatFlags.Right;
            else
                return TextFormatFlags.HorizontalCenter;
        }

        public static TextFormatFlags TranslateTrimmingToFlag(StringTrimming trimming)
        {
            if (trimming == StringTrimming.EllipsisCharacter)
                return TextFormatFlags.EndEllipsis;
            else if (trimming == StringTrimming.EllipsisPath)
                return TextFormatFlags.PathEllipsis;
            if (trimming == StringTrimming.EllipsisWord)
                return TextFormatFlags.WordEllipsis;
            if (trimming == StringTrimming.Word)
                return TextFormatFlags.WordBreak;
            else
                return TextFormatFlags.Default;
        }
    }
}

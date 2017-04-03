using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace ZNLCRM.Controls
{
    public partial class UcSuperGridControl : SuperGridControl
    {
        public UcSuperGridControl()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                SetStyle();
            }
        }

        public UcSuperGridControl(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
                SetStyle();
            }
        }
        private void SetStyle()
        {
            this.PrimaryGrid.AllowRowHeaderResize = true;
            this.PrimaryGrid.AllowRowResize = true;
            this.PrimaryGrid.AutoGenerateColumns = false;
            this.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.PrimaryGrid.DefaultRowHeight = 24;
            //this.PrimaryGrid.EnableColumnFiltering = true;
            //this.PrimaryGrid.EnableRowFiltering = true;
            //this.PrimaryGrid.EnableFiltering = true;
            //this.PrimaryGrid.Filter.Visible = true;
            this.PrimaryGrid.ShowRowGridIndex = true;
            //this.PrimaryGrid.ShowTreeButtons = true;
            //this.PrimaryGrid.ShowTreeButton = true;
            //this.PrimaryGrid.ShowTreeLines = true;
           // this.PrimaryGrid.CellStyles.Default.Alignment = Alignment.MiddleCenter;
            this.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter;
             
        }
    }
} 

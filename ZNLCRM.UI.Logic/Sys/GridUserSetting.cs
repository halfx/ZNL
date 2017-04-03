using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Client.Entry;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Controls;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using System.Drawing;

namespace ZNLCRM.UI.Logic.Sys
{
    public class GridUserSetting
    {
        #region 表格常用方法
        /// <summary>
        /// 隐藏表格列
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="colName"></param>
        public static void HideGridColumn(UcDataGridView dgv, string colName)
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.Name == colName)
                {
                    dgvc.Visible = false;
                }
            }
        }
        /// <summary>
        /// 设置表格行颜色（按单元格是否只读属性自动设置,只读单元格默认为灰色,可编辑为白色）
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="onlyReadColor"></param>
        /// <param name="allowEditColor"></param>
        public static void SetDataGridViewRowColorByReadOnlyAttribute(DataGridViewRow dgvr)
        {
            for (int i = 0; i < dgvr.Cells.Count; i++)
            {
                if (dgvr.Cells[i].ReadOnly)
                {
                    dgvr.Cells[i].Style.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    dgvr.Cells[i].Style.BackColor = Color.White;
                }
            }
        }
        /// <summary>
        /// 设置表格行颜色（统一一种颜色）
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="onlyReadColor"></param>
        /// <param name="allowEditColor"></param>
        public static void SetDataGridViewRowColor(DataGridViewRow dgvr, Color clr)
        {
            for (int i = 0; i < dgvr.Cells.Count; i++)
            {
                dgvr.Cells[i].Style.BackColor = clr;
            }
        }
        /// <summary>
        /// 设置表格颜色（按单元格是否只读属性自动设置,只读单元格默认为灰色,可编辑为白色）
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="onlyReadColor"></param>
        /// <param name="allowEditColor"></param>
        public static void SetDataGridViewCellsColorByReadOnlyAttribute(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].ReadOnly)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(240, 240, 240);
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }
        #endregion

        private bool _isSettingCol = false;//防止设置表格宽度和索引值触发相关事件
        public static List<SYS_DataGridResult> DataGridSetting = new List<SYS_DataGridResult>();
        public List<SYS_DataGridResult> DataGridSettingInForm = new List<SYS_DataGridResult>();
        bool _isFormPeriod = false;
        #region 在窗体加载和关半的时候处理相关表格的习惯格式
        #region 获取某窗体的表格设置
        public void GetGridColListInForm(List<UcDataGridView> lstDgv)
        {
            _isFormPeriod = true;
            #region 获取相关的参数
            List<string> lstGridNames = new List<string>();
            List<string> lstFormName = new List<string>();
            List<string> lstUConName = new List<string>();
            string name = "";
            foreach (UcDataGridView dgv in lstDgv)
            {
                lstGridNames.Add(dgv.Name);
                name = dgv.FindForm().Name;
                if (!lstFormName.Contains(name)) lstFormName.Add(dgv.FindForm().Name);

                Control parentCon = dgv.Parent;
                while (parentCon != null && parentCon.GetType().BaseType != typeof(ucBaseUserControl))
                {
                    parentCon = parentCon.Parent;
                }
                if (parentCon != null)
                {
                    name = (parentCon as ucBaseUserControl).Name;
                    if (!lstUConName.Contains(name)) lstUConName.Add(name);
                }
            }
            #endregion
            #region 设置相关窗体表格变量
            SYS_DataGridParam param = new SYS_DataGridParam()
            {
                ParentNames = lstUConName.ToArray(),
                GridNames = lstGridNames.ToArray(),
                FormNames = lstFormName.ToArray()
            };
            ExeResult rst = WCFBLL.Execute("ZNLCRM.BLL.Sys.SYS_DataGridBLL", "GetGridColList", param);
            if (rst.Complete == ExeComplete.ErrorEx)
            {
                MessageBox.Show(rst.DebugMsg, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rst.Complete == ExeComplete.WarnEx)
            {
                MessageBox.Show(rst.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rst.Complete == ExeComplete.Succeed)
            {
                DataGridSettingInForm = rst.Result as List<SYS_DataGridResult>;
            }
            #endregion
        }
        #endregion
        #region 

        #endregion

        #endregion

        #region 获取表格设置相关方法
        public void GetAllGridColList(SYS_DataGridParam param)
        {
            List<SYS_DataGridResult> ret = new List<SYS_DataGridResult>();
            ExeResult rst = WCFBLL.Execute("ZNLCRM.BLL.Sys.SYS_DataGridBLL", "GetAllGridColList", param);
            if (rst.Complete == ExeComplete.ErrorEx)
            {
                MessageBox.Show(rst.DebugMsg, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rst.Complete == ExeComplete.WarnEx)
            {
                MessageBox.Show(rst.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rst.Complete == ExeComplete.Succeed)
            {
                ret = rst.Result as List<SYS_DataGridResult>;
                SetDataGridSettingVar(ret);
            }
        }

        private void GetGridColSetList(SYS_DataGridParam param)
        {
            List<SYS_DataGridResult> ret = new List<SYS_DataGridResult>();
            ExeResult rst = WCFBLL.Execute("ZNLCRM.BLL.Sys.SYS_DataGridBLL", "GetGridColList", param);
            if (rst.Complete == ExeComplete.ErrorEx)
            {
                MessageBox.Show(rst.DebugMsg, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rst.Complete == ExeComplete.WarnEx)
            {
                MessageBox.Show(rst.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rst.Complete == ExeComplete.Succeed)
            {
                ret = rst.Result as List<SYS_DataGridResult>;
                SetDataGridSettingVar(ret);
            }
        }
        private void SetDataGridSettingVar(List<SYS_DataGridResult> param)
        {
            foreach (SYS_DataGridResult info in param)
            {
                if (!DataGridSetting.Exists(a => a.GridName == info.GridName && a.ParentName == info.ParentName && a.FormName == info.FormName))
                {
                    DataGridSetting.Add(info);
                }
            }
        }
        static void SetDataGridSettingVar(SYS_DataGridResult param)
        {
            if (!DataGridSetting.Exists(a => a.GridName == param.GridName && a.ParentName == param.ParentName && a.FormName == param.FormName))
            {
                DataGridSetting.Add(param);
            }
        }

        public static SYS_DataGridResult GetGridSet(string gridName, string parentName, string formName)
        {
            SYS_DataGridResult rst = new SYS_DataGridResult();
            
            rst = DataGridSetting.Find(a => a.GridName == gridName && a.FormName == formName && a.ParentName == parentName);
            if (rst == null)
            {
                rst = new SYS_DataGridResult()
                {
                    GridName = gridName,
                    ParentName = parentName,
                    FormName = formName,
                    DGGUID = Guid.NewGuid()
                };
                rst.ColIndexList = new List<ZNLCRM.Entity.DBModel.SYS_UserGridColIndex>();
                rst.ColWidthList = new List<ZNLCRM.Entity.DBModel.SYS_UserGridColWidth>();
                rst.ColNameList = new List<ZNLCRM.Entity.DBModel.SYS_UserGridColName>();
                SetDataGridSettingVar(rst);
            }
            return rst;
        }
        #endregion
        #region 设置列宽和索引至缓存变量中
        public static void SetColName(UcDataGridView grid, string colNameCode, string colName, string customColName, bool isShow)
        {
            #region 变量设置
            SYS_UserGridColName finGridName = null;
            Guid? companyID = MySession.CompanyID;
            Guid? userGuid = MySession.UserGUID;
            #endregion
            #region  表格所在表单、容器、表格名称,获取表格对象
            SYS_DataGridResult gridSet = new SYS_DataGridResult();
            string formName = grid.FindForm().Name;
            string gridName = grid.Name;
            string parentName = "";
            Control parentCon = grid.Parent;
            while (parentCon != null && parentCon.GetType().BaseType != typeof(ucBaseUserControl))
            {
                parentCon = parentCon.Parent;
            }
            if (parentCon != null) parentName = (parentCon as ucBaseUserControl).Name;
            gridSet = GetGridSet(gridName, parentName, formName);
            #endregion
            #region 设置列自定义列名
            if (!string.IsNullOrEmpty(customColName))
            {
                finGridName = gridSet.ColNameList.Find(a => a.ColNameCN_Default == colName && a.CompanyID == companyID);
                if (finGridName == null)
                {
                    finGridName = new SYS_UserGridColName();
                    gridSet.ColNameList.Add(finGridName);
                }
                finGridName.ColNameCode = colNameCode;
                finGridName.ColNameCN_Default = colName;
                finGridName.ColNameCN_Custom = customColName;
                finGridName.ColIsShow = isShow;
                finGridName.CompanyID = companyID;
                finGridName.UserGUID = userGuid;
                finGridName.DGGUID = gridSet.DGGUID;
            }
            #endregion
        }

        private void SetColIndex(UcDataGridView grid, string colName, int? displayIdx, int? width)
        {
            #region 变量设置
            SYS_UserGridColIndex findGridIdx = null;
            SYS_UserGridColWidth findGridWdth = null;
            Guid? companyID = MySession.CompanyID;
            Guid? userGuid = MySession.UserGUID;
            #endregion
            #region  表格所在表单、容器、表格名称,获取表格对象
            SYS_DataGridResult gridSet = new SYS_DataGridResult();
            string formName = grid.FindForm().Name;
            string gridName = grid.Name;
            string parentName = "";
            Control parentCon = grid.Parent;
            while (parentCon != null && parentCon.GetType().BaseType != typeof(ucBaseUserControl))
            {
                parentCon = parentCon.Parent;
            }
            if (parentCon != null) parentName = (parentCon as ucBaseUserControl).Name;
            gridSet = GetGridSet(gridName, parentName, formName);
            #endregion
            #region 设置列显示索引值
            if (displayIdx != null)
            {
                findGridIdx = gridSet.ColIndexList.Find(a => a.ColName == colName && a.CompanyID == companyID && a.UserGUID == userGuid);
                if (findGridIdx == null)
                {
                    findGridIdx = new SYS_UserGridColIndex();
                    gridSet.ColIndexList.Add(findGridIdx);
                }
                findGridIdx.ColName = colName;
                findGridIdx.DisplayIndex = displayIdx;
                findGridIdx.CompanyID = companyID;
                findGridIdx.UserGUID = userGuid;
                findGridIdx.DGGUID = gridSet.DGGUID;
            }
            #endregion
            #region 设置列显示宽值
            if (width != null)
            {
                findGridWdth = gridSet.ColWidthList.Find(a => a.ColName == colName && a.CompanyID == companyID && a.UserGUID == userGuid);
                if (findGridWdth == null)
                {
                    findGridWdth = new SYS_UserGridColWidth();
                    gridSet.ColWidthList.Add(findGridWdth);
                }
                findGridWdth.ColName = colName;
                findGridWdth.ColWidth = width;
                findGridWdth.CompanyID = companyID;
                findGridWdth.UserGUID = userGuid;
                findGridWdth.DGGUID = gridSet.DGGUID;
            }
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabCtr"></param>
        /// <param name="tabItemName"></param>
        /// <param name="displayIdx"></param>
        private void SetColIndex(DevComponents.DotNetBar.TabControl tabCtr, string tabItemName, int? newDspIndex, int? oldDspIndex)
        {
            #region 变量设置
            SYS_UserGridColIndex findTabControlIdx = null;
            Guid? companyID = MySession.CompanyID;
            Guid? userGuid = MySession.UserGUID;
            #endregion
            #region  表格所在表单、容器、表格名称,获取表格对象
            SYS_DataGridResult tabCtrSet = new SYS_DataGridResult();
            string formName = tabCtr.FindForm().Name;
            string gridName = tabCtr.Name;
            string parentName = "";
            Control parentCon = tabCtr.Parent;
            while (parentCon != null && parentCon.GetType().BaseType != typeof(frmBaseForm))
            {
                parentCon = parentCon.Parent;
            }
            if (parentCon != null) parentName = (parentCon as frmBaseForm).Name;
            tabCtrSet = GetGridSet(gridName, parentName, formName);
            #endregion
            #region 设置列显示索引值
            if (newDspIndex != null) //处理新值
            {
                findTabControlIdx = tabCtrSet.ColIndexList.Find(a => a.ColName == tabItemName && a.CompanyID == companyID && a.UserGUID == userGuid);
                if (findTabControlIdx == null)
                {
                    findTabControlIdx = new SYS_UserGridColIndex();
                    tabCtrSet.ColIndexList.Add(findTabControlIdx);
                }
                findTabControlIdx.ColName = tabItemName;
                findTabControlIdx.DisplayIndex = newDspIndex;
                findTabControlIdx.CompanyID = companyID;
                findTabControlIdx.UserGUID = userGuid;
                findTabControlIdx.DGGUID = tabCtrSet.DGGUID;
            }

            if (oldDspIndex != null) //处理旧值
            {
                int i = 0;
                string _oldTabItemName = string.Empty;
                foreach (DevComponents.DotNetBar.TabItem ti in tabCtr.Tabs)
                {
                    if (newDspIndex == i)
                    {
                        _oldTabItemName = ti.Name;
                        break;
                    }
                    i++;
                }

                if (!string.IsNullOrEmpty(_oldTabItemName))
                {
                    findTabControlIdx = tabCtrSet.ColIndexList.Find(a => a.ColName == _oldTabItemName && a.CompanyID == companyID && a.UserGUID == userGuid);
                    if (findTabControlIdx == null)
                    {
                        findTabControlIdx = new SYS_UserGridColIndex();
                        tabCtrSet.ColIndexList.Add(findTabControlIdx);
                    }
                    findTabControlIdx.ColName = _oldTabItemName;
                    findTabControlIdx.DisplayIndex = oldDspIndex;
                    findTabControlIdx.CompanyID = companyID;
                    findTabControlIdx.UserGUID = userGuid;
                    findTabControlIdx.DGGUID = tabCtrSet.DGGUID;
                }
            }
            #endregion
        }
        #endregion
        #region 将设置应用于表格
        public void ApplyGridSet(UcDataGridView grid)
        {
            #region 得到表格设置
            _isSettingCol = true;
            if (grid == null || grid.FindForm() == null) return;
            string formName = grid.FindForm().Name;
            string gridName = grid.Name;
            string parentName = "";
            Control parentCon = grid.Parent;
            while (parentCon != null && parentCon.GetType().BaseType != typeof(ucBaseUserControl))
            {
                parentCon = parentCon.Parent;
            }
            if (parentCon != null) parentName = (parentCon as ucBaseUserControl).Name;
            SYS_DataGridResult gridSet = GetGridSet(gridName, parentName, formName);
            #endregion
            #region 设置表列显示索引值
            if (gridSet.ColIndexList != null && gridSet.ColIndexList.Count > 0)
            {
                foreach (SYS_UserGridColIndex info in gridSet.ColIndexList)
                {
                    if (grid.Columns[info.ColName] == null || grid.Columns[info.ColName].Frozen) continue; //冻结列不处理
                    if (grid.Columns.Count > info.DisplayIndex && grid.Columns[info.ColName] != null)
                    {
                        try
                        {
                            grid.Columns[info.ColName].DisplayIndex = info.DisplayIndex.GetValueOrDefault(0);
                        }
                        catch { }
                    }
                }
            }
            #endregion
            #region 设置表列显示宽度值
            if (gridSet.ColWidthList != null && gridSet.ColWidthList.Count > 0)
            {
                foreach (SYS_UserGridColWidth info in gridSet.ColWidthList)
                {
                    if (grid.Columns[info.ColName] == null) continue;
                    if (grid.Columns[info.ColName] != null)
                    {
                        grid.Columns[info.ColName].Width = info.ColWidth.GetValueOrDefault(5);
                    }
                }
            }
            #endregion
            #region 设置自定义列名及是否显示
            if (gridSet.ColNameList != null && gridSet.ColNameList.Count > 0)
            {
                foreach (SYS_UserGridColName info in gridSet.ColNameList)
                {
                    if (grid.Columns[info.ColNameCode] == null) continue;
                    if (grid.Columns[info.ColNameCode] != null)
                    {
                        if (!string.IsNullOrEmpty(info.ColNameCN_Custom))
                        {
                            grid.Columns[info.ColNameCode].HeaderText = info.ColNameCN_Custom;
                        }
                        if (info.ColIsShow.HasValue)
                        {
                            grid.Columns[info.ColNameCode].Visible = info.ColIsShow.Value;
                        }
                    }
                }
            }
            #endregion
            _isSettingCol = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        public void ApplyTabControlSet(DevComponents.DotNetBar.TabControl tabCtr)
        {
            #region 得到表格设置
            _isSettingCol = true;
            if (tabCtr == null || tabCtr.FindForm() == null) return;
            string formName = tabCtr.FindForm().Name;
            string gridName = tabCtr.Name;
            string parentName = "";
            Control parentCon = tabCtr.Parent;
            while (parentCon != null && parentCon.GetType().BaseType != typeof(frmBaseForm))
            {
                parentCon = parentCon.Parent;
            }
            if (parentCon != null) parentName = (parentCon as frmBaseForm).Name;
            SYS_DataGridResult tabCtrSet = GetGridSet(gridName, parentName, formName);
            #endregion
            #region 设置表列显示索引值
            if (tabCtrSet.ColIndexList != null && tabCtrSet.ColIndexList.Count > 0)
            {
                Dictionary<int, DevComponents.DotNetBar.TabItem> tItem = new Dictionary<int, DevComponents.DotNetBar.TabItem>();
                foreach (SYS_UserGridColIndex info in tabCtrSet.ColIndexList)
                {
                    if (tabCtr.Tabs.Count > info.DisplayIndex && tabCtr.Tabs[info.ColName] != null)
                    {
                        if (!tItem.ContainsKey(info.DisplayIndex.Value))
                        {
                            tItem.Add(info.DisplayIndex.Value, tabCtr.Tabs[info.ColName]);
                        }
                    }
                }

                if (tItem != null && tItem.Count > 0)
                {
                    foreach (KeyValuePair<int, DevComponents.DotNetBar.TabItem> cti in tItem)
                    {
                        int right = cti.Key;
                        int left = -1;
                        int i = 0;
                        foreach (DevComponents.DotNetBar.TabItem oti in tabCtr.Tabs)
                        {
                            if (oti.Name == cti.Value.Name)
                            {
                                left = i;
                                break;
                            }
                            i++;
                        }

                        //交换TabItem
                        DevComponents.DotNetBar.TabItem tempTI = tabCtr.Tabs[left];
                        tabCtr.Tabs[left] = tabCtr.Tabs[right];
                        tabCtr.Tabs[right] = tempTI;
                    }
                }
            }
            #endregion
            _isSettingCol = false;
        }
        #endregion
        #region 绑定和初始化表格设置
        public void BindApplyGridEvent(UcDataGridView grid, bool isDefaultCellMouseEvent = true)
        {
            if (grid == null) return;

            #region 统一设置表头高度及列头宽度
            grid.RowHeadersWidth = 30;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 32;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            #endregion

            grid.ColumnWidthChanged += new DataGridViewColumnEventHandler(grid_ColumnWidthChanged);
            grid.ColumnDisplayIndexChanged += new DataGridViewColumnEventHandler(grid_ColumnDisplayIndexChanged);
            grid.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(grid_DataBindingComplete);
            if (isDefaultCellMouseEvent)
            {
                if (grid.FindForm() != null && grid.FindForm().Name != "frmStockSearch")
                {
                    grid.CellMouseEnter += new DataGridViewCellEventHandler(grid_CellMouseEnter);
                    grid.CellMouseLeave += new DataGridViewCellEventHandler(grid_CellMouseLeave);
                }
                else
                {
                    if (grid.Name != "grdStock") //库存查询表格需单独处理
                    {
                        grid.CellMouseEnter += new DataGridViewCellEventHandler(grid_CellMouseEnter);
                        grid.CellMouseLeave += new DataGridViewCellEventHandler(grid_CellMouseLeave);
                    }
                }
            }
            ApplyGridSet(grid);

            #region 统一控制客户和供应商权限
            if (!MySession.IsMainAccount && MySession.EnabledSubAccountRole)
            {
                if (MySession.OwnerRoles != null && MySession.OwnerRoles.Count > 0)
                {
                    string extSupplierInfo = ",供应商,供应商名称,供应商信息,";
                    string extCustomerInfo = ",客户,客户名称,客户信息,";
                    foreach (DataGridViewColumn dgvc in grid.Columns)
                    {
                        if (((extSupplierInfo.IndexOf("," + dgvc.HeaderText + ",") != -1 || dgvc.DataPropertyName.IndexOf("SupplierName") != -1) && !MySession.OwnerRoles.Contains("Mod.供应商管理")) ||
                            (extCustomerInfo.IndexOf("," + dgvc.HeaderText + ",") != -1 || dgvc.DataPropertyName.IndexOf("CustomerName") != -1) && !MySession.OwnerRoles.Contains("Mod.客户管理"))
                        {
                            ZNLCRM.UI.Logic.Sys.GridUserSetting.HideGridColumn(grid, dgvc.Name);
                        }
                    }
                }
            }
            #endregion

            #region 汇总行处理
            if (grid is UcDataGridViewSummary)
            {
                UcDataGridViewSummary ucDgvSummary = grid as UcDataGridViewSummary;
                if (ucDgvSummary.SummaryRowVisible == true && ucDgvSummary.DisplaySumRowHeader == true && ucDgvSummary.SummaryColumns.Length > 0)
                {
                    ucDgvSummary.CreateSummaryRow(); //创建汇总行
                }
            }
            #endregion
        }

        /// <summary>
        /// 选项卡顺序调整时处理
        /// </summary>
        /// <param name="tabCtr"></param>
        public void BindApplyTabControlEvent(DevComponents.DotNetBar.TabControl tabCtr)
        {
            tabCtr.TabMoved += new DevComponents.DotNetBar.TabStrip.TabMovedEventHandler(tabCtr_TabMoved);
            ApplyTabControlSet(tabCtr);
        }

        /// <summary>
        /// 选项卡位置移动事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tabCtr_TabMoved(object sender, DevComponents.DotNetBar.TabStripTabMovedEventArgs e)
        {
            if (_isSettingCol) return;
            SetColIndex((DevComponents.DotNetBar.TabControl)sender, e.Tab.Name, e.NewIndex, e.OldIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ZNLCRM.UI.Logic.Sys.GridUserSetting.SetDataGridViewRowColorByReadOnlyAttribute((sender as DataGridView).Rows[e.RowIndex]);
            }
        }

        /// <summary>
        /// 鼠标移入单元格里事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               //ZNLCRM.UI.Logic.Sys.GridUserSetting.SetDataGridViewRowColor((sender as DataGridView).Rows[e.RowIndex], Color.LightYellow);
            }
        }

        /// <summary>
        /// 按单元格是否只读统一设置颜色 add by:rocky.he 2013-11-15
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ZNLCRM.UI.Logic.Sys.GridUserSetting.SetDataGridViewCellsColorByReadOnlyAttribute(sender as DataGridView);
        }
        #endregion

        #region 保存表格设置
        public int SaveGridSet()
        {
            int ret = 0;
            List<SYS_DataGridResult> saveList = new List<SYS_DataGridResult>();
            foreach (SYS_DataGridResult info in DataGridSetting)
            {
                List<SYS_UserGridColIndex> indexList = new List<SYS_UserGridColIndex>();
                List<SYS_UserGridColWidth> widthList = new List<SYS_UserGridColWidth>();
                List<SYS_UserGridColName> nameList = new List<SYS_UserGridColName>();
                foreach (SYS_UserGridColIndex infox in info.ColIndexList)
                {
                    if (infox.HasChanged())
                        indexList.Add(infox);
                }
                foreach (SYS_UserGridColWidth infox in info.ColWidthList)
                {
                    if (infox.HasChanged())
                        widthList.Add(infox);
                }
                foreach (SYS_UserGridColName infox in info.ColNameList)
                {
                    if (infox.HasChanged())
                        nameList.Add(infox);
                }
                if (indexList.Count > 0 || widthList.Count > 0 || nameList.Count > 0)
                {
                    if (indexList.Count > 0) info.ColIndexList = indexList;
                    if (widthList.Count > 0) info.ColWidthList = widthList;

                    if (MySession.IsMainAccount && nameList.Count > 0)
                    {
                        info.ColNameList = nameList; //只有主帐号才保存自定义列名资料
                    }
                    saveList.Add(info);
                }
            }
            if (saveList.Count <= 0) return 0;

            ExeResult rst = WCFBLL.Execute("ZNLCRM.BLL.Sys.SYS_DataGridBLL", "SaveList", saveList);
            if (rst.Complete == ExeComplete.ErrorEx)
            {
                MessageBox.Show(rst.DebugMsg, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rst.Complete == ExeComplete.WarnEx)
            {
                MessageBox.Show(rst.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GridUserSetting.DataGridSetting = new List<SYS_DataGridResult>();
            return ret;
        }

        #endregion
        #region 表格触发的事件
        #region 表格调整索引触发的事件
        void grid_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (_isSettingCol) return;
            if (e.Column.Frozen) return; //不处理冻结列
            SetColIndex((UcDataGridView)sender, e.Column.Name, e.Column.DisplayIndex, null);
        }
        #endregion
        #region 表格调整宽度触发的事件
        void grid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (_isSettingCol) return;
            SetColIndex((UcDataGridView)sender, e.Column.Name, null, e.Column.Width);
        }
        #endregion
        #endregion
    }
}

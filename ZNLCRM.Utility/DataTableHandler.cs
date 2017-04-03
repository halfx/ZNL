using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;

namespace ZNLCRM.Utility
{
    public class DataTableHandler
    {
        /// <summary>
        /// 将DataGridView单元格值转换为DataTable
        /// </summary>
        /// <param name="dv"></param>
        /// <returns></returns>
        public static DataTable DataGridViewToDataTable(System.Windows.Forms.DataGridView dgv)
        {
            DataTable dt = new DataTable();
            DataColumn dc;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dc = new DataColumn();
                dc.ColumnName = dgv.Columns[i].HeaderText.ToString();
                dt.Columns.Add(dc);
            }
            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                DataRow dr = dt.NewRow();
                for (int x = 0; x < dgv.Columns.Count; x++)
                {
                    dr[x] = dgv.Rows[j].Cells[x].Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>  
        /// 把一个一维数组转换为DataTable  
        /// </summary>  
        /// <param name="ColumnName">列名</param>  
        /// <param name="Array">一维数组</param>  
        /// <returns>返回DataTable</returns>  
        public static DataTable ArrayConvertToDataTable(string ColumnName, string[] Array)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(ColumnName, typeof(string));

            for (int i = 0; i < Array.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[ColumnName] = Array[i].ToString();
                dt.Rows.Add(dr);
            }

            return dt;
        }


        /// <summary>  
        /// 反一个M行N列的二维数组转换为DataTable  
        /// </summary>  
        /// <param name="ColumnNames">一维数组，代表列名，不能有重复值</param>  
        /// <param name="Arrays">M行N列的二维数组</param>  
        /// <returns>返回DataTable</returns>   
        public static DataTable ArrayConvertToDataTable(string[] ColumnNames, string[,] Arrays)
        {
            DataTable dt = new DataTable();

            foreach (string ColumnName in ColumnNames)
            {
                dt.Columns.Add(ColumnName, typeof(string));
            }

            for (int i1 = 0; i1 < Arrays.GetLength(0); i1++)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < ColumnNames.Length; i++)
                {
                    dr[i] = Arrays[i1, i].ToString();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>  
        /// 反一个M行N列的二维数组转换为DataTable  
        /// </summary>  
        /// <param name="Arrays">M行N列的二维数组</param>  
        /// <returns>返回DataTable</returns>  
        public static DataTable ArrayConvertToDataTable(string[,] Arrays)
        {
            DataTable dt = new DataTable();

            int a = Arrays.GetLength(0);
            for (int i = 0; i < Arrays.GetLength(1); i++)
            {
                dt.Columns.Add("col" + i.ToString(), typeof(string));
            }

            for (int i1 = 0; i1 < Arrays.GetLength(0); i1++)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < Arrays.GetLength(1); i++)
                {
                    dr[i] = Arrays[i1, i].ToString();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>
        /// 对象列表转换为表格
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objList"></param>
        /// <returns></returns>
        public static DataTable ObjListToDataTale<T>(List<T> objList)
        {
            DataTable retDt = new DataTable();
            List<PropertyInfo> piList = new List<PropertyInfo>();
            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                Type colType = pi.PropertyType;
                if (!(colType is IEnumerable) && !(colType is IList))
                {
                    if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    {
                        colType = colType.GetGenericArguments()[0];
                    }
                    DataColumn dc = new DataColumn(pi.Name, colType);
                    retDt.Columns.Add(dc);
                    piList.Add(pi);
                }
            }
            foreach (T t in objList)
            {
                DataRow dr = retDt.NewRow();
                foreach (PropertyInfo pi in piList)
                {
                    object value = pi.GetValue(t, null);
                    if (value == null) value = DBNull.Value;
                    dr[pi.Name] = value;
                }
                retDt.Rows.Add(dr);
            }
            return retDt;
        }

        /// <summary>
        /// 为DataTable更新生成的List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> DataTableToEntityForUpdate<T>(DataTable dt, string colKey)
        {
            //先找到表中字段对应实体属性
            List<string> fields = new List<string>();
            List<T> result = new List<T>();
            if (dt == null || dt.Rows.Count <= 0 || string.IsNullOrEmpty(colKey))
            {
                return result;
            }
            if (!dt.Columns.Contains(colKey))
            {
                return result;
            }
            PropertyInfo piKey = typeof(T).GetProperty(colKey);
            if (piKey == null)
            {
                return result;
            }
            foreach (DataColumn dc in dt.Columns)
            {
                PropertyInfo pi = typeof(T).GetProperty(dc.ColumnName);
                if (pi != null)
                {
                    fields.Add(dc.ColumnName);
                }
            }
            if (fields.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr.RowState == DataRowState.Added)
                    {
                        //新增，所以应对字段
                        T entiy = (T)Activator.CreateInstance(typeof(T));
                        foreach (string field in fields)
                        {
                            typeof(T).GetProperty(field).SetValue(entiy, dr[field], null);
                        }
                        result.Add(entiy);
                    }
                    else if (dr.RowState == DataRowState.Modified)
                    {
                        //修改，只记修改字段，如主键外
                        T entiy = (T)Activator.CreateInstance(typeof(T));
                        typeof(T).GetProperty(colKey).SetValue(entiy, dr[colKey], null);
                        foreach (string field in fields)
                        {
                            if (field != colKey)
                            {
                                if (dr[field, DataRowVersion.Original].ToStringHasNull() !=
                                    dr[field, DataRowVersion.Current].ToStringHasNull())
                                {
                                    typeof(T).GetProperty(field).SetValue(entiy, dr[field], null);
                                }
                            }
                        }
                        result.Add(entiy);
                    }
                    else if (dr.RowState == DataRowState.Deleted)
                    {
                        //删除，只记主键如果有IsActive字段的，设置为删除标识
                        T entiy = (T)Activator.CreateInstance(typeof(T));
                        typeof(T).GetProperty(colKey).SetValue(entiy, dr[colKey, DataRowVersion.Original], null);
                        if (fields.Contains("IsActive"))
                        {
                            typeof(T).GetProperty("IsActive").SetValue(entiy, 3, null);
                        }
                        result.Add(entiy);
                    }
                }
            }
            return result;
        }
        #region List集合转DataTable
        /// <summary>
        /// 将集合类转换成DataTable
        /// </summary>
        /// <param name="list">集合</param>
        /// <returns></returns>
        public static DataTable ToDataTable(IList list, string tabName = "Tab1")
        {
            DataTable result = new DataTable();
            result.TableName = tabName;
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }

        /// <summary>
        /// 将泛型集合类转换成DataTable
        /// </summary>
        /// <typeparam name="T">集合项类型</typeparam>
        /// <param name="list">集合</param>
        /// <returns>数据集(表)</returns>
        public static DataTable ToDataTable<T>(IList<T> list, string tabName = "Tab1")
        {
            return ToDataTable<T>(list, null, tabName);
        }

        /// <summary>
        /// 将泛型集合类转换成DataTable
        /// </summary>
        /// <typeparam name="T">集合项类型</typeparam>
        /// <param name="list">集合</param>
        /// <param name="propertyName">需要返回的列及列头描述</param>
        /// <returns>数据集(表)</returns>
        public static DataTable ToDataTable<T>(IList<T> list, Dictionary<string, string> colNameAndText, string tabName = "Tab1")
        {
            DataTable result = new DataTable();
            result.TableName = tabName;
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();

                #region 生成表头
                foreach (PropertyInfo pi in propertys)
                {
                    #region 解决DataSet不支持System.nullable问题
                    Type colType = pi.PropertyType;
                    if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    {
                        colType = colType.GetGenericArguments()[0];
                    }
                    if (colType.GetType() == typeof(System.Decimal)) //数值型的统一按字符处理
                    {
                        colType = typeof(System.String);
                    }
                    #endregion
                    if (colNameAndText.Count == 0)
                    {
                        result.Columns.Add(pi.Name, colType);
                    }
                    else
                    {
                        if (colNameAndText.ContainsKey(pi.Name))
                        {
                            result.Columns.Add(colNameAndText[pi.Name], colType);
                        }
                    }
                }
                #endregion

                #region 生成数据明细
                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        if (obj != null && obj.GetType() == typeof(System.Decimal))
                        {
                            obj = obj.ToStringHasNull().TrimEnd('.', '0');
                        }
                        if (colNameAndText.Count == 0)
                        {
                            tempList.Add(obj);
                        }
                        else
                        {
                            if (colNameAndText.ContainsKey(pi.Name))
                            {
                                tempList.Add(obj);
                            }
                        }
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
                #endregion
            }
            return result;
        }

        #endregion
    }
}

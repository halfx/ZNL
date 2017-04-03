using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ZNLCRM.Utility
{
    public static class StringExt
    {
        // Methods
        public static bool AllowsNullValue(this Type type)
        {
            if (type.IsValueType)
            {
                return type.IsNullableType();
            }
            return true;
        }

        public static Type GetUnderlyingType(this Type type)
        {
            if (!type.IsNullableType())
            {
                return type;
            }
            return Nullable.GetUnderlyingType(type);
        }

        public static bool IsNullableType(this Type type)
        {
            return (type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(Nullable<>)));
        }

        public static bool IsPrimitive(this Type t)
        {
            if (t.IsGenericType)
            {
                return (t.IsNullableType() && Nullable.GetUnderlyingType(t).IsPrimitive());
            }
            return ((((((t == typeof(string)) || (t == typeof(short))) || ((t == typeof(ushort)) || (t == typeof(int)))) || (((t == typeof(uint)) || (t == typeof(long))) || ((t == typeof(ulong)) || (t == typeof(float))))) || ((((t == typeof(double)) || (t == typeof(decimal))) || ((t == typeof(char)) || (t == typeof(byte)))) || ((t == typeof(bool)) || (t == typeof(DateTime))))) || (t == typeof(Guid)));
        }

        public static string Join(this string[] array, char splitChar)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                builder.Append(array[i]);
                builder.Append(splitChar);
            }
            return builder.ToString().TrimEnd(new char[] { splitChar });
        }

        public static string MD5(this string text)
        {
            byte[] bytes = Encoding.Default.GetBytes(text);
            byte[] buffer2 = new MD5CryptoServiceProvider().ComputeHash(bytes);
            string str = "";
            foreach (byte num in buffer2)
            {
                if (num < 0x10)
                {
                    str = str + "0" + num.ToString("X");
                }
                else
                {
                    str = str + num.ToString("X");
                }
            }
            return str.ToLower();
        }
        public static int VarcharLen(this string stringToSub)
        {
            if (stringToSub == null)
            {
                return 0;
            }
            return Encoding.Default.GetBytes(stringToSub).Length;
        }
        public static string SubStr(this string stringToSub, int length)
        {
            if (stringToSub == null)
            {
                return stringToSub;
            }
            if (Encoding.Default.GetBytes(stringToSub).Length <= length)
            {
                return stringToSub;
            }
            Regex regex = new Regex("[^\0-\x00ff]+", RegexOptions.Compiled);
            char[] chArray = stringToSub.ToCharArray();
            StringBuilder builder = new StringBuilder();
            int num2 = 0;
            for (int i = 0; i < chArray.Length; i++)
            {
                if (regex.IsMatch(chArray[i].ToString()))
                {
                    if ((length - num2) > 1)
                    {
                        builder.Append(chArray[i]);
                    }
                    num2 += 2;
                }
                else
                {
                    builder.Append(chArray[i]);
                    num2++;
                }
                if (num2 >= length)
                {
                    break;
                }
            }
            return builder.ToString();
        }
        #region GUID是否为空
        public static bool IsGuidEmpty(this Guid? guid)
        {
            return guid == null || guid == Guid.Empty;
        }
        #endregion

        #region 转换为GUID
        public static Guid ToGuid(this string value)
        {
            Guid result = Guid.Empty;
            try
            {
                result = new Guid(value);
            }
            catch
            { }
            return result;
        }

        public static Guid ToGuid(this object value)
        {
            Guid result = Guid.Empty;
            if (value != null && value != DBNull.Value)
            {
                try
                {
                    result = (Guid)(value);
                }
                catch
                { }
            }
            return result;
        }
        #endregion
        #region 字符转整数
        /// <summary>
        /// 字符转整数，不能转返回0
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns>整数</returns>
        public static int ToInt32(this string value)
        {
            int result = 0;
            int.TryParse(value, out result);
            return result;
        }

        /// <summary>
        /// 字符转整数，不能转返回设定默认值
        /// </summary>
        /// <param name="value">字符</param>
        /// <param name="defaultValue">不能转返回的值</param>
        /// <returns>整数</returns>
        public static int ToInt32(this string value, int defaultValue)
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }
            int.TryParse(value, out defaultValue);
            return defaultValue;
        }

        /// <summary>
        /// 对象值转整数，不能转返回0
        /// </summary>
        /// <param name="value">对象值</param>
        /// <returns></returns>
        public static int ToInt32(this object value)
        {
            return value.ToInt32(0);
        }

        /// <summary>
        /// 对象值转整数，不能转返回设定默认值
        /// </summary>
        /// <param name="value">对象值</param>
        /// <param name="defaultValue">不能转返回的值</param>
        /// <returns>整数</returns>
        public static int ToInt32(this object value, int defaultValue)
        {
            if (value != null && value != DBNull.Value)
            {
                int.TryParse(value.ToString(), out defaultValue);
            }
            return defaultValue;
        }
        #endregion

        #region 字符转浮点数
        /// <summary>
        /// 字符转浮点数，不能转返回0
        /// </summary>
        /// <param name="value">字符</param>
        /// <returns>整数</returns>
        public static double ToDouble(this object value)
        {
            return ToDouble(value, 0);
        }

        /// <summary>
        /// 字符转浮点数，不能转返回设定默认值
        /// </summary>
        /// <param name="value">字符</param>
        /// <param name="defaultValue">不能转返回的值</param>
        /// <returns>浮点数</returns>
        public static double ToDouble(this object value, double defaultValue)
        {
            if (value != null && value != DBNull.Value)
            {
                double.TryParse(value.ToString(), out defaultValue);
            }
            return defaultValue;
        }
        #endregion

        #region 字符转十进制数值型
        /// <summary>
        /// 字符转十进制数值型，不能转返回设定默认值
        /// </summary>
        /// <param name="value">字符</param>
        /// <param name="defaultValue">不能转返回的值</param>
        /// <returns>十进制数值型</returns>
        public static decimal ToDecimal(this object value)
        {
            return ToDecimal(value, 0);
        }

        /// <summary>
        /// 字符转十进制数值型，不能转返回设定默认值
        /// </summary>
        /// <param name="value">字符</param>
        /// <param name="defaultValue">不能转返回的值</param>
        /// <returns>十进制数值型</returns>
        public static decimal ToDecimal(this object value, decimal defaultValue)
        {
            if (value != null && value != DBNull.Value)
            {
                decimal.TryParse(value.ToString(), out defaultValue);
            }
            return defaultValue;
        }

        public static string ToDateString(this DateTime? value)
        {
            string ret = "";
            if (value != null)
            {
                ret=value.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return ret;
        }
        #endregion

        #region 判断字符串是否整型或者数值型
        /// <summary>
        /// 判断字符串是否整型或者数值型(isInt=true为整型,isInt=false时为数值型)
        /// </summary>
        /// <param name="str">需要判断字符串</param>
        /// <param name="isInt">是否整型(isInt=true为整型,isInt=false时为数值型)</param>
        /// <returns>结果</returns>
        public static bool RegIsNumber(this string str, bool isInt)
        {
            if (str == null)
            {
                return false;
            }
            if (isInt)
            {
                return Regex.IsMatch(str, "^[0-9]+$");
            }
            else
            {
                return Regex.IsMatch(str, "^[0-9]+(.{0,1}[0-9])*$");
            }
        }

        /// <summary>
        /// 判断字符串是否整型
        /// </summary>
        /// <param name="str">需要判断字符串</param>
        /// <returns>结果</returns>
        public static bool RegIsNumber(this string str)
        {
            if (str == null)
            {
                return false;
            }
            return Regex.IsMatch(str, "^[0-9]+$");
        }
        #endregion

        #region 字符串转时间
        /// <summary>
        /// 字符串转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        public static DateTime ToDateTime(this string time)
        {
            return ToDateTime(time, new DateTime());
        }

        /// <summary>
        /// 字符串转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        /// <param name="defaultValue">默认值</param>
        public static DateTime ToDateTime(this string time, DateTime defaultValue)
        {
            if (!string.IsNullOrEmpty(time))
            {
                DateTime.TryParse(time, out defaultValue);
            }
            return defaultValue;
        }

        /// <summary>
        /// 对象转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        public static DateTime ToDateTime(this object time)
        {
            return ToDateTime(time, new DateTime());
        }

        /// <summary>
        /// 对象转时间
        /// </summary>
        /// <param name="time">字符串日期</param>
        /// <param name="defaultValue">默认值</param>
        public static DateTime ToDateTime(this object time, DateTime defaultValue)
        {
            if (time != null && time != DBNull.Value && time.ToString() != "")
            {
                DateTime.TryParse(time.ToString(), out defaultValue);
            }
            else
            {
                defaultValue = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            return defaultValue;
        }
        #endregion

        #region 转字符串
        /// <summary>
        /// 转字符串，如果传入的是NULL，返回string.Empty(空字符串)
        /// </summary>
        /// <param name="objValue">要转成String的值</param>
        /// <returns>String的值</returns>
        public static string ToStringHasNull(this object objValue)
        {
            return ToStringHasNull(objValue, string.Empty);
        }

        /// <summary>
        /// 转字符串，如果传入的是NULL，返回设置的默认的字符串
        /// </summary>
        /// <param name="objValue">要转成String的值</param>
        /// <param name="defaultValue">默认的字符串</param>
        /// <returns>String的值</returns>
        public static string ToStringHasNull(this object objValue, string defaultValue)
        {
            if (objValue != null && objValue != DBNull.Value)
            {
                return objValue.ToString().Trim();
            }

            return defaultValue;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objValue"></param>
        /// <returns></returns>
        public static bool ToBooleanHasNull(this object objValue)
        {
            if (objValue == null || objValue == DBNull.Value || objValue.ToString().Trim() == "")
            {
                return false;
            }
            return Convert.ToBoolean(objValue.ToString());
        }

        public static bool IsEmpty(this Guid? value)
        {
            return value == null || value == Guid.Empty;
        }


        public static bool IsEmpty(this DateTime? value)
        {
            return value == null || value == DateTime.MinValue;
        }

        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        #region 给定时间到现在的间隔
        /// <summary>
        /// 间隔小于分钟的，显示多少秒
        /// 间隔小于小时的，显示多少分钟
        /// 间隔小于天的，显示多少小时
        /// 间隔大于15天，就显示给点的时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ToNowInterval(this DateTime time)
        {
            TimeSpan ts = DateTime.Now.Subtract(time);
            if (ts.TotalMilliseconds < 0)
                return "";
            string retDate = "";
            if (ts.Days >= 15)
                retDate = (time).ToString("yyyy-MM-dd HH:mm:ss");
            else if (ts.Days >= 1)
                retDate = ts.Days.ToString() + "天以前";
            else if (ts.Hours >= 1)
                retDate = ts.Hours.ToString() + "小时以前";
            else if (ts.Minutes >= 1)
                retDate = ts.Minutes.ToString() + "分钟以前";
            else if (ts.Seconds >= 1)
                retDate = ts.Seconds.ToString() + "秒以前";
            return retDate;
        }
        #endregion

        #region 验证字符串格式是否合法，如(emali,电话格式,网址等)
        public enum StringFormat
        {
            Email,
            Telphone,
            Mobile,
            WebSite
        }
        /// <summary>
        /// 验证字符串格式是否合法,如果为空则返回为true
        /// </summary>
        /// <param name="input">要判定的字符串格式</param>
        /// <param name="format">格式类型</param>
        /// <returns></returns>
        public static bool CheckStringFormart(string input, StringFormat format)
        {
            bool ret = false;
            if (format == StringFormat.Email)
            {
                ret = Regex.IsMatch(input, @"^[a-zA-Z0-9_+.-]+\@([a-zA-Z0-9-]+\.)+[a-zA-Z0-9]{2,4}$");
            }
            else if (format == StringFormat.Telphone)
            {
                ret = Regex.IsMatch(input, @"^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$");
            }
            else if (format == StringFormat.Mobile)
            {
                ret = Regex.IsMatch(input, @"^((\(\d{2,3}\))|(\d{3}\-))?1\d{10}");
            }
            else if (format == StringFormat.WebSite)
            {
                ret = Regex.IsMatch(input, @"(http|https|ftp)\:(\/\/|\\\\).+(net|com|cn|org|cc|tv|[0-9]{1,3})");
            }
            return ret;

        }
        #endregion
        public static string RemoveHtmlTag(this string strHtml)
        {
            return Regex.Replace(strHtml, @"(?i)<[^>]*>", "");
        }


        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source)
        {
            return new ObjectShredder<T>().Shred(source, null, null);
        }

        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source,
                                                    DataTable table, LoadOption? options)
        {
            return new ObjectShredder<T>().Shred(source, table, options);
        }

        /// <summary>
        /// 转换DataTable到实体集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="thunk">自定义转换方法</param>
        /// <param name="excludeFieldNames">不予转换到实体字段的名称数组</param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataTable table, Action<DataRow, T> thunk = null, params string[] excludeFieldNames)
            where T : class,new()
        {
            var list = new List<T>();
            if (table == null || table.Rows.Count == 0)
                return list;

            Type instanceType = typeof(T);
            List<string> fieldNames = table.Columns.Cast<DataColumn>()
                .Where(c => instanceType.GetProperty(c.ColumnName) != null)
                .Select(c => c.ColumnName).ToList();

            if (excludeFieldNames != null && excludeFieldNames.Length > 0)
                fieldNames.RemoveAll(excludeFieldNames.Contains);

            if (fieldNames == null && fieldNames.Count > 0)
                return list;

            Action<DataRow, T> instanceThunk = thunk;
            if (fieldNames == null && fieldNames.Count > 0 && instanceThunk != null)
            {
                // 带有转换方法
                instanceThunk = (row, instance) =>
                {
                    foreach (string fieldName in fieldNames)
                    {
                        object value = row[fieldName];
                        if (value == null)
                            continue;

                        if (!(value is DBNull))
                            instanceType.GetProperty(fieldName).SetValue(instance, value, null);
                    }
                    thunk(row, instance);
                };
            }
            else
            {
                instanceThunk = (row, instance) =>
                {
                    foreach (string fieldName in fieldNames)
                    {
                        object value = row[fieldName];
                        if (value == null || value == DBNull.Value)
                            continue;

                        instanceType.GetProperty(fieldName).SetValue(instance, value, null);
                    }
                };

            }
            MethodInfo acceptMi = instanceType.GetMethod("AcceptChanged");
            foreach (DataRow row in table.Rows)
            {
                T entity = Activator.CreateInstance<T>();
                instanceThunk(row, entity);
                if (acceptMi != null)
                    acceptMi.Invoke(entity, null);
                list.Add(entity);
            }
            return list;
        }
    }
    
}

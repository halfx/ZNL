using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ZNLCRM.Utility
{
    public class StringHandler
    {
        #region 动态调用wcf服务

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="pUrl"></param>
        ///// <param name="pMethodName"></param>
        ///// <param name="pParams"></param>
        ///// <returns></returns>
        //public static object ExecuteMethod<T>(string pUrl, string pMethodName, Binding bindinginstance, params object[] pParams)
        //{
        //    EndpointAddress address = new EndpointAddress(pUrl);
        //    using (ChannelFactory<T> channel = new ChannelFactory<T>(bindinginstance, address))
        //    {
        //        T instance = channel.CreateChannel();
        //        using (instance as IDisposable)
        //        {
        //            try
        //            {
        //                Type type = typeof(T);
        //                MethodInfo mi = type.GetMethod(pMethodName);
        //                return mi.Invoke(instance, pParams);
        //            }
        //            catch (TimeoutException)
        //            {
        //                (instance as ICommunicationObject).Abort();
        //                throw;
        //            }
        //            catch (CommunicationException)
        //            {
        //                (instance as ICommunicationObject).Abort();
        //                throw;
        //            }
        //            catch (Exception ex)
        //            {
        //                (instance as ICommunicationObject).Abort();
        //                throw ex;
        //            }
        //        }
        //    }
        //}
        /// <summary>
        /// 汉字转拼音
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string GetChineseSpell(string strText)
        {
            int len = strText.Length;
            string myStr = "";
            for (int i = 0; i < len; i++)
            {
                myStr += getSpell(strText.Substring(i, 1));
            }
            return myStr;
        }

        public static string getSpell(string cnChar)
        {
            byte[] arrCN = Encoding.Default.GetBytes(cnChar);
            if (arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++)
                {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "*";
            }
            else return cnChar;
        }  

        #endregion
        /// <summary>
        /// 替换字符带有括号中的数值
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="replaceText"></param>
        /// <returns></returns>
        public static string ReplaceStrForBracket(string inputText, string replaceText)
        {
            string ret = "";
            System.Text.RegularExpressions.Regex regx = new System.Text.RegularExpressions.Regex("(\\()(.*)(\\))");
            ret = regx.Replace(inputText, "(" + replaceText + ")");
            return ret;
        }
        /// <summary>
        /// 清除字符串的Html标记
        /// </summary>
        /// <param name="HTML"></param>
        /// <returns></returns>
        public static string ClearHTMLTags(string HTML)
        {
            string[] Regexs ={
                        @"<script[^>]*?>.*?</script>",
                        @"<(\/\s*)?!?((\w+:)?\w+)(\w+(\s*=?\s*(([""'])(\\[""'tbnr]|[^\7])*?\7|\w+)|.{0})|\s)*?(\/\s*)?>",
                        @"([\r\n])[\s]+",
                        @"&(quot|#34);",
                        @"&(amp|#38);",
                        @"&(lt|#60);",
                        @"&(gt|#62);",
                        @"&(nbsp|#160);",
                        @"&(iexcl|#161);",
                        @"&(cent|#162);",
                        @"&(pound|#163);",
                        @"&(copy|#169);",
                        @"&#(\d+);",
                        @"-->",
                        @"<!--.*\n"
                             };

            string[] Replaces ={
                            "",
                            "",
                            "",
                            "\"",
                            "&",
                            "<",
                            ">",
                            " ",
                            "\xa1", //chr(161),
                            "\xa2", //chr(162),
                            "\xa3", //chr(163),
                            "\xa9", //chr(169),
                            "",
                            "\r\n",
                            ""
                               };

            string s = HTML.Trim();
            for (int i = 0; i < Regexs.Length; i++)
            {
                s = new Regex(Regexs[i], RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(s, Replaces[i]);
            }
            s.Replace("<", "");
            s.Replace(">", "");
            s.Replace("\r\n", "");
            return s;
        }
        public static string SubStr(string stringToSub, int length)
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
        public static string SubString(string inputString, int length)
        {
            if (Encoding.UTF8.GetByteCount(inputString) < length)
            {
                return inputString;
            }
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = Encoding.Default.GetBytes(inputString);
            int i = 0;
            while (tempLen < s.Length && tempLen < length)
            {
                if ((int)s[tempLen] >= 127)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen++;
                }
                tempString += inputString.Substring(i, 1);
                i++;
            }
            return tempString;
        }
        /// <summary>
        /// 判断两个字符串是否相等
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool IsTheSameString(string str1, string str2)
        {
            return str1.ToStringHasNull() == str2.ToStringHasNull();
        }
        /// <summary>
        /// 比较两个基本数据
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static int Compare(object value1, object value2)
        {
            int sortResult = 0;
            if (value1 == DBNull.Value && value2 == DBNull.Value)
            {
                sortResult = 0;
            }
            else if (value1 != DBNull.Value && value2 == DBNull.Value)
            {
                sortResult = 1;
            }
            else if (value1 == DBNull.Value && value2 != DBNull.Value)
            {
                sortResult = -1;
            }
            else if (value1 is string)
            {
                sortResult = value1.ToString().CompareTo(value2.ToString());
            }
            else if (value1 is int)
            {
                sortResult = System.Convert.ToInt32(value1).CompareTo(System.Convert.ToInt32(value2));
            }
            else if (value1 is decimal)
            {
                sortResult = System.Convert.ToDecimal(value1).CompareTo(System.Convert.ToDecimal(value2));
            }
            else if (value1 is DateTime)
            {
                sortResult = System.Convert.ToDateTime(value1).CompareTo(System.Convert.ToDateTime(value2));
            }
            return sortResult;
        }
        #region 剪切板的数据(Excel)转为了二维数组，列以\t分隔，行以\n分隔
        public static string[,] ExcelPasteToArray()
        {
            // 获取剪切板的内容，并按行分割   
            string pasteText = System.Windows.Forms.Clipboard.GetText();
            if (string.IsNullOrEmpty(pasteText))
                return null;
            //获得当前剪贴板内容的行、列数
            int tnum = Regex.Matches(pasteText, "\t").Count;
            int nnum = Regex.Matches(pasteText, "\n").Count;

            string[,] data;
            //粘贴板上的数据来自于EXCEL时，每行末都有\n，在DATAGRIDVIEW内复制时，最后一行末没有\n
            if (pasteText.Substring(pasteText.Length - 1, 1) == "\n")
            {
                nnum = nnum - 1;
            }

            tnum = tnum / (nnum + 1);
            data = new string[nnum + 1, tnum + 1];//定义一个二维数组

            String[] rowstrs = pasteText.Split('\n');
            int i = 0;
            int j = 0;
            foreach (string rowstr in pasteText.Split('\n'))
            {
                if (i > nnum)
                {
                    break;
                }
                j = 0;
                foreach (string str in rowstr.Split('\t'))
                {
                    if (j < tnum)
                    {
                        data[i, j] = str;
                    }
                    else if (j == tnum)
                    {
                        data[i, j] = str.Replace("\r", "");
                    }
                    else
                    {
                        break;
                    }
                    j++;
                }
                i++;
            }
            //string rowstr = "";
            ////MessageBox.Show(pasteText.IndexOf("B").ToString());
            ////对数组赋值
            //for (int i = 0; i < (nnum + 1); i++)
            //{
            //    for (int colIndex = 0; colIndex < (tnum + 1); colIndex++)
            //    {
            //        try
            //        {
            //            //一行中的最后一列
            //            if (colIndex == tnum && pasteText.IndexOf("\r") != -1)
            //            {
            //                rowstr = pasteText.Substring(0, pasteText.IndexOf("\r"));
            //            }
            //            //最后一行的最后一列
            //            if (colIndex == tnum && pasteText.IndexOf("\r") == -1)
            //            {
            //                rowstr = pasteText.Substring(0);
            //            }
            //            //其他行列
            //            if (colIndex != tnum)
            //            {
            //                rowstr = pasteText.Substring(0, pasteText.IndexOf("\t"));
            //                pasteText = pasteText.Substring(pasteText.IndexOf("\t") + 1);
            //            }
            //            data[i, colIndex] = rowstr;
            //        }
            //        catch(Exception ex)
            //        {
            //            string msg = ex.Message;
            //        }
            //    }
            //    //截取下一行数据
            //    pasteText = pasteText.Substring(pasteText.IndexOf("\n") + 1);
            //}
            return data;
        }
        #endregion

        /// <summary>
        /// 类型是否包涵某个属性
        /// </summary>
        /// <param name="objType"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static bool TypeContainProperty(Type objType, string propertyName)
        {
            return objType.GetProperty(propertyName) != null;
        }
        /// <summary>
        /// 获取类型属性数据类型
        /// </summary>
        /// <param name="objType"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static Type GetPropertyType(Type objType, string propertyName)
        {
            PropertyInfo pi = objType.GetProperty(propertyName);
            return pi.PropertyType;
        }
        /// <summary>
        /// 把字符串转换为基本的数据类型
        /// </summary>
        /// <param name="strType"></param>
        /// <returns></returns>
        public static object StringToType(string strType, string value)
        {
            object objRet = null;
            try
            {
                switch (strType.ToLower())
                {
                    case "int32":
                        objRet = Convert.ToInt32(value);
                        break;
                    case "boolean":
                        objRet = Convert.ToBoolean(value);
                        break;
                    case "decimal":
                        objRet = Convert.ToDecimal(value);
                        break;
                    case "datetime":
                        objRet = Convert.ToDateTime(value);
                        break;
                    default:
                        objRet = value.ToStringHasNull();
                        break;
                }
            }
            catch
            { }
            return objRet;
        }
        /// <summary>
        /// 对象间的相互转换
        /// </summary>
        /// <param name="fromObj">要转的对象</param>
        /// <param name="toObj">转换的目标对象</param>
        public static Q CopyObjToObj<T, Q>(T fromObj, Q toObj)
        {
            PropertyInfo[] arrProperty = fromObj.GetType().GetProperties();
            PropertyInfo toProperty = null;
            Type toType = toObj.GetType();
            object objValue = null;
            List<string> lstChangField = null;
            PropertyInfo proInfo = typeof(T).GetProperty("UpdateList");
            if (proInfo != null)
            {
                lstChangField = proInfo.GetValue(fromObj, null) as List<string>;
                if (lstChangField.Count <= 0) lstChangField = null;
            }
            foreach (PropertyInfo property in arrProperty)
            {
                if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) continue;
                objValue = null;
                toProperty = toType.GetProperty(property.Name);
                if (toProperty != null && property.PropertyType == toProperty.PropertyType)
                {
                    objValue = property.GetValue(fromObj, null);
                    if (objValue == null && lstChangField != null && lstChangField.Exists(a => a == property.Name))
                    {
                        toProperty.SetValue(toObj, objValue, null);
                    }
                    else if (objValue != null)
                    {
                        toProperty.SetValue(toObj, objValue, null);
                    }
                }
            }
            return toObj;
        }
        /// <summary>
        /// 将一集合复制到另一集合
        /// </summary>
        /// <typeparam name="T">要复制的集合类型</typeparam>
        /// <typeparam name="Q">要复制目标集合类型</typeparam>
        /// <param name="fromList">要复制的集合类</param>
        /// <returns></returns>
        public static List<Q> CopyListToList<T, Q>(List<T> fromList)
        {
            List<Q> lst = new List<Q>();
            T t;
            Q q;
            for (int i = 0; i < fromList.Count; i++)
            {
                t = fromList[i];
                q = (Q)t.GetType().Assembly.CreateInstance(typeof(Q).FullName);
                q = CopyObjToObj<T, Q>(fromList[i], q);
                lst.Add(q);
            }
            return lst;
        }
        public static T CompareObject<T>(T fromObj, T compareObj)
        {
            bool chang = false;
            Type fromType = fromObj.GetType();
            PropertyInfo[] properties = fromType.GetProperties();
            object fromV, toV;
            object ret = fromType.Assembly.CreateInstance(typeof(T).FullName);
            foreach (PropertyInfo info in properties)
            {
                fromV = info.GetValue(fromObj, null);
                toV = info.GetValue(compareObj, null);
                if (info.PropertyType.IsGenericType && info.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) continue;
                if (fromV == null && toV == null) continue;
                if ((fromV == null && fromV != toV) || !fromV.Equals(toV))
                {
                    //解决当字符串变成空字符串时为null导致不处理问题 addby:rocky.he
                    if (fromV != null && fromV.GetType() == typeof(String) && !string.IsNullOrEmpty(fromV.ToStringHasNull()) && toV == null)
                    {
                        toV = string.Empty;
                    }
                    info.SetValue(ret, toV, null);
                    chang = true;
                }
            }
            if (!chang) ret = null;
            return ((T)ret);
        }
        public static bool CompareObject<T, Q>(T obj1, Q obj2)
        {
            bool ret = false;
            string name = "";
            PropertyInfo[] propertis = obj1.GetType().GetProperties();
            Type type2 = obj2.GetType();
            PropertyInfo propertyInfo2;
            object objv1 = null, objv2 = null;
            foreach (PropertyInfo info in propertis)
            {
                name = info.Name;
                propertyInfo2 = type2.GetProperty(name);
                objv1 = info.GetValue(obj1, null);
                if (propertyInfo2 != null)
                {
                    objv2 = propertyInfo2.GetValue(obj2, null);
                    if (objv1 != objv2) { ret = true; break; }
                }
            }
            return ret;
        }
        /// <summary>        
        /// 格式化显示时间为几个月,几天前,几小时前,几分钟前,或几秒前        
        /// </summary>        
        /// <param name="dt">要格式化显示的时间</param>        
        /// <returns>几个月,几天前,几小时前,几分钟前,或几秒前</returns>        
        public static string DateStringFromNow(DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;
            if (span.TotalDays > 60)
            {
                return dt.ToShortDateString();
            }
            else if (span.TotalDays > 30)
            {
                return "1个月前";
            }
            else if (span.TotalDays > 14)
            {
                return "2周前";
            }
            else if (span.TotalDays > 7)
            {
                return "1周前";
            }
            else if (span.TotalDays > 1)
            {
                return string.Format("{0}天前", (int)Math.Floor(span.TotalDays));
            }
            else if (span.TotalHours > 1)
            {
                return string.Format("{0}小时前", (int)Math.Floor(span.TotalHours));
            }
            else if (span.TotalMinutes > 1)
            {
                return string.Format("{0}分钟前", (int)Math.Floor(span.TotalMinutes));
            }
            else if (span.TotalSeconds >= 1)
            {
                return string.Format("{0}秒前", (int)Math.Floor(span.TotalSeconds));
            }
            else
            {
                return "1秒前";
            }
        }
        /// <summary>
        /// 删除字符串中的特殊字符
        /// </summary>
        /// <param name="strSource"></param>
        /// <param name="strFilter"></param>
        /// <returns></returns>
        public static string FilterChars(string strSource, string strFilter)
        {
            string strRet = strSource;
            if (!string.IsNullOrEmpty(strFilter))
            {
                foreach (string str in strFilter.Split(','))
                {
                    strRet = strRet.Replace(str, "");
                }
            }
            return strRet;
        }
        /// <summary>
        /// 小写转换为大写金额
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="tranType"></param>
        /// <returns></returns>
        public static string MoneyUpper(decimal amount, int tranType = 0)
        {
            string strLowor = string.Empty;//小写金额
            string strUpper = string.Empty;//大写金额
            string strUpperPart = string.Empty;
            string[] dUpper = new string[] { "元", "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            string[] cUnit = new string[] { "分", "角", "", "", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿", "拾", "佰", "仟", "万" };
            int i = 0;
            int index = 0;
            strLowor = Math.Round(amount, 2, MidpointRounding.AwayFromZero).ToString();//四舍五入为指定的精度并删除数据左右空格

            while (i <= strLowor.Length - 1)
            {
                strUpperPart = string.Empty;
                index = -1;
                if (!int.TryParse(strLowor.Substring(strLowor.Length - i - 1, 1), out index))
                {
                    index = -1;
                }
                index++;
                strUpperPart = dUpper[index];
                if (i < 15)
                {
                    strUpperPart += cUnit[i];
                }
                strUpper = strUpperPart + strUpper;
                i++;
            }

            if (tranType == 0)
            {
                strUpper = strUpper.Replace("零拾", "零");
                strUpper = strUpper.Replace("零佰", "零");
                strUpper = strUpper.Replace("零仟", "零");
                strUpper = strUpper.Replace("零零零", "零");
                strUpper = strUpper.Replace("零零", "零");
                strUpper = strUpper.Replace("零角零分", "整");
                strUpper = strUpper.Replace("零分", "整");
                strUpper = strUpper.Replace("零角", "零");
                strUpper = strUpper.Replace("零亿零万零元", "亿元");
                strUpper = strUpper.Replace("亿零万零元", "亿元");
                strUpper = strUpper.Replace("零亿零万", "亿");
                strUpper = strUpper.Replace("零万零元", "万元");
                strUpper = strUpper.Replace("万零元", "万元");
                strUpper = strUpper.Replace("零亿", "亿");
                strUpper = strUpper.Replace("零万", "万");
                strUpper = strUpper.Replace("零元", "元");
                strUpper = strUpper.Replace("零零", "零");
            }
            //对壹元以下的金额的处理 
            if ("元" == strUpper.Substring(0, 1))
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }

            if ("零" == strUpper.Substring(0, 1))
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }

            if ("角" == strUpper.Substring(0, 1))
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }

            if ("分" == strUpper.Substring(0, 1))
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }

            if ("整" == strUpper.Substring(0, 1))
            {
                strUpper = "零元整";
            }
            return strUpper;
        }
        /// <summary>
        /// 转换网上电话
        /// </summary>
        /// <param name="telphone"></param>
        /// <returns>返回以逗号分隔(联系人、电话)</returns>
        public static List<string> SplitWebTelehpone(string telphone)
        {
            List<string> retTels = new List<string>();
            telphone = telphone.Replace("-", "");
            telphone = Regex.Replace(telphone, "QQ[：:]?[0-9]+[,]?", "");
            string[] contacts = telphone.Split(new string[] { ",", "/", "，" }, StringSplitOptions.RemoveEmptyEntries);
            string prefixNumber = string.Empty;
            foreach (string contact in contacts)
            {
                string tel = Regex.Match(contact, @"[\d-]+").Value;
                string con = Regex.Replace(contact, @"[\d-]+", "");
                if (!string.IsNullOrEmpty(tel))
                {
                    if (tel.Length >= 8)
                    {
                        prefixNumber = tel.Substring(0, tel.Length - 8);
                        if (prefixNumber.IndexOf("86") == 0 || prefixNumber.IndexOf("086") == 0 || prefixNumber.IndexOf("0086") == 0)
                        {
                            //去掉国际区号
                            prefixNumber = prefixNumber.Substring(prefixNumber.IndexOf("86") + 2);
                        }
                        if (prefixNumber.Length > 2)
                        {
                            if (prefixNumber.Substring(0, 1) != "0" && prefixNumber.Substring(0, 1) != "1")
                            {
                                prefixNumber = "0" + prefixNumber;
                            }
                        }
                        tel = prefixNumber + tel.Substring(tel.Length - 8);
                    }
                }
                if (tel.Length >= 8)
                {
                    if (retTels.Count(a => a.IndexOf(tel) >= 0) == 0)
                    {
                        retTels.Add(con.ToStringHasNull() + "," + tel.ToStringHasNull());
                    }
                }
            }
            return retTels;
        }
        

    }
}

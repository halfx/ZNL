using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ZNLCRM.Utility
{
    public class EntityHandler
    {
        public static bool CompareObject<T>(T obj1, T obj2)
        {
            return CompareObject<T, T>(obj1, obj2,null);
        }
        public static bool CompareObject<T>(T obj1, T obj2, List<string> includeProperties)
        {
            return CompareObject<T, T>(obj1, obj2, includeProperties);
        }
        public static bool CompareObject<T, Q>(T obj1, Q obj2,List<string> includeProperties)
        {
            bool ret = false;
            string name = "";
            if (obj1 == null && obj2 == null) return false;
            if (obj1 == null && obj2 != null || obj1 != null && obj2 == null) return true;

            PropertyInfo[] propertis = obj1.GetType().GetProperties();
            Type type2 = obj2.GetType();
            Type valueType;
            PropertyInfo propertyInfo2;
            object objv1 = null, objv2 = null;
            foreach (PropertyInfo info in propertis)
            {
                name = info.Name;
                if (includeProperties != null && !includeProperties.Contains(name)) continue;
                propertyInfo2 = type2.GetProperty(name);
                objv1 = info.GetValue(obj1, null);
                if (propertyInfo2 != null && propertyInfo2.CanRead)
                {
                    objv2 = propertyInfo2.GetValue(obj2, null);
                    if (objv1 == null && objv2 == null) continue;
                    if (objv1 != null) valueType = objv1.GetType();
                    else valueType = objv2.GetType();
                    if (valueType == typeof(string))
                    {
                        if (objv1.ToStringHasNull() != objv2.ToStringHasNull()) ret = true;
                    }
                    else if (valueType == typeof(bool) || valueType == typeof(bool?))
                    {
                        if (objv1.ToBooleanHasNull() != objv2.ToBooleanHasNull()) ret = true;
                    }
                    else if (valueType == typeof(int) || valueType == typeof(int?))
                    {
                        if (objv1.ToInt32() != objv2.ToInt32()) ret = true;
                    }
                    else if (valueType == typeof(decimal) || valueType == typeof(decimal?))
                    {
                        if (objv1.ToDecimal() != objv2.ToDecimal()) ret = true;
                    }
                    else if (valueType == typeof(double) || valueType == typeof(double?))
                    {
                        if (objv1.ToDouble() != objv2.ToDouble()) ret = true;
                    }
                    else if (valueType == typeof(Guid) || valueType == typeof(Guid?))
                    {
                        if (objv1.ToGuid() != objv2.ToGuid()) ret = true;
                    }
                    else if (valueType == typeof(DateTime) || valueType == typeof(DateTime?))
                    {
                        if (objv1.ToDateTime() != objv2.ToDateTime()) ret = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return ret;
        }

        public static T Clone<T>(T obj1)
        {
            T obj2 = Activator.CreateInstance<T>();
            string name = "";
            PropertyInfo[] propertis = obj1.GetType().GetProperties();
            Type type2 = obj2.GetType();
            PropertyInfo propertyInfo2;
            object objv1 = null;
            foreach (PropertyInfo info in propertis)
            {
                name = info.Name;
                propertyInfo2 = type2.GetProperty(name);
                objv1 = info.GetValue(obj1, null);
                if (propertyInfo2 != null && propertyInfo2.CanWrite)
                {
                    propertyInfo2.SetValue(obj2, objv1, null);
                }
            }
            return obj2;
        }

    }
}

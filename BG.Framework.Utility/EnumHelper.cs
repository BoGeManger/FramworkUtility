using System;
using System.ComponentModel;
using System.Reflection;

namespace BG.Framework.Utility
{
    /// <summary>
    /// 枚举帮助类
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 尝试根据字符串转换枚举类型，默认忽略大小写
        /// </summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="value">字符串值</param>
        /// <param name="result">结果</param>
        /// <returns>转换成功返回true</returns>
        public static bool TryParse<TEnum>(string value, out TEnum result)
        {
            return TryParse<TEnum>(value, true, out result);
        }

        /// <summary>
        /// 尝试根据字符串转换枚举类型
        /// </summary>
        /// <typeparam name="TEnum">枚举类型</typeparam>
        /// <param name="value">字符串值</param>
        /// <param name="ignoreCase">是否忽略大小写</param>
        /// <param name="result">结果</param>
        /// <returns>转换成功返回true</returns>
        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result)
        {
            bool flag;

            try
            {
                result = (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
                flag = true;
            }
            catch
            {
                result = default(TEnum);
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// 扩展方法，获得枚举的Description
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <param name="nameInstead">当枚举值没有定义DescriptionAttribute，是否使用枚举名代替，默认是使用</param>
        /// <returns>枚举的Description</returns>
        public static string GetDescription(this Enum value, Boolean nameInstead = true)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return "";
            }
            FieldInfo field = type.GetField(name);
            object[] attr = field.GetCustomAttributes(nameInstead);
            if (attr.Length > 0)
                return (attr[0] as DescriptionAttribute).Description;
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Framework.Utility
{
    public class EntityHelper
    {
        /// <summary>
        ///实体拷贝,用","号分隔忽略属性
        /// </summary>
        /// <param name="source">源对象</param>
        /// <param name="target">目标对象</param>
        /// <param name="ignorePoperties"></param>
        /// <returns></returns>
        public static TTarget EntityCopy<TSource, TTarget>(TSource source, TTarget target, string ignorePoperties)
        {
            List<string> ignoreP = new List<string>();
            if (!string.IsNullOrEmpty(ignorePoperties))
            {
                ignoreP = ignorePoperties.ToLower().Split(',').ToList();
            }
            var tFields = target.GetType().GetProperties();
            var sFields = source.GetType().GetProperties();

            foreach (var item in tFields)
            {
                if (!ignoreP.Contains(item.Name.ToLower()))
                {
                    foreach (var si in sFields)
                    {
                        if (si.Name == item.Name)
                        {
                            object svalue = si.GetValue(source, null);
                            object tvalue = item.GetValue(target, null);
                            if (svalue != null && !svalue.Equals(tvalue))
                            {
                                item.SetValue(target, svalue, null);
                            }
                        }
                    }
                }
            }
            return target;
        }



        /// <summary>
        ///用","号分隔忽略属性
        /// </summary>
        /// <param name="source">源对象</param>
        /// <param name="target">目标对象</param>
        /// <returns></returns>
        public static TTarget EntityCopy<TSource, TTarget>(TSource source, TTarget target)
        {
            return EntityCopy(source, target, "");

        }

    }
}

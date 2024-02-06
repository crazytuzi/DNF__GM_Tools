using System;
using System.Collections.Generic;
using System.Linq;

namespace AY.DNF.GMTool.SuperTool
{
    /// <summary>
    /// 枚举扩展
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 枚举转键值对
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<KeyValuePair<string, int>> EnumToList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(t => KeyValuePair.Create<string, int>(t.ToString(), Convert.ToInt32(t)))
                .ToList();
        }
    }
}

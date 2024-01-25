using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AY.DNF.GMTool.SuperTool
{
    public static class EnumHelper
    {
        public static List<KeyValuePair<string,int>> EnumToList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(t => KeyValuePair.Create<string,int>(t.ToString(), Convert.ToInt32(t)))
                .ToList();
        }

        public static string GetDescription(this Enum e)
        {
            var type = e.GetType();
            var field = type.GetField(e.ToString());
            var obj = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute));
            return obj?.Description;            
        }
    }
}

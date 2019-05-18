using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    public delegate string StringFormatter(string str);
    public delegate List<string> ListFormatter(List<string> list);

    public static class ListFormatterExtension
    {
        public static List<string> CollectionFormmater(this List<string> list, ListFormatter lFormatter)
        {
            return lFormatter(list);
        }
        
        public static IEnumerable<string> Formatter(this IEnumerable<string> list, StringFormatter formatter)
        {
            List<string> temp = new List<string>();

            foreach (var item in list)
            {
                
                temp.Add(formatter(item));
            }
            return temp;
        }
    }

    public static class FormatterMethods
    {
        public static string ToUpperFormat(string str)
        {
            return str.ToUpper();
        }

        public static string ToUnderscoreFormat(string str)
        {
            return str.Replace(' ', '_');
        }

        public static List<string> ListElementsToUpper(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = ToUpperFormat(list[i]);
            }
            return list;
        }
        public static List<string> ListElementsToUnderescore(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = ToUnderscoreFormat(list[i]);
            }
            return list;
        }
    }
}

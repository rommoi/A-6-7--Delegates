using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    public class Practice
    {
        /// <summary>
        /// L7.P1. Переписать консольный калькулятор с использованием делегатов. 
        /// Используйте switch/case, чтоб определить какую математическую функцию.
        /// </summary>
        public static void L7P1_Calculator()
        {
            
        }

        /// <summary>
        /// L7.P2. Создать расширяющий метод для коллекции строк.
        /// Метод должен принимать делегат форматирующей функции для строки.
        /// Метод должен проходить по всем элементам коллекции и применять данную форматирующую функцию к каждому элементу.
        /// Реализовать следующие форматирующие функции:
        /// Перевод строки в заглавные буквы.
        /// Замена пробелов на подчеркивание.
        /// Продемонстрировать работу расширяющего метода.
        /// </summary>
        public static void L7P2_StringFormater()
        {

            StringFormatter sf = FormatterMethods.ToUpperFormat;

            string[] arr = new string[5]
            {
                "abcdefgh",
                "1123  dg dg sgs hsd sdfg sdhsdfh sd",
                "hKK:GTNLgudfHsd sdlksv l;sdFF",
                "a b c d e f g h i j k l m n o p q r s t u v w x y z",
                ""
            };

            Console.WriteLine("Source Array...");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("using formatter with ToUpperFormat");
            arr = ListFormatterExtension.Formatter(arr, sf).ToArray();
            Print(arr);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("using formatter with Replace");
            sf = FormatterMethods.ToUnderscoreFormat;
            arr = ListFormatterExtension.Formatter(arr, sf).ToArray();
            Print(arr);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            List<string> list = new List<string>
            {
                "abcdefgh",
                "1123  dg dg sgs hsd sdfg sdhsdfh sd",
                "hKK:GTNLgudfHsd sdlksv l;sdFF",
                "a b c d e f g h i j k l m n o p q r s t u v w x y z",
                ""
            };
            ListFormatter lf = FormatterMethods.ListElementsToUpper;

            Console.WriteLine("Source List...");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("using list formatter with ListElementsToUpper");
            list = ListFormatterExtension.CollectionFormmater(list, lf);
            Print(list);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("using list formatter with ListElementsToUnderescore");
            lf = FormatterMethods.ListElementsToUnderescore;
            list = ListFormatterExtension.CollectionFormmater(list, lf);
            Print(list);
            Console.WriteLine("--------------------------------------");


            Console.ReadLine();
        }

        public static void Print<T>(T collection) where T : IEnumerable<string>
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        

    }
}

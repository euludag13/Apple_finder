using System;

namespace Test
{
    class Program
    {
        public static String Apple_finder(string Apple_str){
            
            string apple = "elma";
            string Value = null;
            int counter = 0;

            string[] string_list = Apple_str.Split(" ");
            foreach (String word in string_list)
            {
                if (word == apple)
                {
                    counter ++;
                }
            }
            if (counter != 0)
            {
                Value = "Elma Bulundu";
            }
            else
            {
                Value = "Elma Bulunamadı";
            }
            
            return Value;
        }
        static void Main(string[] args)
        {
            var res_1 = Apple_finder("Bu ağaç bir elma ağacı");
            var res_2 = Apple_finder("Bu ağaç bir ElMa ağacı");
            var res_3 = Apple_finder("Bu ağaç bir armut ağacı");


            Console.WriteLine(res_1);
            Console.WriteLine(res_2);
            Console.WriteLine(res_3);
        }
        
    }
}

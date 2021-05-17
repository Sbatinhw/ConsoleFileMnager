using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileManager
{
    class ElementWork
    {
        public static void ElementThings(string start_dir, string comand, string element)
        {
            TestPrintCom(start_dir, comand, element);
        }

        public static void TestPrintCom(string start_dir, string comand, string element)
        {
            Console.Clear();
            Console.WriteLine($"\"{start_dir}\" \"{comand}\" \"{element}\"");
            Console.ReadLine();
        }


        //
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFileManager
{
    class DirList
    {

        public static void ListElement(string start_directory, bool print)
        {
            string[] element = CreateList(start_directory);
            if (print) { PrintList(element); }
        }

        public static string[] CreateList(string start_directory)
        {
            string[] dirs = Directory.GetDirectories(start_directory);
            string[] file = Directory.GetFiles(start_directory);
            int lenlist = dirs.Length + file.Length;
            string[] elem = new string[lenlist];
            for(int i = 0; i < elem.Length; i++)
            {
                if (i < dirs.Length)
                {
                    elem[i] = dirs[i];
                }
                else if (i >= dirs.Length)
                {
                    elem[i] = file[i - dirs.Length];
                }
            }
            return elem;
        }

        public static void PrintList(string[] list)
        {
            PrintLine.FullLine();
            for(int i = 0; i < list.Length; i++)
            {
                PrintLine.Print(list[i]);
            }
            PrintLine.FullLine();
            PrintLine.Print("TODO счетчик страниц");
            PrintLine.FullLine();
        }



        //
    }
}

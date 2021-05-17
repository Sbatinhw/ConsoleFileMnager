using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileManager
{
    class MainWindow
    {
        bool windowWF = true;
        bool startparse = false;
        //bool readstrWF = true;
        string work_directory = @"C:\Users\user\Desktop\test1";
        StringBuilder comand = new StringBuilder();
        string todo = "";
        string element = "";


        public void Window()
        {
            while (windowWF)
            {
                Console.Clear();

                DirList.ListElement(work_directory, true);
                ReadStr.ReadString(ref comand, ref windowWF, ref startparse);

                if (startparse)
                { 
                    startparse = false;
                    ParseComand.ParseLine(comand.ToString(), ref todo, ref element);
                    ElementWork.ElementThings(work_directory, todo, element);
                }
            }
            Console.Clear();
            Console.WriteLine("Работа завершена.");
        }

        

        //
    }
}

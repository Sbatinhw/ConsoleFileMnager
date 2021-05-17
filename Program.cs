using System;
using System.IO;
using System.Text;

namespace ConsoleFileManager
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MainWindow fm = new MainWindow();
            fm.Window();

            Console.ReadLine();

        }

        

        

        public static void PrintTestString(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                //Console.WriteLine($"{str[i]} {CheckSymb(str[i])}");
            }
        }

    }
}

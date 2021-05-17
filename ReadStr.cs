using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileManager
{
    class ReadStr
    {

        public static bool CheckSymb(char sym)
        {
            if
                (
                char.IsLetterOrDigit(sym) ||
                char.IsPunctuation(sym) ||
                char.IsSeparator(sym) ||
                char.IsSymbol(sym)
                ) { return true; }
            return false;
        }

        public static void RemoveLastSymb(ref StringBuilder comand)
        {
            try
            {
                comand.Remove(comand.Length - 1, 1);
            }
            catch
            {

            }
        }


        public static void ReadString(ref StringBuilder comand, ref bool windowWF, ref bool startparse)
        {
            
            ConsoleKeyInfo key;

            //while (readstrWF)
            {
                PrintLine.FullLine();
                PrintLine.Print("Введите команду:");
                PrintLine.Print(comand.ToString());
                PrintLine.FullLine();

                //PrintTestString(comand.ToString());

                key = Console.ReadKey();
                if (CheckSymb(key.KeyChar)) { comand.Append(key.KeyChar.ToString()); }
                else
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape: windowWF = false; break;
                        case ConsoleKey.Enter: startparse = true; break;
                        case ConsoleKey.Backspace: RemoveLastSymb(ref comand);  break;
                    }
                }
            }

        }

        //
    }
}

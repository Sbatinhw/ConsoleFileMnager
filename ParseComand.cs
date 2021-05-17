using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileManager
{
    class ParseComand
    {
        public static void ParseLine(string line, ref string comand, ref string element)
        {
            if(line.Length == 0) { return; }
            StringBuilder parsecomand = new StringBuilder();
            StringBuilder todo = new StringBuilder(line);

            while(todo[0] == ' ') { todo.Remove(0, 1); }
            while(todo[0] != ' ') { parsecomand.Append(todo[0]); todo.Remove(0, 1); }
            while (todo[0] == ' ') { todo.Remove(0, 1); }

            comand = parsecomand.ToString();
            element = todo.ToString();

        }

        //
    }
}

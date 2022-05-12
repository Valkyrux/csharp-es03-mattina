using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessage
    {
        public static void appendMessage(string text)
        {
            if(text.Length > 10)
            {
                Console.WriteLine(text.Substring(0,10));
                appendMessage(text.Substring(10));
            } else
            {
                Console.WriteLine(text);
            }
        }
    }
}

using System;

namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.appendMessage("ciao come stai povero gabbiano che ha perduto la compagna");

            Console.WriteLine("\nBorsellino\n");

            int valore;
            Borsellino myBorsellino = new Borsellino();
            while (int.TryParse(Console.ReadLine(), out valore))
            {
                myBorsellino.Add(valore);
            }
        }
    }
}

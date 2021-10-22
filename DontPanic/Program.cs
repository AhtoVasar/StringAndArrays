using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm asendab kõik 'o' tähed "Don`t panic" 0-iga
            //programm asendab kõik 'a' t'hed samas lauses 4-ga

            string Dpanic = "Don`t Panic";

            Dpanic = Dpanic.Replace('o', '0');
            Dpanic = Dpanic.Replace('a', '4');
            Console.WriteLine(Dpanic);

        }
    }
}

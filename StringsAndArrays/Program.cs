using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            String firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesniomes on {firstNameLength} sümbolit");
        }
    }
}

using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("sisesta eesnimi:");
            string firstname = Console.ReadLine();

            for(int i = firstname.Length - 1; i >= 0; i--)
            {
                Console.Write(firstname[i]);
            }
        }
    }
}

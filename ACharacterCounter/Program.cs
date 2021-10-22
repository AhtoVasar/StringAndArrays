using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonna nime
            //programm kuvab mittu a tähte kasutaja ees - ja perekonna nimes on


            Console.WriteLine("Sisesta eesnimi:");
            String firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            String lastName = Console.ReadLine();

            String fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte");
            }
            else 
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte");
            }
        }
    }
}

using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees ja perekonna nime
            //programm kontrollib andete pikkust
            //programm kuvab kumb nendest on pikkem

            
                
                Console.WriteLine("Sisesta eesnimi:");
                String firstName = Console.ReadLine();
                Console.WriteLine("Sisesta Perenimi:");
                String lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit");

            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu perenimes on {lastNameLength} sümbolit");

            if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikkem kui perenimi");

            }
            else if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu perenimi on pikkem kui eesnimi");
            }
            else 
            {
                    Console.WriteLine("Sinu ees- ja perenimi on sama pikkad");
            }
            
        }
    }
}

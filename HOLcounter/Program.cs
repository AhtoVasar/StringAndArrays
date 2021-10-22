using System;

namespace HOLcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mittu 'h'. 'o' ja 'l' tähte on lauses "Hello World" 

            
            String count = "Hello World!".ToLower();

            String countlow = $"{count}".ToLower();
            Console.WriteLine(countlow);

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < countlow.Length; i++)
            {
                if (countlow[i] == 'h')
                 
                {
                    hCounter++;
                    
                }
                if (countlow[i] == 'o')

                {
                    
                    oCounter++;
                    

                }
                if (countlow[i] == 'l')

                {
                    
                    lCounter++;

                }
            }
            if (hCounter != 1)
                {
                Console.WriteLine($"Sinu täisnimes on {hCounter} 'h' tähte");
                Console.WriteLine($"Sinu täisnimes on {oCounter} 'o' tähte");
                Console.WriteLine($"Sinu täisnimes on {lCounter} 'l' tähte");


            }
                else
                {
                Console.WriteLine($"Sinu täisnimes on {hCounter} 'h' tähte");
                Console.WriteLine($"Sinu täisnimes on {oCounter} 'o' tähte");
                Console.WriteLine($"Sinu täisnimes on {lCounter} 'l' tähte");


            }


            
        }
    }
}

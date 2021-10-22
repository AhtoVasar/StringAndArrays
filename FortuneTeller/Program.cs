using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme(kasutame random klassi)

            String[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookis" };
            Random rnd = new Random();
            int userNumber= rnd.Next(0, predictions.Length);

            Console.WriteLine($"Today you will {predictions[userNumber]}");
        }
    }
}

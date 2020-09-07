using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis te nimi on?");
            string name = Console.ReadLine();
            Console.WriteLine("Tere " + name);
            Console.WriteLine("Mis aastal sa sündisid?");
            string userInput = Console.ReadLine();
            int dateOfBirthInt;
            dateOfBirthInt = Int32.Parse(userInput);
            int dobCalculated = 2020 - dateOfBirthInt;
            Console.WriteLine("Sa oled " + dobCalculated + " aastat vana");
                
              
        }
    }
}

using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            Console.WriteLine("Tere! Mis su nimi on?");
            firstName = Console.ReadLine();
            Console.WriteLine("Tere " + firstName + "!");

            Console.WriteLine("Mis aastal sa sündisid?");
            int yob;
            int h;
            int w;

            yob = int.Parse(Console.ReadLine());

            if (yob < 1959)
            {

                Console.WriteLine("ERROR oled liiga vana :D");

            }
            else
            {
                // Keha andmete kogumine
                int age = 2019 - yob;
                Console.WriteLine("Sa oled " + age + " aastat vana");

                Console.WriteLine("Kui pikk sa oled?");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("Kui palju sa kaalud?");
                w = int.Parse(Console.ReadLine());

                // BMI arvutus
                double BMI = w / (h * h) ;
                
                

                Console.WriteLine($"Sinu kehamassiindeks on {Math.Round(BMI, 5)}  ");

                Console.ReadLine();
            }
        }
    }
}

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
            double h;
            double w;

            yob = int.Parse(Console.ReadLine());

            if (yob < 1959)
            {

                Console.WriteLine("Programm annab õigeid tulemusi vanusevahemikus 20-60. Teie puhul ei oleks tulemus õige.");

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
               
                double BMI = w / ((h * h) / 10000) ;
                
                

                Console.WriteLine($"Sinu kehamassiindeks on " + BMI );

                if (BMI < 16)
                {
                    Console.WriteLine("Te olete tervisele ohtlikus alakaalus.");
                }


                else if (BMI >= 16 && BMI <= 18.5)
                {
                    Console.WriteLine("Te olete alakaalus.");
                }

                else if (BMI >= 18.6 && BMI <= 25)
                {
                    Console.WriteLine("Te olete Normaalkaalus.");
                }

                else if (BMI >= 25.1 && BMI <= 30)
                {
                    Console.WriteLine("Te olete ülekaalus.");
                }

                else if (BMI >= 30.1 && BMI <= 35)
                {
                    Console.WriteLine("Te olete rasvunud.");
                }

                else if (BMI >= 35.1 && BMI <= 40)
                {
                    Console.WriteLine("Te olete tugevalt rasvunud.");
                }

                else
                {
                    Console.WriteLine("Te olete tervisele ohtlikult rasvunud.");
                }

                
            }
                Console.ReadLine();
        }
        
    }
}

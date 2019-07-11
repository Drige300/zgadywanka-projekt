using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

            Random rnd = new Random();
            int losowa = rnd.Next(1, 101);
            Console.WriteLine("Zbiór liczb wynosi 0-100.\nOdgadnij ją");
            Console.WriteLine("");

            //Console.WriteLine(wylosowana);

            bool trafiono = false;
            do
            {
                Console.Write("Podaj swoją propozycję: ");
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                {
                    break;
                }

                int wybor = 0;

                try
                {
                    wybor = Convert.ToInt32(tekst);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby!");

                    Console.WriteLine("");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba z poza zakresu!");
                    Console.WriteLine("");
                    continue;
                }

                Console.WriteLine($"Twoja propozycja: {wybor}");

                if (wybor < losowa)
                {
                    Console.WriteLine("Za mało!");
                    Console.WriteLine("");
                }
                else if (wybor > losowa)
                {
                    Console.WriteLine("Za dużo!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Trafiono!");
                    Console.WriteLine("");
                    trafiono = true;
                }
            }
            while (!trafiono);

            Console.WriteLine("Odgadłeś/aś! Brawo Ty!");

            Console.ReadKey();
=======
            return false;
                   
>>>>>>> parent of 1a0facb... finalny projekt
        }
    }
}

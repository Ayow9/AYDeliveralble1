using System;

namespace Alex_Y_Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { Console.WriteLine("Welcome to the restocking tool!"); }

            Console.WriteLine("How many sodas sold today? 100 currently in stock");

            int numbersoda = 100;
            int invsoda = int.Parse(Console.ReadLine());
            int rsoda = (numbersoda - invsoda);

            if (invsoda > 100)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                Console.WriteLine(rsoda + " sodas are left over");
            }

            Console.WriteLine("How many chips sold today? 40 currently in stock");

            int numberchips = 40;
            int invchips = int.Parse(Console.ReadLine());
            int rchips = (numberchips - invchips);

            if (invchips > 40)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                Console.WriteLine(rchips + " chips are left over");
            }
            Console.WriteLine("How many candy sold today? 60 currently in stock");

            int numbercandy = 60;
            int invcandy = int.Parse(Console.ReadLine());
            int rcandy = (numbercandy - invcandy);

            if (invcandy > 60)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                Console.WriteLine(rcandy + " candy are left over");
            }
            Console.WriteLine("Thank you for using the restock tool. Here's what needs to be restocked");
            { if (rsoda <= 40)
                    Console.WriteLine("Soda needs to be restocked");
            }
            {
                if (rchips <= 20)
                    Console.WriteLine("Chips needs to be restocked");
            }
            {
                if (rcandy <= 40)
                    Console.WriteLine("Candy needs to be restocked");
            }
        }

    }
}

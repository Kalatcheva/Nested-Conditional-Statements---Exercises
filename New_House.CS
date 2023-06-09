using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace newHouse

{
    internal class Program
    {
        static void Main(string[] args)
        {

            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flower.ToLower())
            {

                case "roses":
                    price = flowerCount * 5;
                    if(flowerCount > 80)
                    {
                        price = price * 0.9;
                    }
                    break;

                case "dahlias":
                    price = flowerCount * 3.8;
                    if(flowerCount > 90)
                    {
                        price = price * 0.85;
                    }
                    break;

                case "tulips":
                    price = flowerCount * 2.8;
                    if (flowerCount > 80)
                    {
                        price = price * 0.85;
                    }
                    break;

                case "narcissus":
                    price = flowerCount * 3;
                    if (flowerCount < 120)
                    {
                        price = price * 1.15;
                    }
                    break;

                case "gladiolus":
                    price = flowerCount * 2.5;
                    if (flowerCount < 80)
                    {
                        price = price * 1.2;
                    }
                    break;
            }

            if(budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = price - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }

        }
    }
    }

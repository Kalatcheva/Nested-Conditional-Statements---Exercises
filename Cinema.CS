using System;
using System.IO;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string projectionType = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            switch (projectionType)
            {
                case "Premiere":
                    totalIncome = (numberOfColumns * numberOfRows) * 12.00;
                    break;
                case "Normal":
                    totalIncome = (numberOfColumns * numberOfRows) * 7.50;
                    break;
                case "Discount":
                    totalIncome = (numberOfColumns * numberOfRows) * 5.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalIncome:f2}");
        }
    }
    }

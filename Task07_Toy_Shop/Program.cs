using System;

namespace Task07_Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dols = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double turnover = puzzle * 2.60 + dols * 3 + bears * 4.10 + minions * 8.2 + trucks * 2;
            int toysCount = puzzle + dols + bears + minions + trucks;
            if (toysCount >= 50)
            {
                double profit = (turnover - (turnover * 0.25));
                double rent = profit * 0.1;
                double finalProfit = profit - rent;
                if (finalProfit >= price)
                {
                    double sum = finalProfit - price;
                    sum = Math.Round(sum, 2);
                    Console.WriteLine($"Yes! {sum:F2} lv left.");
                }
                else
                {
                    double sum = price - finalProfit;
                    sum = Math.Round(sum, 2);
                    Console.WriteLine($"Not enough money! {sum:F2} lv needed.");
                }
            }
            else
            {
                double rent = turnover * 0.1;
                double finalProfit = turnover - rent;
                if (finalProfit >= price)
                {
                    double sum = finalProfit - price;
                    sum = Math.Round(sum, 2);
                    Console.WriteLine($"Yes! {sum:F2} lv left.");
                }
                else
                {
                    double sum = price - finalProfit;
                    sum = Math.Round(sum, 2);
                    Console.WriteLine($"Not enough money! {sum:F2} lv needed.");
                }
            }
            
        }
    }
}

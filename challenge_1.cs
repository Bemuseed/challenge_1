using System;

namespace challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ranks = { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" };
            string[] houses = { "clubs", "spades", "hearts", "diamonds" };
            Console.WriteLine("Generating random card...");
            Random random = new Random();
            string rank = ranks[random.Next(0, 12)];
            string house = houses[random.Next(0, 3)];
            rank = char.ToUpper(rank[0]) + rank.Substring(1);
            house = char.ToUpper(house[0]) + house.Substring(1);
            Console.WriteLine("Your card is the {0} of {1}!", rank, house);
            Console.ReadLine();
            

        }
    }
}

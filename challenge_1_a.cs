using System;

namespace challenge_1
{
    class CardDealer
    {
        static string[] ranks = { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" };
        static string[] houses = { "clubs", "spades", "hearts", "diamonds" };
        static Random random = new Random();

        // Returns the given string with the first character capitalized
        static string Capitalize(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        // Returns a random integer index for a string in ranks
        static int RanRankNum()
        {
            return random.Next(0, 13);
        }

        // Returns a random integer index for a string in houses
        static int RanHouseNum()
        {
            return random.Next(0, 4);
        }

        // Returns a string describing a random card
        public string GiveCard()
        {
            string rank = Capitalize(ranks[RanRankNum()]);
            string house = Capitalize(houses[RanHouseNum()]);
            return rank + " of " + house;

        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            CardDealer dealer = new CardDealer();
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Deal a card? (n or x to exit)");
                string inp = Console.ReadLine();
                inp = inp.ToLower();
                if(inp != "n" & inp != "x")
                {
                    Console.WriteLine("It's the {0}!", dealer.GiveCard());
                }
                else
                {
                    Console.WriteLine("So long!");
                    repeat = false;
                }
            }
        }
    }
}

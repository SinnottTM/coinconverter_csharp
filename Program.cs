using System;

namespace CoinConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
            You have three types of coins:
            A bronze coin is worth 1 cent.
            A silver coin is worth 5 cents.
            A gold coin is worth 10 cents

            This program will take in a value in cents and return a calculation of how many bronze, silver or gold coins are needed.

            There is also scope within this to allow users to set the value of coins for themselves if needed (bronze calculation would need to be reworked slightly)

            */

            Console.WriteLine("Welcome to Coin Converter!");
            Console.WriteLine("Gold Coins are currently worth 10 cents");
            Console.WriteLine("Silver Coins are currently worth 5 cents");
            Console.WriteLine("Bronze Coins are currently worth 1 cent");


            Console.WriteLine("Please give amount (in cents) to be converted to bronze, silver and/or gold goins: ");
            string amountAsString = Console.ReadLine();

            double amountAsDouble = Convert.ToDouble(amountAsString);

            Console.WriteLine($"{amountAsString} is equal to...");

            int goldCoinValue = 10;
            int silverCoinValue = 5;
            int bronzeCoinValue = 1;

            // How many gold coins in the amount given
            double goldCoins = Math.Floor(amountAsDouble / goldCoinValue);

            // What is left over from this gold coin division
            double goldCoinsRemainder = amountAsDouble % goldCoinValue;

            // How many silver coins in the amount remaining after gold coins calculated

            double silverCoins = Math.Floor(goldCoinsRemainder / silverCoinValue);

            // What is left over from this silver coin division
            double silverCoinsRemainder = goldCoinsRemainder % silverCoinValue;

            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {silverCoinsRemainder}");


        }
    }
}

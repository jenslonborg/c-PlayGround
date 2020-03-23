using System;
using System.Collections.Generic;
using System.Text;

namespace RegisteryApplication
{
    class Registery
    {
        // member variables
        int[] coins = new int[] { 25, 10, 1 };
        

        public void StartRegistery()
        {
        }
        public void AvailableCoins()
        {
            foreach (int coin in coins)
            {
                Console.WriteLine(coin);
            }
        }
        public int GreedyReturn(int payAmount)
        {
            int NumberOfCoins = 0;
            foreach (int coin in coins)
            {
                NumberOfCoins = NumberOfCoins + payAmount / coin;
                payAmount = payAmount % coin;
            }
            return NumberOfCoins;
        }

        public int GreedyReturn(int payAmount, int[] reducedCoins)
        {
            int NumberOfCoins = 0;
            foreach (int coin in reducedCoins)
            {
                NumberOfCoins = NumberOfCoins + payAmount / coin;
                payAmount = payAmount % coin;
            }
            return NumberOfCoins;
        }
        public int MinReturn(int payAmount)
        {
            int payAmountReset     = payAmount;
            int BruteForce         = 0;
            int NumberOfCoinsCheck = 0;
            BruteForce = GreedyReturn(payAmount);
            Console.WriteLine("BruteForce: {0}", BruteForce);

            payAmountReset = payAmount;
            NumberOfCoinsCheck = NumberOfCoinsCheck + payAmountReset / 25 -1;
            payAmountReset = payAmountReset % 25 + 25;
            int[] reducedCoins = new int[] { 10, 1 };
            NumberOfCoinsCheck = NumberOfCoinsCheck + GreedyReturn(payAmountReset, reducedCoins);
            Console.WriteLine("NumberOfCoinsCheck: {0}, payAmountReset: {1}", NumberOfCoinsCheck, payAmountReset);
            if (BruteForce <= NumberOfCoinsCheck)
            {
                return BruteForce;
            }
            else
            {
                return NumberOfCoinsCheck;
            }
        }
    }
}

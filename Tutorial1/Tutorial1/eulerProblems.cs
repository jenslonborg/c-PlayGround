using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace eulerProblmsApplication
{
    class eulerProblms
    {


        public int GiveMeNthPrime(int input)
        {
            if (input < 1)
            {
                Console.WriteLine("Please input integer above 1");
                return 0;
            }
            int primeCounter = 1;
            int primeRunner = 1;
            int[] primeArray = new int[input];
            bool IsAPrime;
            for (int runs = 0; runs < primeArray.Length; runs++)
            {
                primeArray[runs] = 2;
            }
            while (primeCounter < input)
            {
                primeRunner++;
                IsAPrime = true;
                for (int primeIndex = 0; primeIndex < primeCounter; primeIndex++)
                {
                    if (primeRunner % primeArray[primeIndex] == 0)
                    {
                        IsAPrime = false;
                        break;
                    }
                }
                if (IsAPrime)
                {
                    primeArray[primeCounter] = primeRunner;
                    primeCounter++;
                }
            }
            return primeRunner;
        }

        public void problem8()
        {
            long numOfDigets = 13;
            long maxProduct = 0;
            long maxProductInt = 0;
            long product = 1;
            long[] LargeNumber = new long[] {7, 3,1, 6,7, 1,7, 6,5, 3,1, 3,3, 0,6, 2,4, 9,1, 9,2, 2,5, 1,1, 9,6, 7,4, 4,2, 6,5, 7,4, 7,4, 2,3, 5,5, 3,4, 9,1, 9,4, 9,3, 4,
9, 6,9, 8,3, 5,2, 0,3, 1,2, 7,7, 4,5, 0,6, 3,2, 6,2, 3,9, 5,7, 8,3, 1,8, 0,1, 6,9, 8,4, 8,0, 1,8, 6,9, 4,7, 8,8, 5,1, 8,4, 3,
8, 5,8, 6,1, 5,6, 0,7, 8,9, 1,1, 2,9, 4,9, 4,9, 5,4, 5,9, 5,0, 1,7, 3,7, 9,5, 8,3, 3,1, 9,5, 2,8, 5,3, 2,0, 8,8, 0,5, 5,1, 1,
1, 2,5, 4,0, 6,9, 8,7, 4,7, 1,5, 8,5, 2,3, 8,6, 3,0, 5,0, 7,1, 5,6, 9,3, 2,9, 0,9, 6,3, 2,9, 5,2, 2,7, 4,4, 3,0, 4,3, 5,5, 7,
6, 6,8, 9,6, 6,4, 8,9, 5,0, 4,4, 5,2, 4,4, 5,2, 3,1, 6,1, 7,3, 1,8, 5,6, 4,0, 3,0, 9,8, 7,1, 1,1, 2,1, 7,2, 2,3, 8,3, 1,1, 3,
6, 2,2, 2,9, 8,9, 3,4, 2,3, 3,8, 0,3, 0,8, 1,3, 5,3, 3,6, 2,7, 6,6, 1,4, 2,8, 2,8, 0,6, 4,4, 4,4, 8,6, 6,4, 5,2, 3,8, 7,4, 9,
3, 0,3, 5,8, 9,0, 7,2, 9,6, 2,9, 0,4, 9,1, 5,6, 0,4, 4,0, 7,7, 2,3, 9,0, 7,1, 3,8, 1,0, 5,1, 5,8, 5,9, 3,0, 7,9, 6,0, 8,6, 6,
7, 0,1, 7,2, 4,2, 7,1, 2,1, 8,8, 3,9, 9,8, 7,9, 7,9, 0,8, 7,9, 2,2, 7,4, 9,2, 1,9, 0,1, 6,9, 9,7, 2,0, 8,8, 8,0, 9,3, 7,7, 6,
6, 5,7, 2,7, 3,3, 3,0, 0,1, 0,5, 3,3, 6,7, 8,8, 1,2, 2,0, 2,3, 5,4, 2,1, 8,0, 9,7, 5,1, 2,5, 4,5, 4,0, 5,9, 4,7, 5,2, 2,4, 3,
5, 2,5, 8,4, 9,0, 7,7, 1,1, 6,7, 0,5, 5,6, 0,1, 3,6, 0,4, 8,3, 9,5, 8,6, 4,4, 6,7, 0,6, 3,2, 4,4, 1,5, 7,2, 2,1, 5,5, 3,9, 7,
5, 3,6, 9,7, 8,1, 7,9, 7,7, 8,4, 6,1, 7,4, 0,6, 4,9, 5,5, 1,4, 9,2, 9,0, 8,6, 2,5, 6,9, 3,2, 1,9, 7,8, 4,6, 8,6, 2,2, 4,8, 2,
8, 3,9, 7,2, 2,4, 1,3, 7,5, 6,5, 7,0, 5,6, 0,5, 7,4, 9,0, 2,6, 1,4, 0,7, 9,7, 2,9, 6,8, 6,5, 2,4, 1,4, 5,3, 5,1, 0,0, 4,7, 4,
8, 2,1, 6,6, 3,7, 0,4, 8,4, 4,0, 3,1, 9,9, 8,9, 0,0, 0,8, 8,9, 5,2, 4,3, 4,5, 0,6, 5,8, 5,4, 1,2, 2,7, 5,8, 8,6, 6,6, 8,8, 1,
1, 6,4, 2,7, 1,7, 1,4, 7,9, 9,2, 4,4, 4,2, 9,2, 8,2, 3,0, 8,6, 3,4, 6,5, 6,7, 4,8, 1,3, 9,1, 9,1, 2,3, 1,6, 2,8, 2,4, 5,8, 6,
1, 7,8, 6,6, 4,5, 8,3, 5,9, 1,2, 4,5, 6,6, 5,2, 9,4, 7,6, 5,4, 5,6, 8,2, 8,4, 8,9, 1,2, 8,8, 3,1, 4,2, 6,0, 7,6, 9,0, 0,4, 2,
2, 4,2, 1,9, 0,2, 2,6, 7,1, 0,5, 5,6, 2,6, 3,2, 1,1, 1,1, 1,0, 9,3, 7,0, 5,4, 4,2, 1,7, 5,0, 6,9, 4,1, 6,5, 8,9, 6,0, 4,0, 8,
0, 7,1, 9,8, 4,0, 3,8, 5,0, 9,6, 2,4, 5,5, 4,4, 4,3, 6,2, 9,8, 1,2, 3,0, 9,8, 7,8, 7,9, 9,2, 7,2, 4,4, 2,8, 4,9, 0,9, 1,8, 8,
8, 4,5, 8,0, 1,5, 6,1, 6,6, 0,9, 7,9, 1,9, 1,3, 3,8, 7,5, 4,9, 9,2, 0,0, 5,2, 4,0, 6,3, 6,8, 9,9, 1,2, 5,6, 0,7, 1,7, 6,0, 6,
0, 5,8, 8,6, 1,1, 6,4, 6,7, 1,0, 9,4, 0,5, 0,7, 7,5, 4,1, 0,0, 2,2, 5,6, 9,8, 3,1, 5,5, 2,0, 0,0, 5,5, 9,3, 5,7, 2,9, 7,2, 5,
7, 1,6, 3,6, 2,6, 9,5, 6,1, 8,8, 2,6, 7,0, 4,2, 8,2, 5,2, 4,8, 3,6, 0,0, 8,2, 3,2, 5,7, 5,3, 0,4, 2,0, 7,5, 2,9, 6,3, 4,5,0};
            long runner = 0;
            Console.WriteLine(LargeNumber.Length);
            while (runner < 987)
            {
                if (LargeNumber[runner + numOfDigets - 1] == 0)
                {
                    runner = runner + numOfDigets;
                    continue;
                }
                product = 1;
                for (long digetRunner = runner; digetRunner < (runner + numOfDigets); digetRunner++)
                {
                    product *= LargeNumber[digetRunner];
                }
                if (product > maxProduct)
                {
                    maxProduct = product;
                    maxProductInt = runner;
                    Console.WriteLine("maxProduct: {0}. maxProductInt {1}. runnerValue {2}.{3}.{4}.{5}", maxProduct, maxProductInt, LargeNumber[runner], LargeNumber[runner+1], LargeNumber[runner+2], LargeNumber[runner+3]);
                }
                runner++;
            }
            Console.WriteLine(runner);
            //Console.WriteLine("maxProduct: {0}: maxProductInt {1}", maxProduct, maxProductInt);
        }

        public void problem9()
        {
            double a = 1;
            double b = 1;
            double c = 1;
            bool foundIt = false;
            while (((a + b) < 100) && (foundIt == false))
            {
                while (((a + b) < 100) && (foundIt == false))
                {
                    c = Math.Sqrt(a * a + b * b);
                    if(c == Math.Round(c))
                    {
                        Console.WriteLine(a + b + c);
                        if ((a+b+c) == 100)
                        {
                            foundIt = true;
                            Console.WriteLine("a = {0}, b = {1}, c = {2}, product = {3}", a, b, c, a * b * c);
                        }
                    }
                    b = b + 1;
                }
                a = a + 1;
                b = a;
            }

        }

        public void problem10()
        {
            long primeRunner = 3;
            List<long> primeList = new List<long>();
            long primeSum = 2;
            bool isPrime;
            primeList.Add(2);
            while (primeRunner < 2000) {
                if (primeRunner % 200 == 0)
                {
                    Console.WriteLine(primeRunner);
                }
                isPrime = true;
                foreach(long prime in primeList)
                {
                    if(primeRunner % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(primeRunner);
                    primeSum = primeSum + primeRunner;
                }
                primeRunner++;
            }
            Console.WriteLine(primeSum);
        }

        public void problem11()
        {
            int[,] matrix = new int[,] 
            {{8,2,22,97,38,15,0,40,0,75,4,5,7,78,52,12,50,77,91,8},
            {49,49,99,40,17,81,18,57,60,87,17,40,98,43,69,48,4,56,62,0},
            {81,49,31,73,55,79,14,29,93,71,40,67,53,88,30,3,49,13,36,65},
            {52,70,95,23,4,60,11,42,69,24,68,56,1,32,56,71,37,2,36,91},
            {22,31,16,71,51,67,63,89,41,92,36,54,22,40,40,28,66,33,13,80},
            {24,47,32,60,99,3,45,2,44,75,33,53,78,36,84,20,35,17,12,50},
            {32,98,81,28,64,23,67,10,26,38,40,67,59,54,70,66,18,38,64,70},
            {67,26,20,68,2,62,12,20,95,63,94,39,63,8,40,91,66,49,94,21},
            {24,55,58,5,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72},
            {21,36,23,9,75,0,76,44,20,45,35,14,0,61,33,97,34,31,33,95},
            {78,17,53,28,22,75,31,67,15,94,3,80,4,62,16,14,9,53,56,92},
            {16,39,5,42,96,35,31,47,55,58,88,24,0,17,54,24,36,29,85,57},
            {86,56,0,48,35,71,89,7,5,44,44,37,44,60,21,58,51,54,17,58},
            {19,80,81,68,5,94,47,69,28,73,92,13,86,52,17,77,4,89,55,40},
            {4,52,8,83,97,35,99,16,7,97,57,32,16,26,26,79,33,27,98,66},
            {88,36,68,87,57,62,20,72,3,46,33,67,46,55,12,32,63,93,53,69},
            {4,42,16,73,38,25,39,11,24,94,72,18,8,46,29,32,40,62,76,36},
            {20,69,36,41,72,30,23,88,34,62,99,69,82,67,59,85,74,4,36,16},
            {20,73,35,29,78,31,90,1,74,31,49,71,48,86,81,16,23,57,5,54},
            {1,70,54,71,83,51,54,69,16,92,33,48,61,43,52,1,89,19,67,48}};

            int down = 0;
            int right = 0;
            int diagonalright = 0;
            int diagonalleft = 0;
            int maxProduct = 0;
            string maxDirection = "None";
            int maxPos1 = 0;
            int maxPos2 = 0;
            for (int i = 0; i <= 19; i++)
            {
                for (int j = 0; j <= 19; j++)
                {
                    if (i <= 16)
                    {
                        down = matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j];
                    }
                    if (j <= 16)
                    {
                        right = matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3];
                    }
                    if (i <= 16 && j <= 16) {
                        diagonalright = matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3];
                    }
                    if (i <= 16 && j >= 3)
                    {
                        diagonalleft = matrix[i, j] * matrix[i + 1, j - 1] * matrix[i + 2, j - 2] * matrix[i + 3, j - 3];
                    }
                    if (down > maxProduct)
                    {
                        maxProduct = down;
                        maxDirection = "down";
                        maxPos1 = i;
                        maxPos2 = j;
                        Console.WriteLine("{0}",maxProduct);
                    }
                    if (right > maxProduct)
                    {
                        maxProduct = right;
                        maxDirection = "right";
                        maxPos1 = i;
                        maxPos2 = j;
                        Console.WriteLine("{0}", maxProduct);
                    }
                    if (diagonalright > maxProduct)
                    {
                        maxProduct = diagonalright;
                        maxDirection = "diagonalright";
                        maxPos1 = i;
                        maxPos2 = j;
                        Console.WriteLine("{0}", maxProduct);
                    }
                    if (diagonalleft > maxProduct)
                    {
                        maxProduct = diagonalleft;
                        maxDirection = "diagonalleft";
                        maxPos1 = i;
                        maxPos2 = j;
                        Console.WriteLine("{0}", maxProduct);
                    }
                }
            }
            Console.WriteLine("{0}", maxProduct);
            Console.WriteLine(maxDirection);
            Console.WriteLine(maxPos1);
            Console.WriteLine(maxPos2);

        }

        public void problem12()
        {
            ulong triangle = 1;
            ulong triangleInt = 2;
            int maxDivisors = 0;
            int divisors = 0;
            while (maxDivisors <= 500)
            {
                if (triangle % 10000000 == 0)
                {
                    Console.WriteLine(triangle);
                }
                triangle += triangleInt;
                triangleInt++;
                divisors = 0;
                for (ulong runner = 1; runner <= Math.Sqrt(triangle); runner++)
                {
                    if (triangle % runner == 0) {
                        if (triangle / runner == runner)
                        {
                            divisors++;
                        }
                        else
                        {
                            divisors = divisors + 2;
                        }
                    }
                }
                if (divisors > maxDivisors)
                {
                    maxDivisors = divisors;
                    Console.WriteLine("{0} divisors, at number: {1}", maxDivisors, triangle);
                }
            }
        }

        public void problem13()
        {
            int[,] matrix = new int[,]
                {{3,7,1,0,7,2,8,7,5,3,3,9,0,2,1,0,2,7,9,8,7,9,7,9,9,8,2,2,0,8,3,7,5,9,0,2,4,6,5,1,0,1,3,5,7,4,0,2,5,0},
{4,6,3,7,6,9,3,7,6,7,7,4,9,0,0,0,9,7,1,2,6,4,8,1,2,4,8,9,6,9,7,0,0,7,8,0,5,0,4,1,7,0,1,8,2,6,0,5,3,8},
{7,4,3,2,4,9,8,6,1,9,9,5,2,4,7,4,1,0,5,9,4,7,4,2,3,3,3,0,9,5,1,3,0,5,8,1,2,3,7,2,6,6,1,7,3,0,9,6,2,9},
{9,1,9,4,2,2,1,3,3,6,3,5,7,4,1,6,1,5,7,2,5,2,2,4,3,0,5,6,3,3,0,1,8,1,1,0,7,2,4,0,6,1,5,4,9,0,8,2,5,0},
{2,3,0,6,7,5,8,8,2,0,7,5,3,9,3,4,6,1,7,1,1,7,1,9,8,0,3,1,0,4,2,1,0,4,7,5,1,3,7,7,8,0,6,3,2,4,6,6,7,6},
{8,9,2,6,1,6,7,0,6,9,6,6,2,3,6,3,3,8,2,0,1,3,6,3,7,8,4,1,8,3,8,3,6,8,4,1,7,8,7,3,4,3,6,1,7,2,6,7,5,7},
{2,8,1,1,2,8,7,9,8,1,2,8,4,9,9,7,9,4,0,8,0,6,5,4,8,1,9,3,1,5,9,2,6,2,1,6,9,1,2,7,5,8,8,9,8,3,2,7,3,8},
{4,4,2,7,4,2,2,8,9,1,7,4,3,2,5,2,0,3,2,1,9,2,3,5,8,9,4,2,2,8,7,6,7,9,6,4,8,7,6,7,0,2,7,2,1,8,9,3,1,8},
{4,7,4,5,1,4,4,5,7,3,6,0,0,1,3,0,6,4,3,9,0,9,1,1,6,7,2,1,6,8,5,6,8,4,4,5,8,8,7,1,1,6,0,3,1,5,3,2,7,6},
{7,0,3,8,6,4,8,6,1,0,5,8,4,3,0,2,5,4,3,9,9,3,9,6,1,9,8,2,8,9,1,7,5,9,3,6,6,5,6,8,6,7,5,7,9,3,4,9,5,1},
{6,2,1,7,6,4,5,7,1,4,1,8,5,6,5,6,0,6,2,9,5,0,2,1,5,7,2,2,3,1,9,6,5,8,6,7,5,5,0,7,9,3,2,4,1,9,3,3,3,1},
{6,4,9,0,6,3,5,2,4,6,2,7,4,1,9,0,4,9,2,9,1,0,1,4,3,2,4,4,5,8,1,3,8,2,2,6,6,3,3,4,7,9,4,4,7,5,8,1,7,8},
{9,2,5,7,5,8,6,7,7,1,8,3,3,7,2,1,7,6,6,1,9,6,3,7,5,1,5,9,0,5,7,9,2,3,9,7,2,8,2,4,5,5,9,8,8,3,8,4,0,7},
{5,8,2,0,3,5,6,5,3,2,5,3,5,9,3,9,9,0,0,8,4,0,2,6,3,3,5,6,8,9,4,8,8,3,0,1,8,9,4,5,8,6,2,8,2,2,7,8,2,8},
{8,0,1,8,1,1,9,9,3,8,4,8,2,6,2,8,2,0,1,4,2,7,8,1,9,4,1,3,9,9,4,0,5,6,7,5,8,7,1,5,1,1,7,0,0,9,4,3,9,0},
{3,5,3,9,8,6,6,4,3,7,2,8,2,7,1,1,2,6,5,3,8,2,9,9,8,7,2,4,0,7,8,4,4,7,3,0,5,3,1,9,0,1,0,4,2,9,3,5,8,6},
{8,6,5,1,5,5,0,6,0,0,6,2,9,5,8,6,4,8,6,1,5,3,2,0,7,5,2,7,3,3,7,1,9,5,9,1,9,1,4,2,0,5,1,7,2,5,5,8,2,9},
{7,1,6,9,3,8,8,8,7,0,7,7,1,5,4,6,6,4,9,9,1,1,5,5,9,3,4,8,7,6,0,3,5,3,2,9,2,1,7,1,4,9,7,0,0,5,6,9,3,8},
{5,4,3,7,0,0,7,0,5,7,6,8,2,6,6,8,4,6,2,4,6,2,1,4,9,5,6,5,0,0,7,6,4,7,1,7,8,7,2,9,4,4,3,8,3,7,7,6,0,4},
{5,3,2,8,2,6,5,4,1,0,8,7,5,6,8,2,8,4,4,3,1,9,1,1,9,0,6,3,4,6,9,4,0,3,7,8,5,5,2,1,7,7,7,9,2,9,5,1,4,5},
{3,6,1,2,3,2,7,2,5,2,5,0,0,0,2,9,6,0,7,1,0,7,5,0,8,2,5,6,3,8,1,5,6,5,6,7,1,0,8,8,5,2,5,8,3,5,0,7,2,1},
{4,5,8,7,6,5,7,6,1,7,2,4,1,0,9,7,6,4,4,7,3,3,9,1,1,0,6,0,7,2,1,8,2,6,5,2,3,6,8,7,7,2,2,3,6,3,6,0,4,5},
{1,7,4,2,3,7,0,6,9,0,5,8,5,1,8,6,0,6,6,0,4,4,8,2,0,7,6,2,1,2,0,9,8,1,3,2,8,7,8,6,0,7,3,3,9,6,9,4,1,2},
{8,1,1,4,2,6,6,0,4,1,8,0,8,6,8,3,0,6,1,9,3,2,8,4,6,0,8,1,1,1,9,1,0,6,1,5,5,6,9,4,0,5,1,2,6,8,9,6,9,2},
{5,1,9,3,4,3,2,5,4,5,1,7,2,8,3,8,8,6,4,1,9,1,8,0,4,7,0,4,9,2,9,3,2,1,5,0,5,8,6,4,2,5,6,3,0,4,9,4,8,3},
{6,2,4,6,7,2,2,1,6,4,8,4,3,5,0,7,6,2,0,1,7,2,7,9,1,8,0,3,9,9,4,4,6,9,3,0,0,4,7,3,2,9,5,6,3,4,0,6,9,1},
{1,5,7,3,2,4,4,4,3,8,6,9,0,8,1,2,5,7,9,4,5,1,4,0,8,9,0,5,7,7,0,6,2,2,9,4,2,9,1,9,7,1,0,7,9,2,8,2,0,9},
{5,5,0,3,7,6,8,7,5,2,5,6,7,8,7,7,3,0,9,1,8,6,2,5,4,0,7,4,4,9,6,9,8,4,4,5,0,8,3,3,0,3,9,3,6,8,2,1,2,6},
{1,8,3,3,6,3,8,4,8,2,5,3,3,0,1,5,4,6,8,6,1,9,6,1,2,4,3,4,8,7,6,7,6,8,1,2,9,7,5,3,4,3,7,5,9,4,6,5,1,5},
{8,0,3,8,6,2,8,7,5,9,2,8,7,8,4,9,0,2,0,1,5,2,1,6,8,5,5,5,4,8,2,8,7,1,7,2,0,1,2,1,9,2,5,7,7,6,6,9,5,4},
{7,8,1,8,2,8,3,3,7,5,7,9,9,3,1,0,3,6,1,4,7,4,0,3,5,6,8,5,6,4,4,9,0,9,5,5,2,7,0,9,7,8,6,4,7,9,7,5,8,1},
{1,6,7,2,6,3,2,0,1,0,0,4,3,6,8,9,7,8,4,2,5,5,3,5,3,9,9,2,0,9,3,1,8,3,7,4,4,1,4,9,7,8,0,6,8,6,0,9,8,4},
{4,8,4,0,3,0,9,8,1,2,9,0,7,7,7,9,1,7,9,9,0,8,8,2,1,8,7,9,5,3,2,7,3,6,4,4,7,5,6,7,5,5,9,0,8,4,8,0,3,0},
{8,7,0,8,6,9,8,7,5,5,1,3,9,2,7,1,1,8,5,4,5,1,7,0,7,8,5,4,4,1,6,1,8,5,2,4,2,4,3,2,0,6,9,3,1,5,0,3,3,2},
{5,9,9,5,9,4,0,6,8,9,5,7,5,6,5,3,6,7,8,2,1,0,7,0,7,4,9,2,6,9,6,6,5,3,7,6,7,6,3,2,6,2,3,5,4,4,7,2,1,0},
{6,9,7,9,3,9,5,0,6,7,9,6,5,2,6,9,4,7,4,2,5,9,7,7,0,9,7,3,9,1,6,6,6,9,3,7,6,3,0,4,2,6,3,3,9,8,7,0,8,5},
{4,1,0,5,2,6,8,4,7,0,8,2,9,9,0,8,5,2,1,1,3,9,9,4,2,7,3,6,5,7,3,4,1,1,6,1,8,2,7,6,0,3,1,5,0,0,1,2,7,1},
{6,5,3,7,8,6,0,7,3,6,1,5,0,1,0,8,0,8,5,7,0,0,9,1,4,9,9,3,9,5,1,2,5,5,7,0,2,8,1,9,8,7,4,6,0,0,4,3,7,5},
{3,5,8,2,9,0,3,5,3,1,7,4,3,4,7,1,7,3,2,6,9,3,2,1,2,3,5,7,8,1,5,4,9,8,2,6,2,9,7,4,2,5,5,2,7,3,7,3,0,7},
{9,4,9,5,3,7,5,9,7,6,5,1,0,5,3,0,5,9,4,6,9,6,6,0,6,7,6,8,3,1,5,6,5,7,4,3,7,7,1,6,7,4,0,1,8,7,5,2,7,5},
{8,8,9,0,2,8,0,2,5,7,1,7,3,3,2,2,9,6,1,9,1,7,6,6,6,8,7,1,3,8,1,9,9,3,1,8,1,1,0,4,8,7,7,0,1,9,0,2,7,1},
{2,5,2,6,7,6,8,0,2,7,6,0,7,8,0,0,3,0,1,3,6,7,8,6,8,0,9,9,2,5,2,5,4,6,3,4,0,1,0,6,1,6,3,2,8,6,6,5,2,6},
{3,6,2,7,0,2,1,8,5,4,0,4,9,7,7,0,5,5,8,5,6,2,9,9,4,6,5,8,0,6,3,6,2,3,7,9,9,3,1,4,0,7,4,6,2,5,5,9,6,2},
{2,4,0,7,4,4,8,6,9,0,8,2,3,1,1,7,4,9,7,7,7,9,2,3,6,5,4,6,6,2,5,7,2,4,6,9,2,3,3,2,2,8,1,0,9,1,7,1,4,1},
{9,1,4,3,0,2,8,8,1,9,7,1,0,3,2,8,8,5,9,7,8,0,6,6,6,9,7,6,0,8,9,2,9,3,8,6,3,8,2,8,5,0,2,5,3,3,3,4,0,3},
{3,4,4,1,3,0,6,5,5,7,8,0,1,6,1,2,7,8,1,5,9,2,1,8,1,5,0,0,5,5,6,1,8,6,8,8,3,6,4,6,8,4,2,0,0,9,0,4,7,0},
{2,3,0,5,3,0,8,1,1,7,2,8,1,6,4,3,0,4,8,7,6,2,3,7,9,1,9,6,9,8,4,2,4,8,7,2,5,5,0,3,6,6,3,8,7,8,4,5,8,3},
{1,1,4,8,7,6,9,6,9,3,2,1,5,4,9,0,2,8,1,0,4,2,4,0,2,0,1,3,8,3,3,5,1,2,4,4,6,2,1,8,1,4,4,1,7,7,3,4,7,0},
{6,3,7,8,3,2,9,9,4,9,0,6,3,6,2,5,9,6,6,6,4,9,8,5,8,7,6,1,8,2,2,1,2,2,5,2,2,5,5,1,2,4,8,6,7,6,4,5,3,3},
{6,7,7,2,0,1,8,6,9,7,1,6,9,8,5,4,4,3,1,2,4,1,9,5,7,2,4,0,9,9,1,3,9,5,9,0,0,8,9,5,2,3,1,0,0,5,8,8,2,2},
{9,5,5,4,8,2,5,5,3,0,0,2,6,3,5,2,0,7,8,1,5,3,2,2,9,6,7,9,6,2,4,9,4,8,1,6,4,1,9,5,3,8,6,8,2,1,8,7,7,4},
{7,6,0,8,5,3,2,7,1,3,2,2,8,5,7,2,3,1,1,0,4,2,4,8,0,3,4,5,6,1,2,4,8,6,7,6,9,7,0,6,4,5,0,7,9,9,5,2,3,6},
{3,7,7,7,4,2,4,2,5,3,5,4,1,1,2,9,1,6,8,4,2,7,6,8,6,5,5,3,8,9,2,6,2,0,5,0,2,4,9,1,0,3,2,6,5,7,2,9,6,7},
{2,3,7,0,1,9,1,3,2,7,5,7,2,5,6,7,5,2,8,5,6,5,3,2,4,8,2,5,8,2,6,5,4,6,3,0,9,2,2,0,7,0,5,8,5,9,6,5,2,2},
{2,9,7,9,8,8,6,0,2,7,2,2,5,8,3,3,1,9,1,3,1,2,6,3,7,5,1,4,7,3,4,1,9,9,4,8,8,9,5,3,4,7,6,5,7,4,5,5,0,1},
{1,8,4,9,5,7,0,1,4,5,4,8,7,9,2,8,8,9,8,4,8,5,6,8,2,7,7,2,6,0,7,7,7,1,3,7,2,1,4,0,3,7,9,8,8,7,9,7,1,5},
{3,8,2,9,8,2,0,3,7,8,3,0,3,1,4,7,3,5,2,7,7,2,1,5,8,0,3,4,8,1,4,4,5,1,3,4,9,1,3,7,3,2,2,6,6,5,1,3,8,1},
{3,4,8,2,9,5,4,3,8,2,9,1,9,9,9,1,8,1,8,0,2,7,8,9,1,6,5,2,2,4,3,1,0,2,7,3,9,2,2,5,1,1,2,2,8,6,9,5,3,9},
{4,0,9,5,7,9,5,3,0,6,6,4,0,5,2,3,2,6,3,2,5,3,8,0,4,4,1,0,0,0,5,9,6,5,4,9,3,9,1,5,9,8,7,9,5,9,3,6,3,5},
{2,9,7,4,6,1,5,2,1,8,5,5,0,2,3,7,1,3,0,7,6,4,2,2,5,5,1,2,1,1,8,3,6,9,3,8,0,3,5,8,0,3,8,8,5,8,4,9,0,3},
{4,1,6,9,8,1,1,6,2,2,2,0,7,2,9,7,7,1,8,6,1,5,8,2,3,6,6,7,8,4,2,4,6,8,9,1,5,7,9,9,3,5,3,2,9,6,1,9,2,2},
{6,2,4,6,7,9,5,7,1,9,4,4,0,1,2,6,9,0,4,3,8,7,7,1,0,7,2,7,5,0,4,8,1,0,2,3,9,0,8,9,5,5,2,3,5,9,7,4,5,7},
{2,3,1,8,9,7,0,6,7,7,2,5,4,7,9,1,5,0,6,1,5,0,5,5,0,4,9,5,3,9,2,2,9,7,9,5,3,0,9,0,1,1,2,9,9,6,7,5,1,9},
{8,6,1,8,8,0,8,8,2,2,5,8,7,5,3,1,4,5,2,9,5,8,4,0,9,9,2,5,1,2,0,3,8,2,9,0,0,9,4,0,7,7,7,0,7,7,5,6,7,2},
{1,1,3,0,6,7,3,9,7,0,8,3,0,4,7,2,4,4,8,3,8,1,6,5,3,3,8,7,3,5,0,2,3,4,0,8,4,5,6,4,7,0,5,8,0,7,7,3,0,8},
{8,2,9,5,9,1,7,4,7,6,7,1,4,0,3,6,3,1,9,8,0,0,8,1,8,7,1,2,9,0,1,1,8,7,5,4,9,1,3,1,0,5,4,7,1,2,6,5,8,1},
{9,7,6,2,3,3,3,1,0,4,4,8,1,8,3,8,6,2,6,9,5,1,5,4,5,6,3,3,4,9,2,6,3,6,6,5,7,2,8,9,7,5,6,3,4,0,0,5,0,0},
{4,2,8,4,6,2,8,0,1,8,3,5,1,7,0,7,0,5,2,7,8,3,1,8,3,9,4,2,5,8,8,2,1,4,5,5,2,1,2,2,7,2,5,1,2,5,0,3,2,7},
{5,5,1,2,1,6,0,3,5,4,6,9,8,1,2,0,0,5,8,1,7,6,2,1,6,5,2,1,2,8,2,7,6,5,2,7,5,1,6,9,1,2,9,6,8,9,7,7,8,9},
{3,2,2,3,8,1,9,5,7,3,4,3,2,9,3,3,9,9,4,6,4,3,7,5,0,1,9,0,7,8,3,6,9,4,5,7,6,5,8,8,3,3,5,2,3,9,9,8,8,6},
{7,5,5,0,6,1,6,4,9,6,5,1,8,4,7,7,5,1,8,0,7,3,8,1,6,8,8,3,7,8,6,1,0,9,1,5,2,7,3,5,7,9,2,9,7,0,1,3,3,7},
{6,2,1,7,7,8,4,2,7,5,2,1,9,2,6,2,3,4,0,1,9,4,2,3,9,9,6,3,9,1,6,8,0,4,4,9,8,3,9,9,3,1,7,3,3,1,2,7,3,1},
{3,2,9,2,4,1,8,5,7,0,7,1,4,7,3,4,9,5,6,6,9,1,6,6,7,4,6,8,7,6,3,4,6,6,0,9,1,5,0,3,5,9,1,4,6,7,7,5,0,4},
{9,9,5,1,8,6,7,1,4,3,0,2,3,5,2,1,9,6,2,8,8,9,4,8,9,0,1,0,2,4,2,3,3,2,5,1,1,6,9,1,3,6,1,9,6,2,6,6,2,2},
{7,3,2,6,7,4,6,0,8,0,0,5,9,1,5,4,7,4,7,1,8,3,0,7,9,8,3,9,2,8,6,8,5,3,5,2,0,6,9,4,6,9,4,4,5,4,0,7,2,4},
{7,6,8,4,1,8,2,2,5,2,4,6,7,4,4,1,7,1,6,1,5,1,4,0,3,6,4,2,7,9,8,2,2,7,3,3,4,8,0,5,5,5,5,6,2,1,4,8,1,8},
{9,7,1,4,2,6,1,7,9,1,0,3,4,2,5,9,8,6,4,7,2,0,4,5,1,6,8,9,3,9,8,9,4,2,2,1,7,9,8,2,6,0,8,8,0,7,6,8,5,2},
{8,7,7,8,3,6,4,6,1,8,2,7,9,9,3,4,6,3,1,3,7,6,7,7,5,4,3,0,7,8,0,9,3,6,3,3,3,3,0,1,8,9,8,2,6,4,2,0,9,0},
{1,0,8,4,8,8,0,2,5,2,1,6,7,4,6,7,0,8,8,3,2,1,5,1,2,0,1,8,5,8,8,3,5,4,3,2,2,3,8,1,2,8,7,6,9,5,2,7,8,6},
{7,1,3,2,9,6,1,2,4,7,4,7,8,2,4,6,4,5,3,8,6,3,6,9,9,3,0,0,9,0,4,9,3,1,0,3,6,3,6,1,9,7,6,3,8,7,8,0,3,9},
{6,2,1,8,4,0,7,3,5,7,2,3,9,9,7,9,4,2,2,3,4,0,6,2,3,5,3,9,3,8,0,8,3,3,9,6,5,1,3,2,7,4,0,8,0,1,1,1,1,6},
{6,6,6,2,7,8,9,1,9,8,1,4,8,8,0,8,7,7,9,7,9,4,1,8,7,6,8,7,6,1,4,4,2,3,0,0,3,0,9,8,4,4,9,0,8,5,1,4,1,1},
{6,0,6,6,1,8,2,6,2,9,3,6,8,2,8,3,6,7,6,4,7,4,4,7,7,9,2,3,9,1,8,0,3,3,5,1,1,0,9,8,9,0,6,9,7,9,0,7,1,4},
{8,5,7,8,6,9,4,4,0,8,9,5,5,2,9,9,0,6,5,3,6,4,0,4,4,7,4,2,5,5,7,6,0,8,3,6,5,9,9,7,6,6,4,5,7,9,5,0,9,6},
{6,6,0,2,4,3,9,6,4,0,9,9,0,5,3,8,9,6,0,7,1,2,0,1,9,8,2,1,9,9,7,6,0,4,7,5,9,9,4,9,0,1,9,7,2,3,0,2,9,7},
{6,4,9,1,3,9,8,2,6,8,0,0,3,2,9,7,3,1,5,6,0,3,7,1,2,0,0,4,1,3,7,7,9,0,3,7,8,5,5,6,6,0,8,5,0,8,9,2,5,2},
{1,6,7,3,0,9,3,9,3,1,9,8,7,2,7,5,0,2,7,5,4,6,8,9,0,6,9,0,3,7,0,7,5,3,9,4,1,3,0,4,2,6,5,2,3,1,5,0,1,1},
{9,4,8,0,9,3,7,7,2,4,5,0,4,8,7,9,5,1,5,0,9,5,4,1,0,0,9,2,1,6,4,5,8,6,3,7,5,4,7,1,0,5,9,8,4,3,6,7,9,1},
{7,8,6,3,9,1,6,7,0,2,1,1,8,7,4,9,2,4,3,1,9,9,5,7,0,0,6,4,1,9,1,7,9,6,9,7,7,7,5,9,9,0,2,8,3,0,0,6,9,9},
{1,5,3,6,8,7,1,3,7,1,1,9,3,6,6,1,4,9,5,2,8,1,1,3,0,5,8,7,6,3,8,0,2,7,8,4,1,0,7,5,4,4,4,9,7,3,3,0,7,8},
{4,0,7,8,9,9,2,3,1,1,5,5,3,5,5,6,2,5,6,1,1,4,2,3,2,2,4,2,3,2,5,5,0,3,3,6,8,5,4,4,2,4,8,8,9,1,7,3,5,3},
{4,4,8,8,9,9,1,1,5,0,1,4,4,0,6,4,8,0,2,0,3,6,9,0,6,8,0,6,3,9,6,0,6,7,2,3,2,2,1,9,3,2,0,4,1,4,9,5,3,5},
{4,1,5,0,3,1,2,8,8,8,0,3,3,9,5,3,6,0,5,3,2,9,9,3,4,0,3,6,8,0,0,6,9,7,7,7,1,0,6,5,0,5,6,6,6,3,1,9,5,4},
{8,1,2,3,4,8,8,0,6,7,3,2,1,0,1,4,6,7,3,9,0,5,8,5,6,8,5,5,7,9,3,4,5,8,1,4,0,3,6,2,7,8,2,2,7,0,3,2,8,0},
{8,2,6,1,6,5,7,0,7,7,3,9,4,8,3,2,7,5,9,2,2,3,2,8,4,5,9,4,1,7,0,6,5,2,5,0,9,4,5,1,2,3,2,5,2,3,0,6,0,8},
{2,2,9,1,8,8,0,2,0,5,8,7,7,7,3,1,9,7,1,9,8,3,9,4,5,0,1,8,0,8,8,8,0,7,2,4,2,9,6,6,1,9,8,0,8,1,1,1,9,7},
{7,7,1,5,8,5,4,2,5,0,2,0,1,6,5,4,5,0,9,0,4,1,3,2,4,5,8,0,9,7,8,6,8,8,2,7,7,8,9,4,8,7,2,1,8,5,9,6,1,7},
{7,2,1,0,7,8,3,8,4,3,5,0,6,9,1,8,6,1,5,5,4,3,5,6,6,2,8,8,4,0,6,2,2,5,7,4,7,3,6,9,2,2,8,4,5,0,9,5,1,6},
{2,0,8,4,9,6,0,3,9,8,0,1,3,4,0,0,1,7,2,3,9,3,0,6,7,1,6,6,6,8,2,3,5,5,5,2,4,5,2,5,2,8,0,4,6,0,9,7,2,2},
{5,3,5,0,3,5,3,4,2,2,6,4,7,2,5,2,4,2,5,0,8,7,4,0,5,4,0,7,5,5,9,1,7,8,9,7,8,1,2,6,4,3,3,0,3,3,1,6,9,0}};
            int[] totalNumber = new int[50];
            int remainder = 0;
            int sum;
            for (int i = 49; i >= 0; i--)
            {
                sum = remainder;
                for (int j = 0; j < 100; j++)
                {
                    sum += matrix[j, i];
                }
                if (i == 0)
                {
                    totalNumber[i] = sum;
                }
                else
                {
                    remainder = sum / 10;
                    totalNumber[i] = sum % 10;
                }
            }
            foreach(int runner in totalNumber)
            {
                Console.Write(runner);
            }

        }

        public void problem14()
        {

            Dictionary<long, long> collatzTable = new Dictionary<long, long>();
            collatzTable.Add(4, 3);
            long collatzRunner = 0;
            long collatsIterations = 0;
            long maxCollatsIterations = 0;
            bool converged;
            for (long runner = 5; runner <= 1000000; runner++)
            {
                collatzRunner = runner;
                converged = false;
                collatsIterations = 0;
                while (!converged)
                {
                    if (collatzTable.ContainsKey(collatzRunner))
                    {
                        collatzTable.Add(runner, collatsIterations + collatzTable[collatzRunner]);
                        if (collatzTable[runner] > maxCollatsIterations)
                        {
                            maxCollatsIterations = collatzTable[runner];
                            Console.WriteLine("Key:{0} - Value:{1}", runner, collatzTable[runner]);
                        }
                        converged = true;
                    }
                    else
                    {
                        if (collatzRunner % 2 == 0)//is even
                        {
                            collatzRunner /= 2;
                        }
                        else
                        {
                            collatzRunner = 3 * collatzRunner + 1;
                        }
                        collatsIterations++;
                    }
                }

            }
            Console.WriteLine("DONE!");
        }

        public void problem15()
        {
            long result = power(2, 10);
            result *= partialFactorial(21, 39);
            result /= factorial(10);
            Console.WriteLine("Result is of a {0}", result);            
        }

        public void problem16()
        {
            superInt jens1 = new superInt(new int[] { 2 });
            superInt jens2 = new superInt(new int[] { 2 });
            for (int i = 0; i < 999; i++)
            {
                jens1.multiplyMynumber(jens2);
                //jens1.printMyNumber();
                //Console.Write("\n");
            }
            jens1.printMyNumber();
            Console.Write("\n");
            int sum = 0;
            for (int i = 0; i < jens1.myNumber.Length; i++)
            {
                sum += jens1.myNumber[i];
            }
            Console.WriteLine("SUM of 2^1000 is: {0}", sum);
        }

        public void problem17()
        {
            Dictionary<int, string> intToStingTable = new Dictionary<int, string>();
            intToStingTable.Add(1, "one");
            intToStingTable.Add(2, "two");
            intToStingTable.Add(3, "three");
            intToStingTable.Add(4, "four");
            intToStingTable.Add(5, "five");
            intToStingTable.Add(6, "six");
            intToStingTable.Add(7, "seven");
            intToStingTable.Add(8, "eight");
            intToStingTable.Add(9, "nine");
            intToStingTable.Add(10, "ten");
            intToStingTable.Add(11, "eleven");
            intToStingTable.Add(12, "twelve");
            intToStingTable.Add(13, "thirteen");
            intToStingTable.Add(14, "fourteen");
            intToStingTable.Add(15, "fifteen");
            intToStingTable.Add(16, "sixteen");
            intToStingTable.Add(17, "seventeen");
            intToStingTable.Add(18, "eighteen");
            intToStingTable.Add(19, "nineteen");
            intToStingTable.Add(20, "twenty");
            intToStingTable.Add(30, "thirty");
            intToStingTable.Add(40, "forty");
            intToStingTable.Add(50, "fifty");
            intToStingTable.Add(60, "sixty");
            intToStingTable.Add(70, "seventy");
            intToStingTable.Add(80, "eighty");
            intToStingTable.Add(90, "ninety");
            intToStingTable.Add(100, "hundred");

            string hundreds;
            string tens;
            string ones;
            int number;
            int totalStringLength = 12;
            string numberstring;
            for (int i = 1; i <= 999; i++)
            {
                hundreds = "";
                tens = "";
                ones = "";
                numberstring = "";
                if (i / 100 > 0)
                {
                    hundreds = intToStingTable[i / 100] +  intToStingTable[100];
                }
                number = i % 100;
                if (number >= 20)
                {
                    tens = intToStingTable[number - (number % 10)];
                }
                else if (number < 20 && number >= 10) {
                    tens = intToStingTable[number];
                    number = 0;
                
                }
                number = number % 10;
                if (number > 0)
                {
                    ones = intToStingTable[number];
                }
                if (ones.Length != 0)
                {
                    numberstring = ones;
                }
                if (tens.Length != 0 && ones.Length != 0)
                {
                    numberstring = tens + ones;
                }
                if (tens.Length != 0 && ones.Length == 0)
                {
                    numberstring = tens;
                }
                if (hundreds.Length != 0 && numberstring.Length != 0)
                {
                    numberstring = hundreds + "and" + numberstring;
                }
                else if (hundreds.Length == 0 && numberstring.Length != 0)
                {
                }
                else
                {
                    numberstring = hundreds;

                }
                totalStringLength += numberstring.Length;
                Console.WriteLine("{0}. {1}. {2}", i , numberstring, numberstring.Length);
            }
            Console.WriteLine("Number of letters: {0}", totalStringLength);
        }

        public void problem18() {
            Dictionary<int, int[]> pyramid = new Dictionary<int, int[]>();
            pyramid.Add(1, new int[] { 75});
            pyramid.Add(2, new int[] { 95, 64});
            pyramid.Add(3, new int[] { 17, 47, 82 });
            pyramid.Add(4, new int[] { 18, 35, 87, 10});
            pyramid.Add(5, new int[] { 20, 04, 82, 47, 65});
            pyramid.Add(6, new int[] { 19, 01, 23, 75, 03, 34});
            pyramid.Add(7, new int[] { 88, 02, 77, 73, 07, 63, 67});
            pyramid.Add(8, new int[] { 99, 65, 04, 28, 06, 16, 70, 92});
            pyramid.Add(9, new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33});
            pyramid.Add(10, new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29});
            pyramid.Add(11, new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14});
            pyramid.Add(12, new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57});
            pyramid.Add(13, new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48});
            pyramid.Add(14, new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31});
            pyramid.Add(15, new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}) ;
            int jenp = sumMaxChildren(pyramid, 1, 0, 75);


        }
        public void problem19()
        {
            //TEST
            //superDate jenp1 = new superDate(2000, 2, 28, 1);
            //jenp1.writeMe();
            //jenp1.addAnchor();
            //jenp1.writeMe();
            //superDate jenp2 = new superDate(1999, 2, 28, 1);
            //jenp2.writeMe();
            //jenp2.addAnchor();
            //jenp2.writeMe();
            //superDate jenp3 = new superDate(1996, 2, 28, 1);
            //jenp3.writeMe();
            //jenp3.addAnchor();
            //jenp3.writeMe();
            //superDate jenp4 = new superDate(1929, 12, 31, 1);
            //jenp4.writeMe();
            //jenp4.addAnchor();
            //jenp4.writeMe();
            //superDate jenp5 = new superDate(1900, 2, 28, 1);
            //jenp5.writeMe();
            //jenp5.addAnchor();
            //jenp5.writeMe();
            superDate jenp6 = new superDate(1900, 1, 1, 0);
            jenp6.writeMe();
            jenp6.addNAnchor(365);
            jenp6.writeMe();
            int eulerCounter = 0;
            while (!jenp6.amIThisDate(2000, 12, 31))
            {
                jenp6.addAnchor();
                if (jenp6.amIEulerWorthy()){ eulerCounter++; }
            }
            Console.WriteLine("Number of Euler worthy dates are: {0}", eulerCounter);
        }

        public void problem20()
        {
            superInt jenp1 = new superInt(new int[] { 1 });
            for (int i = 2; i < 101; i++)
            {
                int ones = i % 10;
                int tens = i / 10;
                int hundreds = i / 100;
                superInt jenp2;
                if (tens != 0  && hundreds != 0)
                {
                    jenp2 = new superInt(new int[] { hundreds, 0, 0 });
                }
                else if ( tens != 0)
                {
                    jenp2 = new superInt(new int[] { tens, ones });
                }
                else
                {
                    jenp2 = new superInt(new int[] {  ones });
                }
                jenp1.multiplyMynumber(jenp2);
            }
            jenp1.printMyNumber();
            int total = 0;
            foreach(int i in jenp1.myNumber)
            {
                total += i;
            }
            Console.WriteLine("");
            Console.WriteLine(total);
        }

        public void problem21()
        {
            Console.WriteLine("HELLO : {0}",sumDevisors(220));
            Dictionary<int, int> possibleAmicable = new Dictionary<int, int>();
            List<int> amicable = new List<int>();
            int sumDevisor;
            int sumAllAmicable = 0;
            for(int i = 1; i<=10000; i++)
            {
                sumDevisor = sumDevisors(i);
                possibleAmicable.Add(i, sumDevisor);
                if (possibleAmicable.ContainsKey(sumDevisor)){
                    if (possibleAmicable[sumDevisor] == i && possibleAmicable[i] == sumDevisor && i != sumDevisor)
                    {
                        amicable.Add(i);
                        Console.WriteLine("Amicable number is {0}", i);
                        sumAllAmicable += i + possibleAmicable[i];
                    }
                }
            }
            Console.WriteLine("Sum of Amicable numbers is {0}", sumAllAmicable);
        }

        public void problem22()
        {
            Dictionary<char, int> charValueList = new Dictionary<char, int>();
            charValueList.Add('a', 1);
            charValueList.Add('b', 2);
            charValueList.Add('c', 3);
            charValueList.Add('d', 4);
            charValueList.Add('e', 5);
            charValueList.Add('f', 6);
            charValueList.Add('g', 7);
            charValueList.Add('h', 8);
            charValueList.Add('i', 9);
            charValueList.Add('j', 10);
            charValueList.Add('k', 11);
            charValueList.Add('l', 12);
            charValueList.Add('m', 13);
            charValueList.Add('n', 14);
            charValueList.Add('o', 15);
            charValueList.Add('p', 16);
            charValueList.Add('q', 17);
            charValueList.Add('r', 18);
            charValueList.Add('s', 19);
            charValueList.Add('t', 20);
            charValueList.Add('u', 21);
            charValueList.Add('v', 22);
            charValueList.Add('w', 23);
            charValueList.Add('x', 24);
            charValueList.Add('y', 25);
            charValueList.Add('z', 26);
            charValueList.Add('A', 1);
            charValueList.Add('B', 2);
            charValueList.Add('C', 3);
            charValueList.Add('D', 4);
            charValueList.Add('E', 5);
            charValueList.Add('F', 6);
            charValueList.Add('G', 7);
            charValueList.Add('H', 8);
            charValueList.Add('I', 9);
            charValueList.Add('J', 10);
            charValueList.Add('K', 11);
            charValueList.Add('L', 12);
            charValueList.Add('M', 13);
            charValueList.Add('N', 14);
            charValueList.Add('O', 15);
            charValueList.Add('P', 16);
            charValueList.Add('Q', 17);
            charValueList.Add('R', 18);
            charValueList.Add('S', 19);
            charValueList.Add('T', 20);
            charValueList.Add('U', 21);
            charValueList.Add('V', 22);
            charValueList.Add('W', 23);
            charValueList.Add('X', 24);
            charValueList.Add('Y', 25);
            charValueList.Add('Z', 26);
            string path = "C:\\Git\\c-PlayGround\\Tutorial1\\Tutorial1\\Data\\NAMES.txt";
            string myText = "";
            if (File.Exists(path))
            {
                myText = System.IO.File.ReadAllText(path);
            }
            List<string> splitStrings = new List<string>();
            foreach (string myString in myText.Split(","))
            {
                splitStrings.Add(myString);
            }
            splitStrings.Sort();
            
            char character;
            int myStringLen = 0;
            int myStringScore = 0;
            int totalScore = 0;
            int counter = 1;
            foreach (string myString in splitStrings)
            {
                myStringLen = myString.Length;
                myStringScore = 0;
                for (int i = 0; i < myStringLen; i++)
                {    
                    character = myString[i];
                    myStringScore += charValueList[character];
                }
                totalScore += myStringScore*counter;
                Console.WriteLine(counter + ": "+ myString+ ": " + totalScore);
                counter++;
                
            }
        }
        public int sumDevisors(int N)
        {
            int sumDevisors = 1;
            
            for (int runner = 2; runner <= Math.Sqrt(N); runner++)
            {
                if (N % runner == 0)
                {
                    if (N / runner == runner)
                    {
                        sumDevisors += runner;
                    }
                    else
                    {
                        sumDevisors += runner + N/runner;
                    }
                }
            }
            return sumDevisors;
        }
        class superDate
        {
            public int year;
            public int month;
            public int date;
            public int weekday;
            private string[] weekdayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            public superDate()
            {
                year = 1900;
                month = 1;
                date = 1;
                weekday = 1;
            }
            public superDate(int y, int m, int d, int w)
            {
                year = y;
                month = m;
                date = d;
                weekday = w;
            }
            public void writeMe()
            {
                Console.WriteLine("Date is:{0}, {1}, {2}. Its a {3}", year, month, date, weekdayNames[weekday]);
            }
            public void addAnchor()
            {
                addDate();
                addWeekday();
            }
            public void addNAnchor(int N)
            {
                for (int i = 0; i < N; i++)
                {
                    addDate();
                    addWeekday();
                }
            }
            public bool amIThisDate(int y, int m, int d)
            {
                if( year == y && month == m && date == d)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool amIEulerWorthy()
            {
                if (date == 1 && weekday == 6)
                {
                    writeMe();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            private void addWeekday()
            {
                weekday = weekday == 6 ? weekday = 0 : weekday + 1;
            }
            private void addDate()
            {
                switch (date)
                {
                    case 28:
                        if ((month == 2 && (year % 4 != 0)) || (month == 2 && (year % 100 == 0) && (year % 400 != 0)))
                        {
                            month += 1;
                            date = 1;
                        }
                        else
                        {   
                            date += 1;
                        }
                        break;
                    case 29:
                        if (month == 2)
                        {
                            month += 1;
                            date = 1;
                        }
                        else
                        {
                            date += 1;
                        }
                        break;
                    case 30:
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            month += 1;
                            date = 1;
                        }
                        else
                        {
                            date += 1;
                        }
                        break;
                    case 31:
                        if (month == 12 && date == 31)
                        {
                            year += 1;
                            month = 1;
                            date = 1;
                        }
                        else 
                        {
                            month += 1;
                            date = 1;
                        }
                        break;
                    default:
                        date += 1;
                        break;
                }

            }
        }

            

        public int sumMaxChildren(Dictionary<int, int[]> pyramid, int layer, int position, int inputVal)
        {
            if (layer < 14) {
                int sumChild1 = sumMaxChildren(pyramid, layer + 1, position, pyramid[layer+1][position]);
                int sumChild2 = sumMaxChildren(pyramid, layer + 1, position + 1, pyramid[layer+1][position+1]);
                return sumChild1 > sumChild2 ? inputVal + sumChild1 : inputVal + sumChild2;   
            }
            else
            {
                int sumChild1 = pyramid[layer+1][position];
                int sumChild2 = pyramid[layer+1][position+1];
                return sumChild1 > sumChild2 ? inputVal + sumChild1 : inputVal + sumChild2;
            }
        }
        
        private long factorial(long input)
        {
            long output = 1;
            for (long i = 1; i <= input;i++)
            {
                output *= i;
            }
            return output;
        }
        private long power(long input1, long input2)
        {
            long output = input1;
            for (long i = 2; i <= input2; i++)
            {
                output *= input1;
            }
            return output;
        }
        private double power(double input1, long input2)
        {
            double output = input1;
            for (long i = 2; i <= input2; i++)
            {
                output *= input1;
            }
            return output;
        }
        private long partialFactorial(long input1, long input2)
        {
            long output = 1;
            for (long i = input1; i <= input2; i++)
            {
                if (i % 2 != 0)
                {
                    output *= i;
                }
            }
            return output;
        }
    }
    class superInt
    {
        public int[] myNumber;
        public superInt(int[] input)
        {
            myNumber = input;
        }
        public void printMyNumber()
        {
            Console.Write("myNumber is: ");
            foreach (int i in myNumber)
            {
                Console.Write(i);
            }
        }
        public void multiplyMynumber(superInt input)
        {
            int myNumberLenght = myNumber.Length;
            for (int i = 0; i < myNumber.Length; i++)
            {
                if (myNumber[i] != 0)
                {
                    myNumberLenght = myNumber.Length - i;
                    break;
                }
            }
            int inputLength = input.myNumber.Length;
            int length = inputLength + myNumberLenght;
            int[] product = new int[length];
            setZeros(ref product);
            int zeroCounter = 0;
            for (int i = inputLength - 1; i >= 0; i--)
            {
                int[] singleProduct = addTrailingZeros(multiplySingleInt(myNumber, input.myNumber[i]),zeroCounter);
                addNumbers(ref product, singleProduct);
                zeroCounter++;
            }
            myNumber = product;

        }
        private int[] multiplySingleInt(int[] input1, int input2)
        {
            int input1Length = input1.Length;
            int[] output = new int[input1Length + 1];
            int remainder = 0;
            for (int i = input1.Length - 1; i >= 0; i--)
            {
                output[i + 1] = (input1[i] * input2 + remainder)% 10;
                remainder = (input1[i] * input2 + remainder) / 10;
            }
            output[0] = remainder;
            return output;

        }
        private int[] addTrailingZeros(int[] input1, int input2)
        {
            int length = input1.Length + input2;
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i <= input1.Length - 1)
                {
                    output[i] = input1[i];
                }
                else
                {
                    output[i] = 0;
                }
            }
            return output;
        }

        private void addNumbers(ref int[] input1, int[] input2)
        {
            int[] output = new int[input1.Length];
            int remainder = 0;
            int runner1 = 0;
            int runner2 = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                runner1 = input1.Length - 1 - i;
                runner2 = input2.Length - 1 - i;
                if (runner2 >= 0)
                {
                    output[runner1] = (remainder + input1[runner1] + input2[runner2]) % 10;
                    remainder = (remainder + input1[runner1] + input2[runner2]) / 10;
                }
                else if(remainder != 0)
                {
                    output[runner1] = (remainder + input1[runner1]) % 10;
                    remainder = (remainder + input1[runner1]) / 10;
                }
                else
                {
                    output[runner1] = input1[runner1];
                }
            }
            input1 = output;
        }

        private void setZeros(ref int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = 0;
            }
        }
    }
}

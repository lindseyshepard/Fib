﻿using System;

namespace Fibonacci
{
    class SolveIt
    {
        //Given an integer n, write a function to compute
        //the nth fibonacci number.

        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34 etc..
        //What will your range be?
        // n=5

        //                  fib(5)
        //                /       \
        //           fib(4)        fib(3)
        //         /      \       /      \
        //     fib(3)   fib(2)   fib(2)   fib(1)
        //   /     \
        //fib(2)   fib(1)


        public long Fibonacci()
        {

            int x = 5;

            if (x < 0) return -1;
            if (x == 0) return 0;
            long[] cache = new long[x + 1]; //caching all intermidiate values into the array
            for (int i = 1; i < cache.Length; i++)
            {
                cache[i] = -1;

            }
            cache[1] = 1;


            Console.WriteLine(x);
            return x;



            //recurisviely call function nexts


        }



        private long Fib(int x, long[] cache)
        {
            if (cache[x] > -1) return cache[x];
            cache[x] = Fib(x - 1, cache) + Fib(x - 2, cache);
            return cache[x];
        }
    }
}

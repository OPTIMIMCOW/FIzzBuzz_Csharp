﻿using System;

namespace FizzBuzz_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

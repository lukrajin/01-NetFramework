﻿using System;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 100; ++i)
                sum += i;
            Console.WriteLine(sum);
        }
    }
}
﻿using System;
using Logicals;
using static System.Console;

namespace LogicalConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            //FizzBuzz.Run();

            FriendsAndBudget.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}

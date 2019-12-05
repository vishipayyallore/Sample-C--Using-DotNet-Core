﻿using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using Math = LogicPrograms.Logics.Math;

namespace LogicPrograms
{

    class Program
    {
        static void Main(string[] args)
        {

            // Kangaroo Jumps
            var x1V1X2V2 = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var message = "NO";

            int x1 = x1V1X2V2[0];
            int v1 = x1V1X2V2[1];
            int x2 = x1V1X2V2[2];
            int v2 = x1V1X2V2[3];

            if( (x2 > x1) && (v2 > v1))
            {
                WriteLine("NO");
            }
            else
            {
                while(true)
                {
                    var d1 = x1 + v1;
                    var d2 = x2 + v2;

                    if(d1 == d2)
                    {
                        message = "YES";
                        break;
                    }
                }
            }
            WriteLine(message);

            // Apples and Oranges
            AppleAndOrangesCount();

            AppleAndOrangesCountV2();

            // Library Fines
            LibraryFines();

            // Arrays: Left Rotation
            ArrayLeftRotation();

            // Grading Students
            GradingStudentsV1();

            // Grading Students
            GradingStudents();

            // Time Conversion
            TimeConversion();

            // Candles Count
            var candlesCount = BirthdayCandles();
            WriteLine($"Count: {candlesCount}");

            MinMaxInArray();

            GeneralPrograms generalPrograms = new GeneralPrograms();
            generalPrograms.DisplayStairCase(10);

            // Stair Case Program
            var number1 = 4;
            for (var index = 1; index <= number1; index++)
            {
                WriteLine(string.Concat(Enumerable.Repeat("#", index)).PadLeft(number1));
            }


            IMonthNames monthNames = new MonthNames();

            for (var counter = 1; counter <= 10; counter++)
            {
                monthNames.DisplayMonthNames();
            }

            //------------------------------------------------------------------------------------------
            var arrayItems = new int[] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0 };

            var left = 0;
            var right = arrayItems.Length - 1;
            for (var index = 0; index < arrayItems.Length; index++)
            {
                if (arrayItems[left] > arrayItems[right])
                {
                    var temp = arrayItems[left];
                    arrayItems[left] = arrayItems[right];
                    arrayItems[right] = temp;
                    left++;
                    right--;
                }
            }

            ISortBinaryArray sortBinaryArray = new SortBinaryArray();
            sortBinaryArray.SortArray(arrayItems);
            //------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------
            IMath math = new Math();

            Write("\n\nEnter a number for finding Factorial: ");

            if (int.TryParse(ReadLine(), out int number))
            {
                var factorial = math.GetFactorial(number);
                WriteLine($"Factorial: {factorial}");
            }
            //------------------------------------------------------------------------------------------

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void AppleAndOrangesCount()
        {
            string[] st = ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);

            string[] ab = ReadLine().Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);

            string[] mn = ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] oranges = Array.ConvertAll(ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            var count = 0;
            foreach (var apple in apples)
            {
                var distance = a + apple;
                if (distance >= s && distance <= t)
                {
                    count++;
                }
            }
            WriteLine($"{count}");

            count = 0;
            foreach (var orange in oranges)
            {
                var distance = b + orange;
                if (distance >= s && distance <= t)
                {
                    count++;
                }
            }
            WriteLine($"{count}");
        }

        private static void LibraryFines()
        {
            var actual = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var expected = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            var fine = 0;

            if (actual[2] > expected[2])
            {
                fine = 10000;
            }
            else if (actual[2] == expected[2])
            {
                if (actual[1] > expected[1])
                {
                    fine = 500 * (actual[1] - expected[1]);
                }
                else if (actual[1] == expected[1])
                {
                    if (actual[0] > expected[0])
                    {
                        fine = 15 * (actual[0] - expected[0]);
                    }
                }
            }

            WriteLine($"{fine}");
        }

        private static void GradingStudentsV1()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingResult.GradingStudents(grades);
        }

        private static void ArrayLeftRotation()
        {
            var arrayData = new int[] { 1, 2, 3, 4, 5 };
            var d = 4;
            var tempArray = new int[arrayData.Length];
            var start = 0;
            for (var iCtr = (d); iCtr < arrayData.Length; iCtr++)
            {
                tempArray[start++] = arrayData[iCtr];
            }

            for (var iCtr = 0; iCtr < d; iCtr++)
            {
                tempArray[start++] = arrayData[iCtr];
            }
        }

        private static void GradingStudents()
        {
            var students = int.Parse(ReadLine());
            var grades = new int[students];
            for (var i = 0; i < students; i++)
            {
                var grade = int.Parse(ReadLine());

                if (grade < 38)
                {
                    grades[i] = grade;
                }
                else
                {
                    var reminder = grade % 10;
                    var balance = 0;
                    if (reminder >= 1 && reminder < 5)
                    {
                        balance = 5 - reminder;
                    }
                    else if (reminder >= 6 && reminder < 10)
                    {
                        balance = 10 - reminder;
                    }

                    if (balance < 3)
                    {
                        grades[i] = grade + balance;
                    }
                    else
                    {
                        grades[i] = grade;
                    }
                }
            }
        }

        private static void TimeConversion()
        {
            var time12 = "07:05:45PM";

            // var timePart = Array.ConvertAll(time12.Substring(0, 8).Split(":"), item => int.Parse(item));
            var timePart = Array.ConvertAll(time12.Substring(0, 8).Split(":"), int.Parse);
            var amPm = time12.Substring(8);

            if (amPm == "AM")
            {
                if (timePart[0] == 12)
                {
                    timePart[0] = 0;
                }
            }
            else if (amPm == "PM")
            {
                if (timePart[0] < 12)
                {
                    timePart[0] += 12;
                }
            }

            WriteLine($"{timePart[0]:00}:{timePart[1]:00}:{timePart[2]:00}");
        }

        private static int BirthdayCandles()
        {
            int[] array = { 3, 5, 2, 5, 1, 3, 5 };
            int maxNumber = array[0];
            int maxNumberCount = 0;

            for(var index=0; index < array.Length; index++)
            {
                if(maxNumber < array[index])
                {
                    maxNumber = array[index];
                    maxNumberCount = 1;
                }
                else if(maxNumber == array[index])
                {
                    maxNumberCount++;
                }
            }

            return maxNumberCount;
        }

        private static void MinMaxInArray()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int min = 0, max = 0;

            for (int index = 0; index < array1.Length; index++)
            {
                var current = array1.Sum() - array1[index];

                if (index == 0)
                {
                    min = max = current;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    else if (current <= min)
                    {
                        min = current;
                    }
                }
                WriteLine(array1.Sum() - array1[index]);
            }
            WriteLine($"{min} {max}");
        }

        private static void AppleAndOrangesCountV2()
        {
            var st = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int s = st[0];
            int t = st[1];

            var ab = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int a = ab[0];
            int b = ab[1];

            var mn = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int m = mn[0];
            int n = mn[1];

            int[] apples = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            int[] oranges = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

            CountFruits(s, t, a, apples);

            CountFruits(s, t, b, oranges);
        }

        private static void CountFruits(int start, int end, int currentLocation, int[] fruits)
        {
            var count = 0;
            foreach (var fruit in fruits)
            {
                var distance = currentLocation + fruit;
                if (distance >= start && distance <= end)
                {
                    count++;
                }
            }
            WriteLine($"{count}");
        }

    }

}


//static Int64 GetSum(int[] array1)
//{
//    Int64 sum = 0;
//    for (var index = 0; index < array1.Length; index++)
//    {
//        sum += array1[index];
//    }

//    return sum;
//}

//static void miniMaxSum(int[] array1)
//{
//    Int64 sum = GetSum(array1);
//    Int64 min = sum, max = 0;

//    for (int index = 0; index < array1.Length; index++)
//    {
//        Int64 current = sum - array1[index];

//        if (current > max)
//        {
//            max = current;
//        }
//        if (current < min)
//        {
//            min = current;
//        }
//    }
//    Console.WriteLine($"{min} {max}");
//}
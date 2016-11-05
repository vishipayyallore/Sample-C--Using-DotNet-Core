﻿using System;
using System.Linq;
using static System.Console;

namespace SingleDArray
{

    /*
     * SAMPLE INPUT 
        5 2
        1 0 1 1 0
        1 2
        0 1 4
       SAMPLE OUTPUT 
        ODD
     */
    public class BinaryQueries
    {

        #region Variables.
        private static int[] _arrayValues;
        #endregion

        public BinaryQueries() { }

        public static void Run()
        {
            var firstLineInput = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var arrayLength = firstLineInput[0];
            var numberOfQueries = firstLineInput[1];

            //_arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            _arrayValues = BinaryValues.Split(' ').Select(int.Parse).ToArray(); 
            for (var iCtr = 0; iCtr < numberOfQueries; iCtr++)
            {
                var currentQuery = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var tempArray = _arrayValues;
                long sum = 0;
                var jCtr = 0;
                var queryType = currentQuery[0];
                switch (queryType)
                {
                    case 0:
                        jCtr = currentQuery[1];
                        arrayLength = currentQuery[2] - currentQuery[1];
                        break;
                    case 1:
                        var indexToChange = currentQuery[1];
                        tempArray[indexToChange] = 1 - _arrayValues[indexToChange];
                        break;
                }

                var powerValue = 1;
                for (var kCtr=0; kCtr < arrayLength; kCtr++, jCtr++)
                {
                    sum += (tempArray[jCtr] * powerValue);
                    powerValue *= 2;
                }

                if (currentQuery[0] == 0)
                {
                    WriteLine("{0}", ((sum % 2 == 0) ? "EVEN" : "ODD"));
                }

            }
        }

        
    }
}

//var data = string.Join("", tempArray.Skip(jCtr).Take(arrayLength - 1).Reverse().ToArray());
//sum = Convert.ToInt64(data, 2);
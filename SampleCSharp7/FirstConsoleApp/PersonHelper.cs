﻿using System.Linq;
using static System.Console;

namespace FirstConsoleApp
{
    public class PersonHelper
    {
        public (double average, int studentCount, bool belowAverage) 
            GetAverageAndCount(int[] scores, int threshold)
        {
            var result = (average:0D, studentCount:0, belowAverage:true);
            result = (((double)scores.Sum()/scores.Length), scores.Length, result.average.CheckIfBelowAverage(threshold));

            return result;
        }


        public void PrintData(object person)
        {
            switch (person)
            {
                case Student _:
                    var studentObject = (Student) person;
                    WriteLine($"\nStudent {studentObject.Name} {studentObject.LastName} is enrolled for courses {string.Join<int>(", ", studentObject.CourseCodes)}");
                    break;
                case Professor _:
                    var professorObject = (Professor)person;
                    WriteLine($"\nProfessor {professorObject.Name} {professorObject.LastName} teaches {string.Join<string>(", ", professorObject.TeachesSubject)}");
                    break;
            }
        }

    }

}

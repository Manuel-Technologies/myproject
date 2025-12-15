using System;

using System.Linq;

using System.Collections.Generic;
using Learn;



namespace Learn;



public class JaggedArrays
{
    public static void Main()
    {

        /*int[][] jaggedArrays = new int[3][];
        jaggedArrays[0] = new int[] { 2, 5, 7, 8 };
        jaggedArrays[1] = new int[] { 3, 6, 7, 8, 10, 1 };
        jaggedArrays[2] = new int[] { 5, 10, 45, 67 };

        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                Console.WriteLine($"{jaggedArrays[i][j]}   ");

            }
        }

        */

        int[] agesOfStudents = { 18, 14, 16, 13, 15, 17, 18, 16 };
        int sumOfAges = 0;

        // traverse the arrays 

        for (int i = 0; i < agesOfStudents.Length; i++)
        {
            Console.WriteLine(agesOfStudents[i]);
            sumOfAges += i;
        }
        // to find the sum of the ages 

        foreach (var item in agesOfStudents)
        {
            sumOfAges += item;


        }
        Console.WriteLine("--------");
        Console.WriteLine(sumOfAges);

        //to find the average 



    }

}


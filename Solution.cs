using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        Int64 resultMax, resultMin;
        Int64 countMax = 0, countMin = 0;
        int checkMax = 0, checkMin = 0;

        for(int i=1; i<5; i++)
        {
            countMax += arr[i];
            countMin += arr[i];
        }

        resultMax = countMax;
        resultMin = countMin;

        for(int i=0; i<5; i++)
        {
            countMax = 0;
            countMin = 0;
            for(int j=0; j<5; j++)
            {
                if(j == i)
                {

                }
                else
                {
                    countMax += arr[j];
                    countMin += arr[j];
                }
            }
            
            
            if(countMax > resultMax)
            {
                resultMax = countMax;
                checkMax = i;
            }
            else
            {

            }

            if(countMin < resultMin)
            {
                resultMin = countMin;
                checkMin = i;
            }
            else
            {

            }
                
        }

        Console.WriteLine(resultMin.ToString() + " " + resultMax.ToString());
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>();

        Console.WriteLine("Masukkan 5 angka:\n");

        for(int i=0; i<5; i++)
        {
            Console.WriteLine("Angka Ke-"+ (i+1).ToString()+":");
            arr.Add(int.Parse(Console.ReadLine()));
        }

        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

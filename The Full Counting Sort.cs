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
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
         int n = arr.Count;
    StringBuilder[] sorted = new StringBuilder[n];
    
    
    for (int i = 0; i < n; i++)
    {
        sorted[i] = new StringBuilder();
    }
    
    
    for (int i = 0; i < n / 2; i++)
    {
        int index = int.Parse(arr[i][0]);
        sorted[index].Append("- ");
    }
    
    
    for (int i = n / 2; i < n; i++)
    {
        int index = int.Parse(arr[i][0]);
        sorted[index].Append(arr[i][1] + " ");
    }
    
    
    StringBuilder result = new StringBuilder();
    for (int i = 0; i < n; i++)
    {
        if (sorted[i].Length > 0)
        {
            result.Append(sorted[i].ToString());
        }
    }
    
    Console.WriteLine(result.ToString().Trim());
}

    }

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}

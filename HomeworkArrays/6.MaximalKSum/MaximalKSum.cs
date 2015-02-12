//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Please enter how numbers the Array will be: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter how many elements to be calculated: ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int sum = 0;
        int m = array.Max();
        int p = Array.IndexOf(array, m);


        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        var bestSubsequence = FindSubsetWithMaxSum(array, K);
        Console.WriteLine("Array's elements: {0} ", string.Join(", ", array));
        Console.WriteLine("Subsequence with {0} element(s)", bestSubsequence.Count);
        Console.WriteLine("Maximal Sum = {0}", bestSubsequence.Sum());
        Console.WriteLine("Subset with Maximal Sum: {0}", string.Join(", ", bestSubsequence));
    }

    private static List<int> FindSubsetWithMaxSum(int[] nums, int k)
    {
        List<int> subsetWithMaxSum = new List<int>();
        Array.Sort(nums);

        for (int i = nums.Length - 1; i >= 0 && k != 0; i--, k--)
        {
            subsetWithMaxSum.Add(nums[i]);
        }
        return subsetWithMaxSum;
    }
}
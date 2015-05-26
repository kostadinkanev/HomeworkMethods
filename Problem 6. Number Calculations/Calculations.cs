using System;
using System.Collections.Generic;
using System.ComponentModel;

class Calculations
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] help = n.Split(' ');
        double[] nums = new double[help.Length];
        for (int i = 0; i < help.Length; i++)
        {
            nums[i] = double.Parse(help[i]);

        }


        CalculationsAll(nums);
    }

    static void CalculationsAll(double[] nums)
    {
        double sum = 0;
        double pro = 1;
        double min = Double.MaxValue;
        double max = Double.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            pro *= nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= max)
            {
                max = nums[i];
            }
            if (nums[i]<=min)
            {
                min = nums[i];
            }
        }
        double avg = sum/(nums.Length);
        Console.WriteLine("min: {0}, max: {1}, avg: {2}, sum: {3}, product: {4} ",min,max,avg,sum,pro);

    }
}


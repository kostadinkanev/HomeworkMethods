using System;

class Reverse
{
    static void Main()
    {
        double num = 235;
        Console.WriteLine(ReverseNum(num));
    }

    static double ReverseNum(double n)
    {
        string help = n.ToString();
        char[] nums = help.ToCharArray();

        string sec=null;
        int k = 0;
        double result;
        for (int i = nums.Length-1; i >= 0; i--)
        {
            sec += nums[i];
            
        }


        result = (double.Parse(sec));
        return result;
    }
}


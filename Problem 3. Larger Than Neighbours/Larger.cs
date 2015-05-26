using System;

class Larger
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(LargerThan(numbers, i));
        }
    }

    private static bool LargerThan(int[] number, int i)
    {
        bool isLarger = false;
        if (i < (number.Length - 1) && i > 0)
        {
            if ((number[i] > number[i + 1]) && (number[i] > number[i - 1]))
            {
                isLarger = true;
            }
        }
        else
        {
           if (i == (number.Length - 1))
            {
                if (number[number.Length - 1] > number[number.Length - 2])
                {
                    isLarger = true;
                }
            }
            else
            {
                if (number[0] > number[1])
                {
                    isLarger = true;
                }
            }
        }
        return isLarger;
    }
}


using System;

class FirstLargerThanN
{
    static void Main()
    {
        int[] s = {1,1,1};
        Console.WriteLine(FirstLarge(s));
    }

    static int FirstLarge(int[] seq)
    {
        int k = -1;
        for (int i = 0; i <  seq.Length; i++)
        {
            
            if (LargerThan(seq, i))
            {
                k = seq[i];
                break;
            }

        }
        return k;
    }


    private static bool LargerThan(int[] number, int i)
    {
        bool isLarger = false;

        if (number[0] > number[1])
        {
            isLarger = true;
        }


        if (i < (number.Length - 1) && i > 0)
        {


            if ((number[i] > number[i + 1]) && (number[i] > number[i - 1]))
            {
                isLarger = true;
            }


        }
        if (i == (number.Length - 1))
        {
            if (number[number.Length - 1] > number[number.Length - 2])
            {
                isLarger = true;
            }
        }

        return isLarger;
    }

}

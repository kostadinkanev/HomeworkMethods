using System;
class LastDigit
{
    static void Main()
    
    {
        Console.WriteLine(LastDigitToWord(1027));
    }

    static string LastDigitToWord(int n)
    {
        int last = n % 10;
        string result = null;
        switch (last)
        {
            case 0:
                result = "zero";
                break;
            case 1:
                result = "one";
                break;
            case 2:
                result = "two";
                break;
            case 3:
                result = "three";
                break;
            case 4:
                result = "four";
                break;
            case 5:
                result = "five";
                break;
            case 6:
                result = "six";
                break;
            case 7:
                result = "seven";
                break;
            case 8:
                result = "eight";
                break;
            case 9:
                result = "nine";
                break;
        }
        return result;
    }
}

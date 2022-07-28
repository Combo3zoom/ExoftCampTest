using System.Linq;
using System.Runtime.InteropServices;

namespace ExoftCamp.LINQ;

public static class TaskLINQ
{
    public static int CountTheDigit(int count, int digit)
    {
        var squareAllNumbers = Enumerable.Range(0, count+1).Select(number=>number*number).ToList();
        
        var numberContainsDigit = squareAllNumbers.Where(number =>
        {
            while (number != 0)
            {
                if (number % 10 == digit)
                    return true;
                number /= 10;
            }
            return false;
        }).ToList();
        numberContainsDigit.Select(number =>
        {
            return 0;
        }).ToList();
        return numberContainsDigit.Count;
    }

    public static void ReduceButGrow(int[] numbers)
    {
        int multiplicationNumber = 1;
        numbers.Select(number =>
        {
            multiplicationNumber *= number;
            return 0;
        }).ToList();
    }

    public static int SquareSum(List<int> numbers)
    {
        var sum = 0;
        numbers.Select(number =>
        {
            sum += number * number;
            return 0;
        }).ToList();
        return sum;
    }

    public static string ReverseRotate(string value, int chunk)
    {
        if (chunk <= 0 || value == "" || chunk >= value.Length)
            return "";
        var splitChars  = value.Chunk(chunk).ToList();
        var t = int.Parse(splitChars[0][0].ToString());
        var resultConcatChars = new List<char>();
        foreach (var chars in splitChars)
        {
            if(chars.Length!=chunk)
                continue;
            resultConcatChars = resultConcatChars.Concat(CalculateReverseAndRotate(chars)).ToList();
        }
        var resultstr = "";
        resultConcatChars.Select(symbol =>
        {
            resultstr += symbol;
            return 0;
        }).ToList();
        return resultstr;

    }

    private static double CubeSum(char[] chars)
    {
        return chars.Select(number => number - '0')
            .Select(number => Math.Pow(number, 3)).Sum();
    }

    private static List<char> CalculateReverseAndRotate(char[] firstSplitChars)
    {
        if (CubeSum(firstSplitChars) % 2 == 0)
        {
            return firstSplitChars.Reverse().ToList();
        }
        //LINQ?
        var firstChar = firstSplitChars[0];
        for (int i = 0; i < firstSplitChars.Length-1 ; i++)
        {
            firstSplitChars[i] = firstSplitChars[i+1];
        }
        firstSplitChars[firstSplitChars.Length - 1] = firstChar;
            
        return new List<char>(firstSplitChars);
    }

    public static long SumOfOddNumbers(long row)
    {
        List<List<int>> triangleArray = new List<List<int>>();
        int currentNumber = 1;
        for (int i = 0; i < row; i++)
        {
            triangleArray.Add(new List<int>());
            for (int j = 0; j < row; j++)
            {
                if (j <= i )
                {
                    triangleArray[i].Add(currentNumber);
                    currentNumber += 2;
                }
                else
                    triangleArray[i].Add(0);
            }
        }

        return triangleArray[(int) (row-1)].Sum();
    }
}


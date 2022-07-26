using System.Linq;

namespace ExoftCamp.LINQ;

public static class TaskLINQ
{
    public static void CountTheDigit(int count, int digit)
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
        Console.Write($"We are using the digit {digit} in: ");
        numberContainsDigit.Select(number =>
        {
            Console.Write($"{number}, ");
            return 0;
        }).ToList();
        Console.WriteLine($"The total count is then {numberContainsDigit.Count()}");
    }

    public static void ReduceButGrow(List<int> numbers)
    {
        int multiplicationNumber = 1;
        var index = 0;
        numbers.Select(number =>
        {
            multiplicationNumber *= number;
            index += 1;
            if(index != numbers.Count)
                Console.Write($"{number} * ");
            else
                Console.Write(number);
            
            return 0;
        }).ToList();
        Console.WriteLine($" = {multiplicationNumber}");
    }

    public static void SquareSum(List<int> numbers)
    {
        var sum = 0;
        numbers.Select(number =>
        {
            sum += number * number;
            return 0;
        }).ToList();
        Console.WriteLine($"sum = {sum}");
    }
}
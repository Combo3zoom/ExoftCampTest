using ExoftCamp.LINQ;
using System;
using NUnit.Framework;
Console.WriteLine("============Task_1============");
Console.WriteLine(TaskLINQ.CountTheDigit(5750,0));


Console.WriteLine("============Task_2============");
TaskLINQ.ReduceButGrow(new int[]{1,2,3,4});

Console.WriteLine("============Task_3============");
TaskLINQ.SquareSum(new List<int>(){1,2,2});
Console.WriteLine("============Task_4============");
var resultReverseRotate = TaskLINQ.ReverseRotate("733049910872815764", 5);
resultReverseRotate.Select(symbol =>
{
    Console.Write(symbol);
    return 0;
}).ToList();
Console.WriteLine("\n============Task_5============");
Console.WriteLine(TaskLINQ.SumOfOddNumbers(2));
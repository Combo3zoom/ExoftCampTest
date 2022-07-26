using ExoftCamp.LINQ;
Console.WriteLine("============Task_1============");
TaskLINQ.CountTheDigit(10,1);

Console.WriteLine("============Task_2============");
TaskLINQ.ReduceButGrow(new List<int>(){1,2,3,4});

Console.WriteLine("============Task_3============");
TaskLINQ.SquareSum(new List<int>(){1,2,2});
Console.WriteLine("============Task_4============");
var resultReverseRotate = TaskLINQ.ReverseRotate("123456987653", 6);
resultReverseRotate.Select(symbol =>
{
    Console.Write(symbol);
    return 0;
}).ToList();
Console.WriteLine("============Task_5============");
Console.WriteLine(TaskLINQ.SumOfOddNumbers(2));
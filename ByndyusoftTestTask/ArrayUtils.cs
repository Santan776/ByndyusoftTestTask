namespace ByndyusoftTestTask;

using System;

public static class ArrayUtils
{
    public static int SumOfTwoSmallest(int[] numbers)
    {
        if (numbers == null || numbers.Length < 2)
        {
            throw new ArgumentException("Массив должен содержать как минимум 2 элемента");
        }

        var smallest = int.MaxValue;
        var secondSmallest = int.MaxValue;

        foreach (var number in numbers)
        {
            if (number < smallest)
            {
                secondSmallest = smallest;
                smallest = number;
            }
            else if (number < secondSmallest)
            {
                secondSmallest = number;
            }
        }

        return smallest + secondSmallest;
    }
}
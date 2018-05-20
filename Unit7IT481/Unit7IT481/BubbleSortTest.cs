using System;

public class BubbleSortTest
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[500];
        BubbleSortTrial obj = new BubbleSortTrial();

        obj.ReadFromFile(numbers);

        Console.Write("Unsorted: ");




        obj.DisplayArray(numbers);



        obj.BubbleSortArray(numbers);

        Console.Write("Sorted: ");

        obj.DisplayArray(numbers);

        Console.ReadLine();
    }
}
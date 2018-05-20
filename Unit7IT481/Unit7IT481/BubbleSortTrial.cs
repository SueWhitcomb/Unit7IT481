using System;
using System.IO;


public class BubbleSortTrial
{          


    public BubbleSortTrial()
    {
    }
    public void ReadFromFile(int[] numbers)
    {
        string path = "c:\\users\\sue\\source\\repos\\Unit7IT481\\Unit7IT481\\numbers.txt";
        StreamReader sr = new StreamReader(path);

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = Convert.ToInt32(sr.ReadLine());

        }
        sr.Close();
    }
    public void BubbleSortArray(int[] numbers)
    {
        bool swap;
        int temp;

        do
        {
            swap = false;
            for (int index = 0; index < (numbers.Length - 1); index++)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    temp = numbers[index];
                    numbers[index] = numbers[index + 1];
                    numbers[index + 1] = temp;
                    swap = true;

                }
            }
        } while (swap == true);

    }

    public void DisplayArray(int[] numbers)
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write("{0}", numbers[index]);
        }
    }
}


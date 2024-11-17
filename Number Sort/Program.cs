using System;

class Program
{
    static void Main()
    {
        int[] numbers = GenerateRandomNumbers(10);
        Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));

        int[] selectionSorted = (int[])numbers.Clone();
        SelectionSort(selectionSorted);
        Console.WriteLine("Selection Sorted: " + string.Join(", ", selectionSorted));

        int[] insertionSorted = (int[])numbers.Clone();
        InsertionSort(insertionSorted);
        Console.WriteLine("Insertion Sorted: " + string.Join(", ", insertionSorted));

        int[] bubbleSorted = (int[])numbers.Clone();
        BubbleSort(bubbleSorted);
        Console.WriteLine("Bubble Sorted: " + string.Join(", ", bubbleSorted));
    }

    static int[] GenerateRandomNumbers(int count)
    {
        Random rand = new Random();
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = rand.Next(1, 101); // Generate random numbers between 1 and 100
        }
        return numbers;
    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

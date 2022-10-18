using System;
class Sorting
{
    enum SortAlgorithmType
    {
        bubbleSort,
        insertionSort,
        selectionSort
    }   
    public static void Main()
    {
        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        int[] arr2 = { 64, 34, 25, 12, 22, 11, 90 };
        int[] arr3 = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Sorted array1");
        Sort(arr1, SortAlgorithmType.bubbleSort);
        printArray(arr1);

        Console.WriteLine("Sorted array2");
        Sort(arr2, SortAlgorithmType.insertionSort);
        printArray(arr2);

        Console.WriteLine("Sorted array3");
        Sort(arr3, SortAlgorithmType.selectionSort);
        printArray(arr3);        

        Console.ReadLine();      

    }
    static int[] bubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
        return arr;
    }

    static int[] insertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        return arr;
    }

    static int[] selectionSort(int[] arr)
    {
        int n = arr.Length;


        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
        return arr;
    }

    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static int[] Sort(int[] arrayToSort, SortAlgorithmType type)
    {
        switch (type)
        {
            case SortAlgorithmType.bubbleSort:
                return bubbleSort(arrayToSort);
                break;
            case SortAlgorithmType.selectionSort:
                return selectionSort(arrayToSort);
                break;
            case SortAlgorithmType.insertionSort:
                return insertionSort(arrayToSort);
                break;
           
        }     
        return null;
    }  
}
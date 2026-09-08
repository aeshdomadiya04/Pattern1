using System;

class Insert_element
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n + 1];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter position: ");
        int pos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter element: ");
        int value = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= pos; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[pos - 1] = value;

        Console.WriteLine("Array after insertion:");
        for (int i = 0; i <= n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
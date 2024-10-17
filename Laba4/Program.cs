using System;

class Program
{
    static void Main()
    {
        // Task 1
        Console.WriteLine("Task 1: Обчислення добутку елементів, кратних 5");

        int[] array = new int[9];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 51);
        }

        Console.WriteLine("Вихідний масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int product = 1;
        bool foundMultiplesOfFive = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 5 == 0 && array[i] != 0)
            {
                product *= array[i];
                foundMultiplesOfFive = true;
            }
        }

        if (foundMultiplesOfFive)
        {
            Console.WriteLine($"Добуток елементів, кратних 5, дорівнює: {product}");
        }
        else
        {
            Console.WriteLine("У масиві немає елементів, кратних 5.");
        }

        // Task 2
        Console.WriteLine("Task 2: Заміна мінімального та максимального елементів у масиві");

        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(-10, 21);
        }

        Console.WriteLine("\nВихідний масив:");
        PrintArray(arr);

        int minIndex = 0, maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < arr[minIndex])
                minIndex = i;
            if (arr[i] > arr[maxIndex])
                maxIndex = i;
        }

        int temp = arr[minIndex];
        arr[minIndex] = arr[maxIndex];
        arr[maxIndex] = temp;

        Console.WriteLine("\nОброблений масив:");
        PrintArray(arr);
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

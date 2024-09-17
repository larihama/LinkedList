using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        // Kopioidaan taulukon arvot listaan
        List<int> numberList = new List<int>(numbers);

        numberList.Sort();

        LinkedList<int> linkedList = new LinkedList<int>();

        foreach (int number in numberList)
        {
            linkedList.AddLast(number);
        }

        Console.WriteLine("10 random integers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nList in ascending order:");
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nLinkedList:");
        foreach (int number in linkedList)
        {
            Console.WriteLine(number);
        }
    }
}

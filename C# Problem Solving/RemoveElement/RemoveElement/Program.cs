using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int elementToRemove = 3;
        numbers = RemoveElement(numbers, elementToRemove);
        Console.WriteLine(string.Join(", ", numbers));
    }
    static int[] RemoveElement(int[] array, int element)
    {
        return array.Where(e => e != element).ToArray();
    }
}
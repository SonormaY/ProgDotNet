// 7. Створіть програму, яка знаходить найбільший елемент у масиві. 

using System;


static int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

System.Console.WriteLine("Enter array of numbers separated by space: ");
var input = Console.ReadLine();
if(string.IsNullOrEmpty(input))
{
    Console.WriteLine("Array is empty");
    return;
}
if(input[input.Length - 1] == ' ')
{
    input = input.Remove(input.Length - 1);
}
var arr = input.Split(' ');
int[] arrInt = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    arrInt[i] = int.Parse(arr[i]);
}
Console.WriteLine(FindMax(arrInt));
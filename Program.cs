// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/* 
int [] CreatNewArray (int size, int minVal, int maxVal)
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minVal, maxVal);
    }
    return array;
}

void ShowArray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

int CountEvenElement (int [] array)
{
    int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count += 1;
            }
        }
        return count;
}

Console.Write("Input count of alements of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int min = 100;
int max = 1000;

int [] newArray = CreatNewArray (size, min, max);
ShowArray (newArray);

int count_newArray = CountEvenElement (newArray);
Console.Write($"The number of even numbers in the array is: {count_newArray}.");
 */

// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2
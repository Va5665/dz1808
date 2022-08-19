// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите ряд чисел, разделенных запятой : ");
string seriesOfNumbers = Console.ReadLine();
string[] result = seriesOfNumbers.Split(", ");
void PrintArry<T>(T[] x)
{
    int count = x.Length;
    Console.Write("[");
    for (int index = 0; index < count; index++)
    {

        Console.Write(x[index]);
        if (index < x.Length - 1)
          Console.Write(", ");
    }
    Console.Write("]");

}
 
PrintArry(result);
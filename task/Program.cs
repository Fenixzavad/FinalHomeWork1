// Написать программу, которая из имеющегося массива строк, формирует массив строк
// длина которых меньше либо равна 3 символам.


string[] array1 = new string[5] {"123", "911", "hello", "world", "GB"};
string[] array2 = new string[array1.Length];
int count = 0;

void SortingArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
System.Console.WriteLine("Элементы массива менее либо с 3 символами: ");
SortingArray(array1, array2);
PrintArray(array2);

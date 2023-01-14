// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine()!);
    arrayStrings[i] = element;
}

string[] array2 = new string[size];
int len = 3;
int j = 0;

for (int i = 0; i < size; i++)
{
    if (arrayStrings[i].Length <= len)
    {
        array2[j] = arrayStrings[i];
        j++;
    }
}

Console.WriteLine();
PrintArray(array2);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
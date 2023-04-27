// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество элементов массива");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите поочередно значение каждого элемента");
string[] strings = UserArray(N);
PrintStringArray(strings);
Console.WriteLine("Элементы с длиной меньше или равной 3:");
string[] shotElements = ShortElements(strings);
PrintStringArray(shotElements);

string[] UserArray(int num)
{
    int i = 0;
    string[] arrayString = new string[N];
    while (i < num)
    {
        arrayString[i] = Console.ReadLine();
        i++;
    }
    return arrayString;
}

string[] ShortElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] resultArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[k] = array[i];
            k++;
        }
    }
    return resultArray;
}

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

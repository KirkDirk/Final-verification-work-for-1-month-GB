// Код для выборки из массива строк элементов, 
// количество символов которых меньше или равно трём

void PrintArray(string[] array)
{
    Console.Clear();
    Console.WriteLine("Заданный массив строк:");
    for (int i = 0; i < array.GetLength(0); i++)
        Console.WriteLine($"{i}-й элемент: {array[i]}");
}

Console.Clear();
// Задаем размер и исходный массив строк через запрос в консоли и выводим его
Console.WriteLine("Введите размер массива строк - целое положительное число:");
int startLength = Convert.ToInt32(Console.ReadLine());
string[] array0 = new string[startLength];
int i = 0;
while (i < startLength)
{
    Console.WriteLine($"Введите элемент {i}-й массива - строку:");
    array0[i] = Console.ReadLine();
    i++;
}
PrintArray(array0);


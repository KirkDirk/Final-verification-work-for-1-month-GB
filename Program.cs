// Код для выборки из массива строк элементов, 
// количество символов которых меньше или равно трём

// Метод для печати массива
void PrintArray(string[] array, string name)
{
    Console.WriteLine($"{name} массив строк:");
    for (int i = 0; i < array.GetLength(0); i++)
        Console.WriteLine($"{i}-й элемент: {array[i]}");
}

Console.Clear();
// Задаем размер и исходный массив строк через запрос в консоли и выводим его
Console.WriteLine("Введите размер массива строк - целое положительное число:");
int startLength = Convert.ToInt32(Console.ReadLine());
string[] array0 = new string[startLength];
int x = 0;
while (x < startLength)
{
    Console.WriteLine($"Введите элемент {x}-й массива - строку:");
    array0[x] = Console.ReadLine();
    x++;
}
Console.Clear();
PrintArray(array0, "Заданный");

//Проверяем длину значений массива 
// и записываем значения во второй массив длиной не больше 4 символов 
// или оставляем Emty, если элемент длиннее. Подсчитываем количество 
// ненулевых элементов. Печатаем промежуточный массив
string[] array1 = new string[startLength];
int numberShort = startLength;
for (int i = 0; i < startLength; i++)
{
    if (array0[i].Length < 4) array1[i] = array0[i];
    else
    {
        array1[i] = string.Empty;
        numberShort--;
    }
}
//PrintArray(array1, "Промежуточный");

// Cоздаем третий массив соответствующего размера. 
// Заполняем третий массив ненулевыми значениями 
// из второго массива. Выводим результат
string[] array2 = new string[numberShort];
int y = 0;
for (int i = 0; i < startLength; i++)
{
    if (array1[i] != string.Empty)
    {
        array2[y] = array1[i];
        y++;
    }
}
PrintArray(array2, "Итоговый");
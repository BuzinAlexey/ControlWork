// Длина массива и элементы массива задаются пользователем с клавиатуры
// Производится вывод созданного и вновь сформированного массива на экран

//Создать массив n - элементов
int n;
Console.Write("Введите количество элементов массива: ");
if (!int.TryParse(Console.ReadLine(), out n) || n<0)
{
Console.WriteLine("Введите верное значение длины массива ");
return;
}
string[] array = new string[n];
//Ввод элементов массива с клавиатуры 
EnterArray(array);
Console.WriteLine("Созданный массив: ");
//вывод массива
PrintArr(array);
Console.WriteLine("Массив после выборки: ");
ChangeArr(array);

//Функция ввода массива с клавиатуры
void EnterArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите 'элемент массива {i+1}:\t ");
        arr[i] =Console.ReadLine();
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}" + "|");
    }
    Console.WriteLine();
}
void ChangeArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3)
        Console.Write($"{arr[i]}" + "|");
    }
    Console.WriteLine();
}




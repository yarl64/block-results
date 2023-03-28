// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размерность массива"); // просим задать размерность метод первоначального массива
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToString(Console.ReadLine()); // заполняем массив данными пользователя
}
Console.WriteLine();
PrintArray(array); // выводим на экран первоначальный массив
Console.WriteLine();
PrintArray(New3SimbolsArray(array)); // выводим на экран новый массив

void PrintArray(string[] array) // Метод вывода массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

string[] New3SimbolsArray(string[] array)  // Метод для выявления элементов массива меньше 4 знаков и вормирование нового массива
{
    string[] newarray = new string[array.Length];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[n] = array[i];
            n++;
        }
    }
    return newarray;
}


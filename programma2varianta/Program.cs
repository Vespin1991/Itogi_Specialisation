// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] massiv = new string[] {"Tom", "alfa", "GeekBrains", "is", "qwerty", "VIP", "Per", "1234", "s", "Vadim", "one", ":)"};
Console.Write("[ ");
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length < 4)
    {
        Console.Write($"{massiv[i]} ");
    }
}
Console.WriteLine("]");

// string[] massiv = new string[7]; 

// for (int i = 0; i < massiv.Length; i++)
// {
//     Console.Write("Введите значение :  ");
//     massiv[i] = Console.ReadLine();
// }
// Console.Write("Первоначальный массив : [ ");
// for (int i = 0; i < massiv.Length; i++ )
// {
//      Console.Write($"{massiv[i]}  ");
// }
// Console.Write("]");
// Console.WriteLine();
// Console.Write("Новый массив : [ ");
// for (int i = 0; i < massiv.Length; i++ )
// {
//     if (massiv[i].Length < 4)
//     {
//         Console.Write($"{massiv[i]}  ");
//     }
// }
// Console.Write("]");
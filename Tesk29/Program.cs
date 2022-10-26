// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите колличество массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArrey = new int[elementsCount]; ;

for (int i = 0; i < myArrey.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    myArrey[i] = int.Parse(Console.ReadLine());
}
Console.Write("Вывод массива: ");

for (int i = 0; i < myArrey.Length; i++)
{
    Console.Write(myArrey[i]);
}



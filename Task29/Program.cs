/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Вводит пользователь размер массива
Массив можно заполнить рандомно в диапазоне значений, которые установит пользователь
*/

void MassPrint (int massize, int masmin, int masmax)
{
    if (masmin>masmax) 
    Console.WriteLine("Error! minimum MORE than maximum!"); // обработка ошибки, когда минимум больше максимума
    else
    {
    int [] massp = new int [massize];
    Console.Write("[");  // открытие формата строки вывода
    for (int i = 0; i < massize-1; i++) 
    {
        massp[i] = new Random().Next(masmin, masmax);
        Console.Write($"{massp[i]}, ");
    }
    massp[massize-1] = new Random().Next(masmin, masmax); 
    Console.Write($"{massp[massize-1]}"); // вывод последнего элемента массива. отдельно, что бы не ставить в конце запятую
    Console.Write("]"); // закрытие формата строки вывода
    }
}
Console.WriteLine("Enter the array size");  // запрос данных от пользователя
int mymassize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the minimum of array ");
int mymasmin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the maximum of array ");
int mymasmax = Convert.ToInt32(Console.ReadLine());
MassPrint(mymassize, mymasmin,mymasmax); // вызов метода 
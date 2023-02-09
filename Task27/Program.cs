// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumSum (int number)
{
int digits = 0; // кол-во цифр в числе
int number1 = number;
int res = 0; 
while (number1 > 0)  // вычисление длины числа
{
  digits++;
  number1 = number1/10;
}
int [] num = new int[digits] ; // определение массива
for (int j=0; j<digits; j++)
{
    num[j] = number/Convert.ToInt32(Math.Pow(10,digits-j-1))%10;  // заполнение массива цифрами числа 
    res = res + num[j];               // в этом же цике считаем сумму цифр числа
}
return res;
}
Console.WriteLine("Input your number");
int mynum = Convert.ToInt32(Console.ReadLine());  // ввод пользователя
Console.WriteLine($"The summ of all digits in number is {NumSum(mynum)}");   //вывод результата
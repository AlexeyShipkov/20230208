//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow не использовать
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int St(int a, int b)
{
    int res = 1; 
    for (int i=0; i < b; i++)
    
        res = res * a;
            
            return res;
}
Console.WriteLine("Input 2 digits");
int aa = Convert.ToInt32(Console.ReadLine());
int bb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{aa} in degree {bb} is  {St(aa,bb)}");
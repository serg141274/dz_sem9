/*Задача 64:Задайте значение N.Напишите программу которая выведет все 
натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.

void ShowNamber(int n)
{
if(n<=0)
{
    Console.WriteLine($"ненатуральное число");
}    
    Console.Write(n+" ");
    if (n>1)ShowNamber(n-1);
}
ShowNamber(-9);*/
///////////////////////////////////////////
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
/*
void SumNamb(int m, int n ,int sum)
{    
    if (m>n)
{
 Console.WriteLine($"Сумма натуральных элементов-> {sum} ");
        return ;
}
sum = sum + m++;
SumNamb(m,n,sum);
}
SumNamb(1,15,0);*/
////////////////////////////////////////////////////////
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunc(m,n);
void AkkermanFunc(int m,int n)
{
   Console.Write(Akkerman( m,n));  
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}*/
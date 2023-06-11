// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// int InputNumber()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// void NatureNumNToOne(int start, int end = 1)
// {
//      if (start == end)
//         Console.Write($"{start} ");
//     else
//     {
//         NatureNumNToOne(start, end + 1);
//         Console.Write($"{end} ");
//     }
// }
// Console.Write("Введите число M: ");
// int num1 = InputNumber();
// NatureNumNToOne(num1);







// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNumber()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// int SumNaturalNumbersInInterval(int start, int end)
// {
//     if (start == end)
//         return start;
//     else
//     {
//         return start + SumNaturalNumbersInInterval(start + 1, end);
//     }
// }
// Console.Write("Введите число M: ");
// int num1 = InputNumber();
// Console.Write("Введите число N: ");
// int num2 = InputNumber();
// if(num1 > num2) (num1, num2) = (num2, num1);
// Console.WriteLine(SumNaturalNumbersInInterval(num1, num2));;





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write("Введите число m: ");
int num1 = InputNumber();
Console.Write("Введите число n: ");
int num2 = InputNumber();
Console.WriteLine(Akkerman(num1, num2));
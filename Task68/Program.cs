// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FuncAckerman(int num, int arg)
{
    if (num == 0) return arg + 1;
    if (num != 0 && arg == 0) return FuncAckerman(num - 1, 1);
    else return FuncAckerman(num - 1, FuncAckerman(num, arg - 1));
}

bool IsNotNegativeNum(int num)
{
    return num >= 0;
}

Console.Write("Введите число функции: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите аргумент функции: ");
int n = Convert.ToInt32(Console.ReadLine());
if(IsNotNegativeNum(m) && IsNotNegativeNum(n))
{
    int result = FuncAckerman(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана с числом {m} и аргументом {n} -> {result}"); 
}
else Console.WriteLine("Введенно отрицательное число, вычисление произвести невозможно");
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        return secondNum + SumNumbers(firstNum, secondNum - 1);
    }
    else if (firstNum > secondNum)
    {
        return firstNum + SumNumbers(firstNum - 1, secondNum);
    }
    else
    {
        return firstNum;
    }
}

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(numberM, numberN);
Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN} -> {result}");

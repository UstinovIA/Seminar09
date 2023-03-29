// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        if (secondNum > 0) return secondNum + SumNaturalNumbers(firstNum, secondNum - 1);  //отрицательные числа не включаются в сумму
        else return 0;
    }
    else if (firstNum > secondNum)
    {
        if (firstNum > 0) return firstNum + SumNaturalNumbers(firstNum - 1, secondNum);
        else return 0;
    }
    else
    {
        if (firstNum > 0) return firstNum;
        else return 0;
    }
}


Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = SumNaturalNumbers(numberM, numberN);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberM} до {numberN} -> {result}");

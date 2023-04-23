// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int DigitsSum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum > 0 ? sum: -sum;
}

int number = ReadInt("Input a number");
int sum = DigitsSum(number);
System.Console.WriteLine($"The summ of digits in the number {number} is {sum}");
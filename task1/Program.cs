// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int baseNumberA, int pow)
{
    int result = 1;
    for(int i = 1; i <= pow; i++)
        result *= baseNumberA;
    return result;
    
}

int baseNumA = ReadInt("Input number A (base)");
int powNumB = ReadInt("Input number B (power)");
int result = Power(baseNumA, powNumB);
System.Console.WriteLine($"{baseNumA} raised to the power of {powNumB} is {result}.");

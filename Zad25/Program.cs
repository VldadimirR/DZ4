// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.3, 5 -> 243 (3⁵) 2, 4 -> 16

Console.WriteLine ($"Введите  число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Введите  число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

int NumberNaturalDegree(int numb)
{
    int i = 2;
    int sum = numberA;
    while ( i <= numberB)
{
    sum *= numberA;
    i++;
}
return sum;
}
Console.WriteLine($"Возведение числа {numberA} в степень числа {numberB} = {NumberNaturalDegree(numberA)} ");

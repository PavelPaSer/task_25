// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberStep = numberA;

for (int i = 1; i < numberB; i++)
{
numberStep = numberStep * numberA;
}
Console.WriteLine("A в степени B равно: " + numberStep);
// (№12) Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если первое число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.WriteLine ("Веведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Веведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine("Первое число Некратно второму. Остаток: " + numberA % numberB);
}
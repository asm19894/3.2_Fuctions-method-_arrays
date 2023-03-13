// (№16) Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5,25 -> да
// -4,16 -> да
// 25,5 -> да
// 8,9  -> нет

Console.WriteLine ("Веведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Веведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine("Первое число является квардратом второго");
} else if (numberB * numberB == numberA){
    Console.WriteLine("Второе число является квардратом первого");
} else {
    Console.WriteLine("Ни одно число не является квадратом другого");
}

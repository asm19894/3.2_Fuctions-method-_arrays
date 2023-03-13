// (№13): Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Веведите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
string numberAText = Convert.ToString(numberA);
if (numberAText.Length > 2)
{
  Console.WriteLine("третья цифра: " + numberAText[2]);
}
else 
{
  Console.WriteLine("Третья цифра отсутсвтует");
}
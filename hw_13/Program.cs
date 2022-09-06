// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите целое число: ");
int n = int.Parse(Console.ReadLine());

if (n > 99)
{
    Console.WriteLine("Вам третью цифру слева (L) или справа (R)?");
    // если поставить выше if, то при вводе n <= 99 спросит "Вам ... ?" и сообщит "Третьей ... нет"

    string side = Console.ReadLine(); // строковая переменная для букв (L) и (R)
    if (side.ToLower() == "r")
    {
        Console.WriteLine("Третья цифра числа справа - это " + (n / 100) % 10);
    }
    else if (side.ToLower() == "l")
    {
        String number = Convert.ToString(n); // конвертируем число в строку
        Console.WriteLine("Третья цифра числа слева - это " + number[2]);
    }
}
else
    Console.WriteLine("Третьей цифры в числе нет");
// Задача: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int randNumber = rand.Next(100, 1000);
System.Console.WriteLine(randNumber);

Console.Write($"{randNumber / 100}{randNumber % 10}"); // - если в дальнейшем не нужно использовать это число
// если потребуется использовать число, нужно его сохранить так:
// int newNumber = (randomNumber / 100) * 10 + randomNumber % 10;

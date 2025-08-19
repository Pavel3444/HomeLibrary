// Объявляем переменные
string? title;
string? author;
int year;
string? isbn;

 Console.Write("Введите название книги: ");
title = Console.ReadLine();

Console.Write("Введите автора книги: ");
author = Console.ReadLine();

Console.Write("Введите год издания: ");
year = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите ISBN: ");
isbn = Console.ReadLine();

 Console.WriteLine("\nИнформация о книге:");
Console.WriteLine($"Название: {title}");
Console.WriteLine($"Автор: {author}");
Console.WriteLine($"Год издания: {year}");
Console.WriteLine($"ISBN: {isbn}");

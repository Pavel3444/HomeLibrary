using HomeLibrary.Models;
namespace HomeLibrary.Services;

public static class BookInputService
{
    public static Book ReadBookFromConsole()
    {
        Console.Write("Введите название книги: ");
        var title = Console.ReadLine() ?? string.Empty;

        Console.Write("Введите автора книги: ");
        var author = Console.ReadLine() ?? string.Empty;

        Console.Write("Введите год издания: ");
        var year = GetValidYear();

        Console.Write("Введите ISBN: ");
        var isbn = Console.ReadLine() ?? string.Empty;

        return new Book(title, author, year, isbn);
    }
    private static int GetValidYear()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                return year;
            }
            Console.Write("Некорректный год. Попробуйте снова: ");
        }
    }
}

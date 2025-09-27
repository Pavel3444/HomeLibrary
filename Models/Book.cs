namespace HomeLibrary.Models;

public class Book(string title, string author, int year, string isbn)
{
    private string Title { get; } = title;
    private string Author { get; } = author;
    private string Isbn { get; } = isbn;
    private int Year { get; } = year;
    
    public override string ToString()
    {
        return $"""
                Информация о книге:
                Название: {Title}
                Автор: {Author}
                Год издания: {Year}
                ISBN: {Isbn}
                """;

    }
}
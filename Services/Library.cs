using HomeLibrary.Models;

namespace HomeLibrary.Services;

public class Library
{
    private readonly string[,] _books = new string[5, 4];
    private int _currentBookIndex;

    public void AddBook(Book book)
    {
        if (_currentBookIndex < _books.GetLength(0))
        {
            var bookData = book.ConvertBookForLibrary();
            for (var i = 0; i < bookData.Length; i++)
            {
                _books[_currentBookIndex, i] = bookData[i];
            }

            _currentBookIndex++;
        }
        else
        {
            Console.WriteLine("Library is full");
        }
    }

    public void ShowBooks()
    {
        for (var i = 0; i < _currentBookIndex; i++)
        {
            var title = _books[i, 0];
            var author = _books[i, 1];
            var isbn = _books[i, 2];
            var year = int.Parse(_books[i, 3]);
            var res = new Book(title, author, year, isbn).ToString();
            Console.WriteLine(res);
        }
    }

    public void FindBook(string param)
    {
        bool found = false;

        for (var i = 0; i < _currentBookIndex; i++)
        {
            if (IsBookMatch(i, param))
            {
                var title = _books[i, 0];
                var author = _books[i, 1];
                var isbn = _books[i, 2];
                var year = int.Parse(_books[i, 3]);
                var book = new Book(title, author, year, isbn);
                Console.WriteLine(book);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Книги не найдены");
        }
    }

    public void RemoveBook(string param)
    {
        bool found = false;

        for (var i = 0; i < _currentBookIndex; i++)
        {
            if (IsBookMatch(i, param))
            {
                for (var j = i; j < _currentBookIndex - 1; j++)
                {
                    for (var k = 0; k < 4; k++)
                    {
                        _books[j, k] = _books[j + 1, k];
                    }
                }

                for (var k = 0; k < 4; k++)
                {
                    _books[_currentBookIndex - 1, k] = null;
                }

                _currentBookIndex--;
                i--;
                found = true;
                Console.WriteLine("Книга удалена");
            }
        }

        if (!found)
        {
            Console.WriteLine("Книги не найдены для удаления");
        }
    }

    private bool IsBookMatch(int bookIndex, string param)
    {
        var title = _books[bookIndex, 0];
        var author = _books[bookIndex, 1];
        var isbn = _books[bookIndex, 2];
        var year = _books[bookIndex, 3];

         bool yearMatch = year.Equals(param, StringComparison.OrdinalIgnoreCase);

         bool titleMatch = title.Contains(param, StringComparison.OrdinalIgnoreCase);
        bool authorMatch = author.Contains(param, StringComparison.OrdinalIgnoreCase);
        bool isbnMatch = isbn.Contains(param, StringComparison.OrdinalIgnoreCase);

        return yearMatch || titleMatch || authorMatch || isbnMatch;
    }
}
using HomeLibrary.Models;

namespace HomeLibrary.Services;

public class BookStore
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
            var isbn =  _books[i, 2];
            var year = int.Parse(_books[i, 3]); 
            var res = new Book(title, author, year, isbn).ToString();
            Console.WriteLine(res);
        }
    }
    
}
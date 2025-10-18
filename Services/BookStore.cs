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
    
        public void FindBook(string param)
        {
             for (var i = 0; i < _currentBookIndex; i++)
            {
                var bookData = new string[4];
        
                 for (var j = 0; j < 4; j++)
                {
                    bookData[j] = _books[i, j];
                }
        
                if (bookData.Contains(param))
                {
                    var yearValue = int.Parse(bookData[3]);
                    var book = new Book(bookData[0], bookData[1], yearValue, bookData[2]);
                    Console.WriteLine(book);
                }
            }
        }
    
}
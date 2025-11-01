using HomeLibrary.Models;
using HomeLibrary.Services;

namespace HomeLibrary.Ui;

public class Menu(Library library)
{
    private readonly Library _library = library; 
    public void StartMenu()
    {
        var isRepeat = true;
        while (isRepeat)
        {
            var userInput = ShowMenu();
             isRepeat = GetUserInput(userInput);
        }
    }

    private static string ShowMenu()
    {
        Console.WriteLine("""
                          Menu:
                          [1] Добавить книгу
                          [2] Показать все книги
                          [3] Найти книгу
                          [4] Выйти
                          """);
        return Console.ReadLine() ?? string.Empty;
    }
    private bool GetUserInput(string input)
    {
        switch (input)
        {
            case "1":
                var newBook = BookInputService.ReadBookFromConsole();
                _library.AddBook(newBook);
                return true;
            case "2":
                _library.ShowBooks();
                return true;
            case "3":
                Console.WriteLine("Введите название книги, автора, год издания или ISBN");
                var title = Console.ReadLine();
                if(title == null)
                    Console.WriteLine("Not found");
                else
                    _library.FindBook(title);
                return true;
            case "4":
               Environment.Exit(0);
                return false;
            default:
                Console.WriteLine("ВВедена херня, попробуйте еще раз");
                return true;
        }
    }
}
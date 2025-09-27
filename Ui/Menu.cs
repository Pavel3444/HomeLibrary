namespace HomeLibrary.Ui;

public static class Menu
{
    public static void StartMenu()
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
                          [3] Выйти
                          """);
        return Console.ReadLine() ?? string.Empty;
    }
    private static bool GetUserInput(string input)
    {
        switch (input)
        {
            case "1":
                Console.WriteLine("тут в будущем перейдем к созданию новой книги");
                return false;
            case "2":
                Console.WriteLine("тут в будущем перейдем к показу списка книг");
                return false;
            case "3":
                Console.WriteLine("Тут выход");
                return false;
            default:
                Console.WriteLine("ВВедена херня, попробуйте еще раз");
                return true;
        }
    }
}
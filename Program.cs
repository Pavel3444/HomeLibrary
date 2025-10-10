using HomeLibrary.Services;
using HomeLibrary.Ui;

namespace HomeLibrary;

public class Program
{
 public static void Main()
 {
 var library = new BookStore(); 
 var menu = new Menu(library);
 menu.StartMenu();
 }
}
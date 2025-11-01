using HomeLibrary.Services;
using HomeLibrary.Ui;

namespace HomeLibrary;

public class Program
{
 public static void Main()
 {
 var library = new Library(); 
 var menu = new Menu(library);
 menu.StartMenu();
 }
}

public class Car
{
 public string Brand = "";
 public string Model = "";
 private decimal _capacity = 0;

 public Car()
 {
  
 }
 private Car(decimal capacity)
 {
  _capacity = capacity;
 }
 public Car(string brand, string model): this(11)
 {
  Brand = brand;
  Model = model;
  
 }
}
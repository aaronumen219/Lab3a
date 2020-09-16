using System;

class MainClass {
  public static void Main (string[] args) {
  
  Console.WriteLine ("Enter temperature in Celsius");
  double temperature = Convert.ToDouble(Console.ReadLine());

  double farenheit = Convert.ToDouble(((temperature * 9)/5) + 32);

  Console.WriteLine("Farenheit equivalent for " + temperature + " degree celsius is " + farenheit);

  if  (temperature < 0)
    {
  
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");

    }
    else if (temperature > 100)
    {
      Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");
    }
   




  }
}
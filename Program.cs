/*****************************************
* Выполнил: Земцев Данил Евгеньевич      *
* Название: 1.Возведение в степень       *
*           2.Вторая цифра в конец числа *
* Дата: 13.02.2023г.                     *
*****************************************/

using System;
namespace ConsoleApp { 
  
  class Program { 
    private static int choice;
    private static void Main(string[] args) { 
      while (true) { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Which program will you choose, traveler? (Power/SecondNum2End/Exit) 1/2/0");  //Выбор исполняемой программы (Отсылка на "кто ты, путник")
        int choice = int.Parse(Console.ReadLine()); //свич на выбор исполняемой программы  | 
        switch (choice) {
          case 1:
            Power();
            break;
        
          case 2:
            MoveSecondCharToEnd();
            break;
        
          case 0:
            Environment.Exit(0);
            break;
        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Do you wish to clear the console? (y/n)");
        string vote = Console.ReadLine();
        if (vote == "y") {
          Console.Clear();
        }

        Console.ForegroundColor = ConsoleColor.Green;
      }
    }
    
    private static void Power() { 

      Console.WriteLine("Program 1 selected");
      
      Console.WriteLine("Enter a real number (a):"); //ввод числа (а)
      int firstNumber = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the degree for the number (n >= 0):"); //ввод числа (n)
      int numOfPower = int.Parse(Console.ReadLine());
      
      if (numOfPower < 0) { 
        double output = 1;//  если степень < 0
        numOfPower = numOfPower * -1;
        
        for (int multiplicationCounter = 0; multiplicationCounter < numOfPower; ++multiplicationCounter) {
           output *= firstNumber;// Используем цикл для умножения result на a n раз 
        }
        
        output = 1 / output;
        Console.WriteLine($"1/a^n =({output})");
        Environment.Exit(0); //Досрочное прерывание программы
      }
      
      double result = 1; // Результат возведения a в степень n
      
      for (int multiplicationСounter = 0; multiplicationСounter < numOfPower; ++multiplicationСounter) {
        result *= firstNumber;// Используем цикл для умножения result на a n раз 
      }
      
      Console.WriteLine("a^n = " + result);
      Console.ReadKey();
    }
    
    private static void MoveSecondCharToEnd() { 
      Console.WriteLine("Enter a real number (x >= 100 ): ");
      string input = Console.ReadLine();
      
      if (input.Length > 2) { 
        string firstChar = input[0].ToString();
        string secondChar = input[1].ToString();
        string restOfString = input.Substring(2);
        
        Console.WriteLine("Converted number is: " + firstChar + restOfString + secondChar);
      }

      else {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error. The number (x) < 100.");
        Console.ForegroundColor = ConsoleColor.Green;

      }
    }
  }
}

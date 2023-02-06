using System;
using System.Reflection.Emit;

namespace ConsoleApp { 
  
  class Program {
    private static int choice;
    
    private static void Main(string[] args) {
      Console.WriteLine("Which program will you choose, traveler? (Power/SecondNum2End) 1/2"); //Выбор исполняемой программы (Отсылка на "кто ты, путник")
      
      int choice = int.Parse(Console.ReadLine()); //свич на выбор исполняемой программы
      switch (choice) {
        case 1:
          power();
          break;
        
        case 2:
          secondNum2End();
          break;
      }
    }
    
    private static void power() {
      Console.WriteLine("Program 1 selected");
      
      Console.WriteLine("Enter a real number (a):"); //ввод числа (а)
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the degree for the number (n >= 0):"); //ввод числа (n)
      int n = int.Parse(Console.ReadLine());
      
      if (n < 0) { // вкидон, если степень < 0
        double output = 1; 

        n = n * -1;

        for (int index = 0; index < n; ++index) {
          output *= a;// Используем цикл для умножения result на a n раз 
        }

        output = 1 / output;
        Console.WriteLine($"1/a^n =({output})");
        Environment.Exit(0); //Досрочное прерывание программы
      }
      double result = 1; // Результат возведения a в степень n
      
      for (int index = 0; index < n; ++index) {
        result *= a;// Используем цикл для умножения result на a n раз 
      }
      
      Console.WriteLine("a^n = " + result); //вывод числа
      Console.ReadKey();
    }
    private static void secondNum2End() {
      Console.WriteLine("Program 2 selected");

      Console.WriteLine("Enter a real number (x >= 100 ):"); //ввод целого числа (х)
      int x = int.Parse(Console.ReadLine()); //присвоение
      
      if (x < 100) { // защита от дурака (если ввел x меньше 100)
        Console.WriteLine("Error. The number (x) < 100.");
        Environment.Exit(0); //Досрочное прерывание программы
      }

      int workX = x; // рабочий х (чтобы найти второе число)
      do {
        workX = workX / 10; 
        
        if (workX < 100) {
          do {
              workX = workX - 10;
          }
          while (workX > 10);
        }
      }
      while (workX > 100);
      
      int n = int.Parse(x.ToString().Remove(1, 1) + workX); // Перестановка второй цифры в конец числа
      
      Console.WriteLine("Результат: " + n); // Вывод результат
    }
  }
}
/*        ^         
         | |        
       @#####@      
     (###   ###)-.  
   .(###     ###) \ 
  /  (###   ###)   )
 (=-  .@#####@|_--" 	This is a hold up! Give the whole group
 /\    \_|l|_/ (\     	positive ratings and no one gets hurt!
(=-\     |l|    /   
 \  \.___|l|___/    
 /\      |_|   /    
(=-\._________/\    
 \             /    
   \._________/     
     #  ----  #     
     #   __   #       
     \########/      

        V
            V
          V*/
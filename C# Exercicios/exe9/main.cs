using System;

class MainClass {
  public static void Main (string[] args) {
    int n=0, maior=0;
    Console.WriteLine("Determina o maior valor");
    Console.Write("informe o 1 valor: ");
    n = Convert.ToInt32(Console.ReadLine());
    maior = n;
    Console.Write("informe o 2 valor: ");
    n = Convert.ToInt32(Console.ReadLine());
    if(n> maior){
      maior = n;
    }
    Console.Write("informe o 3 valor: ");
    n = Convert.ToInt32(Console.ReadLine());
    if(n> maior){
      maior = n;
    }
        Console.Write("informe o 4 valor: ");
    n = Convert.ToInt32(Console.ReadLine());
    if(n> maior){
      maior = n;
    }
        Console.Write("informe o 5 valor: ");
    n = Convert.ToInt32(Console.ReadLine());
    if(n> maior){
      maior = n;
    }

  Console.WriteLine("O maior valor inserido é: " +maior);
  Console.ReadKey();
  }
}
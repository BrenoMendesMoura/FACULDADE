using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int n=0;

    Console.Write("Digite a quantidade de números a serem analisados: ");
		int[] numeros = new int[int.Parse(Console.ReadLine())];

		for(int i=0; i < numeros.Count(); i++)
		{
			Console.Write("Digite um número: ");
			numeros[i] = int.Parse(Console.ReadLine());

      if(0>numeros[i]){
      n = numeros[i]+n;
    }

		}

    Console.WriteLine("A soma dos números negativos é: " +n );


    }


  
}

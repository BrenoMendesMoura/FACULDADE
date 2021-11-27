using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int n=0, maior=0;

    Console.Write("Digite a quantidade de números a serem analisados: ");
		int[] numeros = new int[int.Parse(Console.ReadLine())];

		for(int i=0; i < numeros.Count(); i++)
		{
			Console.Write("Digite um número: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}
    Console.Write("\nNúmeros Positivos digitados => ");
		for(int i=0; i< numeros.Count(); i++)
		{
      if(0<numeros[i]){
      maior = numeros[i];
      Console.Write(maior+ " ");
      }
    }
  Console.Write("\nNúmeros Negativos digitados => ");
		for(int i=0; i< numeros.Count(); i++)
		{
      if(0>numeros[i]){
      n = numeros[i];
      Console.Write(n+ " ");
      
      }

    }

  }
}
using System; 

  class MainClass {//classe

		public static Int32 fatorial (Int32 num) {
			if (num == 1) { //condição
				return 1;
			}

			return num * fatorial (num - 1); //retorna o valor
		}

		public static void Main (string[] args) { //main, aonde irá executar o comando
    Console.Write ("\n\tFatorial!\n");
			Int32 num;
			String entrada;

			Console.Write ("\n\tDigite um número inteiro para calcularmos : ");//Write - escreva
			entrada = Console.ReadLine ();
			num = Convert.ToInt32 (entrada);

        Console.WriteLine("\n\tO fatorial do número informado " + num + " é: " + fatorial(num));//mostra o resultado da soma dos inteiros
		}
	
}
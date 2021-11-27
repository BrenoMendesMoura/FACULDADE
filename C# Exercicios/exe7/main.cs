using System;


  class MainClass {//classe
		static void Main(string[] args)
		{
			int multiplicando;

			Console.Write("\n\tDigite um Número:\t\n ");
      
			multiplicando = Convert.ToInt32(Console.ReadLine());
  Console.Write("\n\tos múltiplos do número informado são: \n");
			for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
			{
				Console.WriteLine(string.Format("\t{2}",
				multiplicando, multiplicador, multiplicando * multiplicador));
			}

			Console.Write("\nPressione alguma tecla!");
			Console.ReadKey();

		}

	
}
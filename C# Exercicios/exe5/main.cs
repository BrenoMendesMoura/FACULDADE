using System;


  class MainClass {//classe
		static void Main(string[] args)
		{
			int multiplicando;

			Console.Write("Digite o multiplicador: ");
			multiplicando = Convert.ToInt32(Console.ReadLine());

			for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
			{
				Console.WriteLine(string.Format("{0}\t*\t{1}\t=\t{2}",
				multiplicando, multiplicador, multiplicando * multiplicador));
			}

			Console.Write("\nPressione alguma tecla!");
			Console.ReadKey();

		}

	
}
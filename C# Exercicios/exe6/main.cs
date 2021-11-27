using System; //console

class MainClass { //class

  public static void Main (string[] args) {



   Console.WriteLine(string.Format("\n\tA equação proposta é : S=12 +  22 + 32 + ... + 102. \t\n"));

   Console.WriteLine("\nSua sequência completa: ");

   for (int b=12; b<=102; b+=10)

   Console.WriteLine(b);
   
 
    Console.WriteLine("\nA soma da equação realizada");
    
    int soma = 0;

    for (int i=12; i<=102; i+=10){
    
     Console.Write("Resultado: + ");

     Console.WriteLine(soma +=i);
    }
			Console.ReadKey();
  }
}
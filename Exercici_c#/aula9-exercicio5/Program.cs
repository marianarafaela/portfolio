using System;

namespace aula9_exercicio5
{
    class Program
    {
        static void Main(string[] args)
       {
            //Criar um método do tipo double onde retorna o valor total de um vetor de tamanho indeterminado.
            Console.Write("O valor total é: " + ValorTotal());
        }
        static double ValorTotal(){

            string sair = "";
            int total = 0;
            int numeros = 0;

            while(sair != "sim"){
                try{
                Console.Write("Digite um número: ");
                numeros = int.Parse(Console.ReadLine());

                total = total + numeros;

                Console.Write("Deseja sair da aplicação? sim/não ");  
                sair = Console.ReadLine().ToLower(); 
                }catch{
                System.Console.WriteLine("Ops...deu erro!");
                }
            } 
            return total;
        
           
        }
    }
}

using System;

namespace aula2_4
{
    class Program
    {
        static void Main(string[] args)
        {
           string pedido;
           string resultado;
           Console.WriteLine("Digite o número do seu pedido");
           pedido = Console.ReadLine();
        
          switch (pedido){
           case "1" :
           resultado ="hamburguer";
           break;
           case "2" :
           resultado ="cheese salada";
           break;
           case "3" :
           resultado ="cheese burguer";
           break;
           case "4" :
           resultado ="cheese bacon";
           break;
           default:
           resultado ="pedido invalido";
           break;
          }
          Console.WriteLine(resultado);
        }
    }
}

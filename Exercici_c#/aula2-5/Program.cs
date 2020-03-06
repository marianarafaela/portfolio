using System;

namespace aula2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string planeta;
            double resultado;
            double peso;
            Console.WriteLine("digite seu peso:");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("escolha um planeta:");
            Console.WriteLine("1-mercúrio");
            Console.WriteLine("2-vênus");
            Console.WriteLine("3-marte");
            Console.WriteLine("4-júpiter");
            Console.WriteLine("5-saturno");
            Console.WriteLine("6-urano");
            planeta=Console.ReadLine();
            switch(planeta){
                case "1":
                resultado=(peso/10)*0.37;
                Console.WriteLine(resultado);
                break;
                case "2":
                resultado=(peso/10)*0.8;
                Console.WriteLine( resultado );
                break;
                case "3":
                resultado=(peso/10)*.38;
                Console.WriteLine( resultado );
                break;
                case "4":
                resultado=(peso/10)*2.64;
                Console.WriteLine( resultado );
                break;
                case "5":
                resultado=(peso/10)*1.15;
                Console.WriteLine( resultado );
                break;
                case "6":
                resultado=(peso/10) *1.17;
                Console.WriteLine( resultado );
                break;
                default:
                Console.WriteLine("planeta invalido");
                break;
            }
               
            


        }
    }
}

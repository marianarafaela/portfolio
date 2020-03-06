using System;

namespace aula4_ec_xercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] nome = new string[12];
             string[] cor = new string[12];
             string[] tamanho = new string[12];
             double[] preco = new double[12];
        
            for( int i=0; i<=11; i++){
                Console.Write("digite o nome do produto:");
                nome[i]=Console.ReadLine();

                Console.Write("digite a cor:");
                cor[i]=Console.ReadLine();

                Console.Write("digite o tamanho:");
                tamanho[i]= Console.ReadLine();

                Console.Write("digite o preço:");
                preco[i]=double.Parse(Console.ReadLine());                                
            }
            for( int i=0; i<=11; i++){
                Console.WriteLine("nome do produto:"+ nome[i]);
                Console.WriteLine("cor do produto:"+ cor[i]);
                Console.WriteLine("tamanho do produto:"+ tamanho[i]);
                Console.WriteLine("preço do produto:"+ preco[i]);
            }
            
        }
    }
}

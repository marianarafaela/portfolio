using System;

namespace aula4_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
           float[] posicao = new float[10];
           float posicao2 ;
           for(int i =0; i<=9; i++){

               Console.Write("digite um número: ");
               posicao[i]=float.Parse(Console.ReadLine());
               
               Console.WriteLine(posicao[i]);
               posicao2= posicao[9] * 5;
               Console.WriteLine(posicao2);
           }
        }
    }
}

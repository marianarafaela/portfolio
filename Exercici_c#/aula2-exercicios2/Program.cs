using System;

namespace aula2_exercicios2
{
    class Program
    {
        static void Main(string[] args)
        { 
            float[] v1= new float[10];
            float[] v2= new float[10];
            float[] v3= new float[20];

            for(int i =0; i<=9; i++){
                Console.Write("digite um número:");
                v1[i]=float.Parse(Console.ReadLine());
               
            }
             for(int i =0; i<=9; i++){
                Console.Write("digite um número:");
                v2[i]=float.Parse(Console.ReadLine());
            }
            for(int i =0;i <=9; i ++){
                v3[i]=v1[i];
                v3[i+10]=v2[i];
                Console.WriteLine(v3[i]);
            }
            for(int i =0;i <=19; i ++){
                Console.WriteLine(v3[i]);
        

            }
         }
    }
}

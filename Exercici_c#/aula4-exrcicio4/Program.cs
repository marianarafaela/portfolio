using System;

namespace aula4_exrcicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] v1= new string[10];
            string[] v2= new string[10];
            string[] v3= new string[20];

            for(int i =0; i<=9; i++){
                Console.Write("digite uma palavra:");
                v1[i]=Console.ReadLine();
               
            }
             for(int i =0; i<=9; i++){
                Console.Write("digite uma palavra:");
                v2[i]=Console.ReadLine();
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

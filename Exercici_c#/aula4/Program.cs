using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media = new double[10];
                for(int i = 0; i <= 9; i++){
                    Console.Write("digite uma média");
                    media[i] = double.Parse(Console.ReadLine() );

                }
                Console.WriteLine(media[3]);
                Console.WriteLine();

                for(int i =0 ; i <=media.Length; i++){
                    Console.WriteLine("valores : " + media[1] );
                }    
                

        }
    }
}

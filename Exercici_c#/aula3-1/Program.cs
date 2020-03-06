using System;

namespace aula3_1
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont = 1;
           double numero;
           while(cont <=100){
               numero= cont;
               numero = Math.Pow (numero,3);
               cont=cont +1;
               Console.WriteLine(numero);
           }
            

        }
    }
}

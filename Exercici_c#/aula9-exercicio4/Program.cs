using System;

namespace aula9_exercicio4 {
    class Program {
        static void Main (string[] args) {

            // Criar um método do tipo double onde retorna o maior número de um vetor de tamanho indeterminado.
            Console.Write ("O maior número é: " + MaiorNum ());
        }
        static double MaiorNum () {

            int maior = 0;
            string sair = "";
            int numeros = 0;

            while (sair != "sim") {
                try {
                    Console.Write ("Digite um número: ");
                    numeros = int.Parse (Console.ReadLine ());

                    for (int i = 0; i <= numeros.ToString ().Length; i++) {

                        if (i == 0) {
                            maior = numeros;
                        }

                        if (numeros > maior) {
                            maior = numeros;
                        }
                    }
                    Console.Write ("Deseja sair da aplicação? sim/não ");
                    sair = Console.ReadLine ().ToLower ();
                } catch {
                    System.Console.WriteLine ("Ops...deu erro!");
                }
            }
            return maior;
        }
    }
}
using System;

namespace aula5_desafio {
    class Program {
       

        static void Main (string[] args) {
            string[] nome = new string[3];
            double[] preco = new double[3];
            string menu = "";

            while (menu != "0") {
                Console.WriteLine ("BEM VINDOS A HORTIFRUTI  ");
                Console.WriteLine (
                    @"
                Menu :
                1- cadastrar produto
                2- lista de produtos
                3-soma dos produtos");
                menu=Console.ReadLine();
                switch (menu) {
                    case "1":
                        for (int i = 0; i <= 2; i++) {
                            Console.Write ("Digite o nome do produto: ");
                            nome[i] = Console.ReadLine ();
                            Console.Write ("Digite o valor do produto: ");
                            preco[i] = double.Parse (Console.ReadLine ());
                            Console.WriteLine ("produtos com sucesso!");
                        }
                    break;
                    case "2":
                        for (int i = 0; i <= 2; i++) {
                            if (nome[i] != "") {
                                Console.WriteLine ("nome do seu produto" + nome[i]);
                            }

                        }
                        break;
                }

            }

        }

    }

}
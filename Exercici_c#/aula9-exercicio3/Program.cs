using System;

namespace aula9_exercicio3 {
    class Program {
        static void Main (string[] args) {
            try {
                Console.WriteLine (MostraInfo ());
                string nome, sobrenome;

                System.Console.Write ("Digite seu nome: ");
                nome = Console.ReadLine ();
                System.Console.Write ("Digite seu sobrenome: ");
                sobrenome = Console.ReadLine ();

                Console.WriteLine (MostraInfo (nome, sobrenome));

                int idade;
                double peso, altura;

                System.Console.WriteLine ("Digite sua idade: ");
                idade = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite seu peso: ");
                peso = double.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite sua altura: ");
                altura = double.Parse (Console.ReadLine ());

                Console.WriteLine (MostraInfo (idade, peso, altura));
            } catch {
                System.Console.WriteLine ("Ops...deu erro!");
            }
        }
        static string MostraInfo () {
            return "Servico Nacional de Aprendizagem Industrial - SENAI de Informática";
        }
        static string MostraInfo (string nome, string sobrenome) {
            return $"{nome} {sobrenome}";
        }
        static string MostraInfo (int idade, double peso, double altura) {
            return $"Idade: {idade}, Peso: {peso}, Altura: {altura}";
        }

    }
}
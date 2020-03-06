using System;

namespace aula9_exercicio2 {
    class Program {

        static void Main (string[] args) {
            imprimirDataHora ();
        }

        static void imprimirDataHora () {
            DateTime dia = DateTime.Today;
            Console.WriteLine (dia.DayOfWeek);
        }
    }
}
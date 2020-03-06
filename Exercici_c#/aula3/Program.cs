using System;

namespace aula3 {
    class Program {
        static void Main (string[] args) {

            //laço contado -for- incremento(+)
            // for (int cont = 0; cont <= 100; cont++) {

            //     //verificamos se o número é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 0-100" + cont);
            //     }
            // }
            // //laço contado -FOR- DECREMENTO()
            // for (int cont = 100; cont >= 0; cont--) {
            //     //verificamos se o número é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 100-0 - " + cont);
            //     }
            // }


            //LAÇO CONDICIONAL - WHILE
            double acum = 0;
            double nota  =0;
            int cont = 0;
            string sair = "";

            while (sair != "sair") {
                Console.WriteLine ("digite a nota do aluno: ");
                nota = double.Parse (Console.ReadLine ());

                acum += nota;
                cont++;

                Console.Write ("deseja sair da aplicação? sim/não ");
                sair= Console.ReadLine().ToLower();
            }
            Console.WriteLine(" média de nots :" +(acum / cont));
        }

    }
}
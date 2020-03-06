using System;

namespace aula6 {
    class Program {
        static void Main (string[] args) {
            //chamamos nossa primeira função
            Console.WriteLine (BomDia ());
            // chamamos a função do tipo void(sem retorno)
            ImprimeDataHora ();


            //chamamos nossa função que calcula a  média
            double[] numeros = {2,5,2,8,9,5};
            Console.WriteLine(CalculaMedia(numeros));

            //chamamos a função de soma
            Console.WriteLine(SomaValores(numeros));
        }

        /// <summary>
        /// função que escreve bom dia pro usúario
        /// </summary>
        /// <returns>retorna  ola! bom dia</returns>
        static string BomDia () {
            return "ola! bom dia!";
        }





        /// <summary>
        /// função que mostra uma saldação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de método)</param>
        /// <returns>saudação de acordo com o horário</returns>
        static string BomDia (string saudacao) {

            int hora = DateTime.Now.Hour;

            if (hora <= 12) {
                saudacao = "bom dia";
            } else if (hora >= 12 && hora <= 18) {
                saudacao = "boa tarde";
            } else {
                saudacao = "boa noite";
            } 

            return saudacao;
        }

        /// <summary>
        /// retorna um número - teste de sobrecarga
        /// </summary>
        /// <param name="numero">um número inteiro qualquer</param>
        /// <returns>número passado como parâmetro</returns>
        static int BomDia(int numero){
            return numero;
        }






        /// <summary>
        /// retorna data e hora atuais
        /// </summary>
        static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());

        }

    /// <summary>
    /// função que  calcula a média de um vetor
    /// </summary>
    /// <param name="valores">vetor com valores</param>
    /// <returns>média dos valores</returns>
        static double CalculaMedia( double[] valores){
            double resultado=0;
                for(int i = 0; i <valores.Length; i++ ){
                    resultado= resultado + valores[i];
                }
                resultado =resultado / valores.Length;

             return resultado;
        }
        
       /// <summary>
       /// calcula a dome de um vetor
       /// </summary>
       /// <param name="valores">vetor fr doubles</param>
       /// <returns>som de valores</returns>
        static double SomaValores( double[] valores){
            double resultado = 0 ;
              for(int i = 0; i <valores.Length; i++ ){
                    resultado= resultado + valores[i];
                }
               

             return resultado;
        }
            
            

        




    }
}
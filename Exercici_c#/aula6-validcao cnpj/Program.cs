using System;

namespace aula6_validcao_cnpj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu cnpj:  ");
            string cnpj = Console.ReadLine();
            Console.WriteLine(ValidarCnpj(cnpj));
        }
        static bool ValidarCnpj (string cnpjUsuario ){
            bool   resultado       =     false;
            int[]  v1              =     {5,4,3,2,9,8,7,6,5,4,3,2};
            string cnpjcalculo     =      "";
            string digito_1        =      "";
            string digito_2        =      "";
            int    resto           =      0;
            int    calculo         =      0;

            cnpjUsuario = cnpjUsuario.Replace(" ", "");
            cnpjUsuario = cnpjUsuario.Replace("-", "");
            cnpjUsuario = cnpjUsuario.Replace(".", "");      
            cnpjUsuario = cnpjUsuario.Replace("/", "");      

           cnpjcalculo             =     cnpjUsuario.Substring(0,12);


            for(int i=0; i<=11;i++){
                   calculo         +=    int.Parse(cnpjcalculo[i].ToString()) * v1[i];
            }
                  resto            =     calculo % 11;
                  calculo          =     11 - resto;


            if(   calculo <2){
                  digito_1         =      "0";
            }else{
                  digito_1         =      calculo.ToString();
            }

            
            if(   digito_1         ==     cnpjUsuario[12].ToString() ){
                  resultado        =      true;
            }



            int[] v2               =      {6,5,4,3,2,9,8,7,6,5,4,3,2};
                 resto             =       0;
            

                 cnpjcalculo       =       cnpjcalculo   +  calculo;
                 calculo           =       0; 


            
            for(int i=0; i<=12;i++){
                 calculo           +=      int.Parse(cnpjcalculo[i].ToString()) * v2[i];
            }
                 resto             =       calculo % 11;
                 calculo           =       11 - resto;


            if(  calculo <2){
                 digito_2          =       "0";
            }else{
                 digito_2          =       calculo.ToString();
            }

            
            if(  digito_2          ==      cnpjUsuario[13].ToString() ){
                 resultado         =       true;
            }else{
                 resultado         =       false;
            }


    
            return resultado;
        }
    }
}

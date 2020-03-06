using System;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            string final;
            string resultado;
            Console.WriteLine("Digite a placa do seu carro:");
            placa = Console.ReadLine();
            //contamos a quantidade de caracteres de um elemento
            int caracteres = placa.Length;

            //pegamos o ultimo digito
            //com o metodo substring()
            final =  placa.Substring(caracteres - 1);

            if(final == "1" || final == "2"){
                resultado = "IF/ELSE - seu rodizio é na segunda feira";
            }else if( final == "3"|| final =="4"){
                resultado ="IF/ELSE - seu rodizio é na terça feira";
                
            }else if(final ==" 5" || final =="6"){
                resultado ="IF/ELSE - seu rodizio é ne quarta feira";

            }else if(final == "7" || final == "8"){
                resultado = "IF/ELSE - seu rodizio é na quinta feira";
            }else if( final == "9" || final == "8"){
                resultado = "IF/ELSE - seu rodizio é na sexta feira";
            }else{
                resultado = "IF/ELSE - placa invalida";

            }
            Console.WriteLine(resultado);




            switch(final){
                case "1" :
                resultado = "switch - segunda feira";
                break;


                case "2":
                resultado = "switch - segunda feira";
                break;


                case" 3":
                resultado = "switch - terça feira";
                break;


                case "4":
                resultado = "switch - terça feira";
                break;


                case" 5":
                resultado = "switch - quarta feira";
                break;


                case "6":
                resultado = "switch - quarta feira";
                break;

                case "7":
                resultado = "switch - quinta feira";
                break;

                case "8":
                resultado = "switch - quinta feira";
                break;


                case 9:
                resultado = "switch - sexta feira";
                break;


                case"0":
                resultado = "switch - sexta feira";
                break;

                default:
                resultado = "switch - entrada invalida! :(";
                break;

         
            }
            Console.WriteLine(resultado);
        }
    }
}

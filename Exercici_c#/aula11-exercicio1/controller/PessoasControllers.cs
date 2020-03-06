using System;
using aula11_exercicio1.models;

namespace aula11_exercicio1.controller {
    public class PessoasControllers {
        pessoasModel pessoas = new pessoasModel ();

        public void imc () {
            System.Console.WriteLine ("Digite seu nome: ");
            pessoas.nome = Console.ReadLine ();

            System.Console.WriteLine ("Digite sua idade: ");
            pessoas.idade = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite seu peso: ");
            pessoas.peso = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua altura: ");
            pessoas.altura = double.Parse (Console.ReadLine ());
        }
        public void exibirImc () {
            System.Console.WriteLine (pessoas.nome);
            System.Console.WriteLine (pessoas.idade);
            System.Console.WriteLine (pessoas.peso);
            System.Console.WriteLine (pessoas.altura);
            pessoas.altura.ToString().Replace(',', '.'); 
            System.Console.WriteLine(calculoImc(pessoas.peso,pessoas.altura)); 
        }

        


        public string calculoImc (double peso, double altura) {
            //double calculoImc =  Math.Pow( altura, 2)/peso;
            double calculoImc =  peso / Math.Pow( altura, 2);
            
            
            string resultado = "";
            if(calculoImc <= 18.5){
                resultado = "Você esta abaixo do peso.";
            }else if(calculoImc >=18.5 &&  calculoImc<= 25){
                resultado = "Você esta no peso normal.";
            }else if(calculoImc >=26  && calculoImc <=30){
                resultado = "Você esta acima do peso.";
            }else if(calculoImc >=31 && calculoImc <=35){
                resultado = "Obesidade grau I.";
            }else if(calculoImc >=36 && calculoImc <=39){
                resultado = "Obesidade grau II.";
            }else if(calculoImc >=40){
                resultado = "Obesidade grau III.";
            }
            return resultado;
        }



    }

}
using System;
using aula11_explicação_ariel.models;

namespace aula11_explicação_ariel.controllers
{
    public class carroControllers
    {
       CarroModel carro = new CarroModel(); 
       motorModel motor = new motorModel();

       public void ligar(){
            carro.ligado = true;
            System.Console.WriteLine("Ligar carro!");
           
       }
       public void desligar(){
           carro.ligado =false;
           System.Console.WriteLine("Desligar carro...");
       }

       public void acelerar(){
           if(carro.ligado == true){
               System.Console.WriteLine("Carro acelerando!");
           }else{
               System.Console.WriteLine("o carro não está ligado! Impossivel acelerar!");
           }

       }

       public void freiar(){
           if(carro.ligado== true){
               System.Console.WriteLine("Carro freando");
           }else{
               System.Console.WriteLine("O carro não está ligado! Impossivel ");
           }
       }
       public  void cadastrarMotor(){
           System.Console.WriteLine("insira quntos cavalos tem o motor: ");
           motor.cavalos = int.Parse(Console.ReadLine());


           System.Console.WriteLine("insira quantos cilindros tem o carro: ");
           motor.cilindros =int.Parse(Console.ReadLine());

           
           System.Console.WriteLine("insira o modelo do pisão do carro");
           motor.pistao = Console.ReadLine();
           
           
           
       }

        
    }
}
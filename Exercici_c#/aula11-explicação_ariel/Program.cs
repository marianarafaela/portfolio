using aula11_explicação_ariel.controllers;
using System;


namespace aula11_explicação_ariel
{
    class Program
    {
        static void Main(string[] args)
        {
            carrosControllers carro = new carrosControllers();
            carroseletricosController carroseletricos =new carroseletricosController();
            Console.Clear();//limpar a tela do terminal
            carroseletricos.ligar();
            carroseletricos.carregarBateria(100);
            carroseletricos.carregarBateria(15);
            System.Console.WriteLine("carga do carro:"+ carroseletricos.statusBateria());
            
           

        }
    }
}

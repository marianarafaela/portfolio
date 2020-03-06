using System;
using aula11_explicação_ariel.models;

namespace aula11_explicação_ariel
{
    public class carrosControllers
    { 
        CarroModel carro= new CarroModel();

        public void Ligar()
        {        
            System.Console.WriteLine("carro ligado");
        }

        public void Acelerar()
        {
            System.Console.WriteLine("carro acelerando");
        }

        internal void cadastrarMotor()
        {
            throw new NotImplementedException();
        }

        public void ligar()
        {
            System.Console.WriteLine("carro ligando");
        }
    }
}
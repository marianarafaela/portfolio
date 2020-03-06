using System;

namespace aula14_poo_reforço.models
{
    public class BaseModel
    {
        public double Vida { get; set; }   = 100;
        public string Equipe { get; set; }
        public ConsoleColor Cor { get; set; }
    }
}
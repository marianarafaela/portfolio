using System;
using aula11_exercicio1.controller;
using aula11_exercicio1.models;

namespace aula11_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoasControllers pessoas1 = new PessoasControllers();
            pessoasModel pessoas = new pessoasModel();
            pessoas1.imc();
            pessoas1.exibirImc();

        }
    }
}

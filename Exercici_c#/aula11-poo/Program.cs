using System;
using aula11_poo.controllers;

namespace aula11_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProdutos();
            produto1.exibirProduto();
        }
    }
}

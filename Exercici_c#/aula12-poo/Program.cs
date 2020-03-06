using System;
using System.Collections.Generic;
using aula12_poo.models;

namespace aula12_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nossa classe com o metodo construtor passando os parâmetros
            ProdutoModel produto= new ProdutoModel(1, "maçã","verde",3.5);
            //chamos um atributo do objeto instanciado
            System.Console.WriteLine(produto.NomeProduto);

            //instanciamos nossa classe sem passar parãmetros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();
            produto_sobrecarga.Idproduto= 1;
            produto_sobrecarga.NomeProduto= "melão";
            produto_sobrecarga.Descricao="amarelo";
            produto_sobrecarga.Preco= 5.50;

            //chamamos a nossa lista que vai se de objeto ProdutoModel
            List<ProdutoModel> prod=new List<ProdutoModel>();
            //utilizamos objetos instanciando e atribuidos em nossa lista
            prod.Add(new ProdutoModel(1,"cenoura","laranja",2.30));
            prod.Add(new ProdutoModel(2,"mamão","laranja",2.30));
            prod.Add(new ProdutoModel(3,"beterraba","laranja",2.30));
            prod.Add(new ProdutoModel(4,"pastel","laranja",2.30));
            prod.Add(new ProdutoModel(5,"caldo de cana","laranja",2.30));
            prod.Add(new ProdutoModel(6,"chuchu","laranja",2.30));
            //utilizamos foreach para ler a lista de objetos /ler os dados da lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine();
                System.Console.WriteLine(p.Idproduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();

            }

            //chamamos atraves do indice um elemento/atributo especifico
            System.Console.WriteLine(prod[4].NomeProduto);
        }
    }
}

using System;
using System.IO;
using aula11_poo.models;

namespace aula11_poo.controllers {
    public class ProdutosController {
        ProdutosModel produto = new ProdutosModel ();
        public void CadastrarProdutos () {
            try {
                Console.WriteLine ("digite o ID do produto: ");
                produto.Idprodutos = int.Parse (Console.ReadLine ());

                System.Console.WriteLine("Digite o nome do produto: ");
                produto.NomeProduto = Console.ReadLine ();

                System.Console.WriteLine ("Digite a descricao do produto");
                produto.descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o preço do produto");
                produto.preco = double.Parse (Console.ReadLine ());

            } catch (Exception ex) {
                System.Console.WriteLine ("desculpe :( houve um erro na aplicação");
                SalvarErros (ex);
            }

        }
        public void exibirProduto () {
            System.Console.WriteLine (produto.Idprodutos);
            System.Console.WriteLine (produto.NomeProduto);
            System.Console.WriteLine (produto.descricao);
            System.Console.WriteLine (produto.preco);

        }
        private void SalvarErros (Exception ex) {
            StreamWriter text = new StreamWriter ("error_log.txt", true);

            text.WriteLine (DateTime.Now.ToLongDateString ());
            text.WriteLine (DateTime.Now.ToShortTimeString ());
            text.WriteLine (ex);
            text.WriteLine ();

            text.Close ();
        }
    }
}
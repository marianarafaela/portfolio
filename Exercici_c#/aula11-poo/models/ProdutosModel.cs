namespace aula11_poo.models
{
    public class ProdutosModel
    {
        public int    Idprodutos              {get; set;}
        public string NomeProduto             {get; set;}
        public string descricao               {get; set;}
        public double preco                   {get; set;}
        public  FornecedoresModel Fornecedor  {get; set;}
    }
}
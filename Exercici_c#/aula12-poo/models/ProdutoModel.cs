namespace aula12_poo.models
{
    public class ProdutoModel
    {
        public int      Idproduto   { get; set; }
        public string   NomeProduto { get; set; }
        public string   Descricao   { get; set; }
        public double   Preco       { get; set; }  
        //utilizamos sobrecarga para poder instraciar passando ou nao ps atributos/parametros/argumentos
        public ProdutoModel(){

        }
        public ProdutoModel         ( int idproduto, string nomeproduto, string descricao, double preco ){
        this.           Idproduto   = idproduto;
        this.           NomeProduto = nomeproduto;
        this.           Descricao   = descricao;
        this.           Preco       = preco;
        }
    }
}
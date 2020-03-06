using aula14_poo_reforço.models;

namespace aula14_poo_reforço.controllers
{
    public class BaseController
    {
         BaseModel basemodel = new BaseModel();
        public string Mostrainfo(){
            return $"Info do personagem: \n {basemodel.Vida}";


        }
        public string Pular(){
            return "personagem pulando";
        }
    }
}
using System;
using aula14_poo_reforço.models;

namespace aula14_poo_reforço.controllers
{
    public class HFController : BaseController

    {
        HFModel hfmodel = new HFModel();
        public string voar(){
            return "homem de ferro pulando ";
        }
        public string Atirar(){
            return "homem de ferro atirando ";
        }
        public ConsoleColor MudaCor(){
            return ConsoleColor.Red;
        }
    }
}
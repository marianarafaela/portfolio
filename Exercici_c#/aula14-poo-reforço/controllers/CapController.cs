using System;
using aula14_poo_reforço.models;

namespace aula14_poo_reforço.controllers
{
    public class CapController : BaseController
    {
        CapModel capmodel =new CapModel();
        public string LancarEscudo(){
            return "capitão america lançou o escudo";

        }
        public string DenfenderComEscudo(){
            return "Capitão america defendeu-se com escudo";
        }
        public ConsoleColor Mudacor(){

            return ConsoleColor.Blue;
        }
    }
}
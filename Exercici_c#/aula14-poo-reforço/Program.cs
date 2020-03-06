using System;
using aula14_poo_reforço.controllers;
using aula14_poo_reforço.models;

namespace aula14_poo_reforço
{
    class Program
    {
        static void Main(string[] args)
        {

        string        personagem;
                      System.Console.WriteLine        ("Digite \n  1- homem de ferro \n 2-capitão Amércica");
                      personagem                    = Console.ReadLine();
        HFController  hfcontroller                  = new HFController();
        CapController capcontroller                 = new CapController();
            
            if(       personagem                    =="1"){
                      Console.ForegroundColor = hfcontroller.MudaCor();
                      System.Console.WriteLine  (hfcontroller.Mostrainfo());
                      System.Console.WriteLine  ("voce esta jogando com o homem de ferro");
                      System.Console.WriteLine(hfcontroller.Atirar());
                      System.Console.WriteLine(hfcontroller.Pular());
                      System.Console.WriteLine(hfcontroller.voar());
                                                                                      
            }else if(personagem == "2"){
               Console.ForegroundColor =capcontroller.Mudacor();
                System.Console.WriteLine(capcontroller.Mostrainfo());
                System.Console.WriteLine("voce esta jogando com o homem de ferro");
                System.Console.WriteLine(capcontroller.LancarEscudo());
                System.Console.WriteLine(capcontroller.Pular());
                System.Console.WriteLine(capcontroller.DenfenderComEscudo());
            }else {
                System.Console.WriteLine("persongem invlido");
            }
                
           Console.ResetColor();
        }
    }
}

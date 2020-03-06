using aula11_explicação_ariel.models;

namespace aula11_explicação_ariel.controllers
{
    public class carroseletricosController : carrosControllers
    {
        carroEletricoModel motor =new carroEletricoModel ();
         //declaramos objeto carroeletricomModel
         carroEletricoModel carroEletrico = new carroEletricoModel();
        private static readonly motorModel motorModel = new motorModel();

        //cdeclaramos objeto motormodel
        motorModel Motor = motorModel;

         public void carregarBateria(float carga){
             if(carroEletrico.bateria < 100){
                 carroEletrico.bateria += carga;
             }else{
                 System.Console.WriteLine( "a bateria de carro ja esta completa! pode viajar");
             }
         }
          
          public float statusBateria(){
              return carroEletrico.bateria;
          }
    }
}
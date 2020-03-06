namespace aula8_ariel.models {
    public class AlunoModel {
        
        /// <summary>
        /// nome do aluno
        /// </summary>
        /// <value> string</value>
        
        public string name { get; set; }
        /// <summary>
        /// curso que esta cursando
        /// </summary>
        /// <value>string</value>
        public string curso { get; set; }
        /// <summary>
        /// ra do aluno ,registro do luno
        /// </summary>
        /// <value>string</value>
        public string RA { get; set; }
        /// <summary>
        /// idade do aluno
        /// </summary>
        /// <value>int</value>
        public int idade { get; set; }

        /// <summary>
        /// estudar
        /// </summary>
        public void estudar () {
            System.Console.WriteLine ("estou estudando");

        }
        /// <summary>
        /// pedir cafe
        /// </summary>
        public void pedirintervalo () {
            System.Console.WriteLine ("quero cafeee");
            System.Console.WriteLine ("INTERVALOOO");

        }
        /// <summary>
        /// pedir ajuda
        /// </summary>
        public void pedirajuda () {
            System.Console.WriteLine ("õooo paulo,cola aqui");

        }
        
    }
}
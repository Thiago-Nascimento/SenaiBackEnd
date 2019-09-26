namespace exemploPoo.Models
{
    public class AlunoModel
    {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome {get; set;}
        /// <summary>
        /// Nome do Curso
        /// </summary>
        /// <value>string</value>
        public string Curso {get; set;}
        /// <summary>
        /// Identificador de matrícula
        /// </summary>
        /// <value>string</value>
        public string RA {get; set;}
        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int Idade {get; set;}

        /// <summary>
        /// Escreve na tela "Estou estudando!"
        /// </summary>
        public void Estudar() {
            System.Console.WriteLine("Estou estudando!");
        }

        /// <summary>
        /// Escreve na tela "Tá na hora do café?"
        /// </summary>
        public void PedirIntervalo() {
            System.Console.WriteLine("Tá na hora do café?");
        }

        /// <summary>
        /// Escreve na tela "Ajuda ae Professor!"
        /// </summary>
        public void PedirAjuda() {
            System.Console.WriteLine("Ajuda ae Professor!");
        }
    }
}
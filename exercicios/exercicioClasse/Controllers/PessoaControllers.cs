using System;
using exercicioClasse.Models;

namespace exercicioClasse.Controllers
{
    public class PessoaControllers
    {
        PessoaModel pessoa = new PessoaModel();

        public void CadastraPessoa() {
            
            Console.WriteLine("Digite o Nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Idade da pessoa: ");
            pessoa.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Peso da pessoa: ");
            pessoa.Peso = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a Altura da pessoa: ");
            pessoa.Altura = double.Parse(Console.ReadLine());                        
        }

        public void ExibirPessoa() {
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Peso: {pessoa.Peso}");
            Console.WriteLine($"Altura: {pessoa.Altura}");
        }

        public void CalculaIMC() {
            pessoa.Imc = pessoa.Peso / (pessoa.Altura * pessoa.Altura);

            if(pessoa.Imc < 18.5) {
                pessoa.Classificacao = "Abaixo do Peso Ideal";
            } else if (pessoa.Imc < 25) {                
                pessoa.Classificacao = "Peso Normal";
            } else if (pessoa.Imc < 30) {
                pessoa.Classificacao = "Sobrepeso";
            } else if (pessoa.Imc < 35) {
                pessoa.Classificacao = "Obesidade Grau I";
            } else if (pessoa.Imc < 39) {
                pessoa.Classificacao = "Obesidade Grau II";
            } else {
                pessoa.Classificacao = "Obesidade Grau III";
            }

            Console.WriteLine($"IMC: {pessoa.Imc}\nClassificação: {pessoa.Classificacao}");
        }
    }
}
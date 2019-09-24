using System;

namespace passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] dataIda = new DateTime[5];
            DateTime[] dataVolta = new DateTime[5];

            Console.WriteLine("Passagens");
            Console.WriteLine();

            string sair = "";
            string continua = "";
            int cont = 0;

            Console.Clear();

            while(sair != "0") {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Passsagem\n2 - Listar Passagens\n0 - Sair");
                
                sair = Console.ReadLine();

                continua = "";

                switch(sair) {
                    case "1":
                        Console.Clear();                        

                        while(continua != "n" && cont < 5) {

                            Console.WriteLine($"Numero de Passageiros Cadastrados: {cont}");
                        
                            Console.Write("Digite o nome do passageiro: ");
                            nome[cont] = Console.ReadLine();
                            
                            Console.Write("Digite a origem do passageiro: ");
                            origem[cont] = Console.ReadLine();

                            Console.Write("Digite o destino do passageiro: ");
                            destino[cont] = Console.ReadLine();

                            Console.Write("Digite o data de ida do passageiro: ");
                            dataIda[cont] = DateTime.Parse(Console.ReadLine());

                            Console.Write("Digite o data de volta do passageiro: ");
                            dataVolta[cont] = DateTime.Parse(Console.ReadLine());

                            cont++;
                            
                            Console.WriteLine("Dados Cadastrados com sucesso!\n");

                            Console.WriteLine("\nDeseja continuar: S/N");
                            continua = Console.ReadLine().ToLower();
                        }

                        Console.WriteLine();

                        break;

                    case "2":    
                        Console.Clear();

                        for(int i = 0; i < cont; i++) {
                            Console.WriteLine($"Passageiro {i+1}: Nome: {nome[i]}, Origem: {origem[i]}, Destino: {destino[i]}, Data de Ida: {dataIda[i]}, Data de Volta: {dataVolta[i]}");
                        }
                        Console.WriteLine();                        
                        break;

                    case "0":
                        Console.WriteLine("Grazie Mille");
                        break;
                        
                    default:
                        Console.WriteLine("Entrada Inválida");
                        break;

                }
            }

        }
    }
}

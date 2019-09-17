    using System;

    namespace exercicioProjeto {
        class Program {
            static void Main (string[] args) {
                int resposta;
                string categoria = "";
                string subcategoria = "";

                Console.WriteLine ("\nFiltro de Produtos");
                Console.WriteLine ();

                Console.WriteLine ("Escolha o número da categoria, para listar produtos da mesma categoria:\n\n1 - Alimentos\n2 - Vestuário");

                resposta = int.Parse (Console.ReadLine ());

                if (resposta == 1) {
                    categoria = "Alimentos";

                } else if (resposta == 2) {
                    categoria = "Vestuário";
                } else {
                    Console.WriteLine ("Resposta Inválida");
                }

                if (resposta == 1 || resposta == 2) {
                    Console.WriteLine ($"A categoria escolhida foi: {categoria}\n");
                }

                if (categoria == "Alimentos") {
                    Console.WriteLine ("1 - Bebidas");
                    Console.WriteLine ("2 - Carnes");
                    Console.WriteLine ("3 - Cereais");
                    Console.WriteLine ("4 - Doces");
                    Console.WriteLine ("5 - Laticínios");
                } else if (categoria == "Vestuário") {
                    Console.WriteLine ("1 - Verão / Primavera");
                    Console.WriteLine ("2 - Outono / Inverno");
                }

                Console.WriteLine ("Agora escolha uma subcategoria: ");
                if (resposta == 1 || resposta == 2) {
                    resposta = int.Parse (Console.ReadLine ());
                }

                if (categoria == "Alimentos" && resposta == 1) {
                    subcategoria = "Bebidas";
                } else if (categoria == "Alimentos" && resposta == 2) {
                    subcategoria = "Carnes";
                } else if (categoria == "Alimentos" && resposta == 3) {
                    subcategoria = "Cereais";
                } else if (categoria == "Alimentos" && resposta == 4) {
                    subcategoria = "Doces";
                } else if (categoria == "Alimentos" && resposta == 5) {
                    subcategoria = "Laticínios";
                } else if (categoria == "Vestuário" && resposta == 1) {
                    subcategoria = "Verão / Primavera";
                } else if (categoria == "Alimentos" && resposta == 2) {
                    subcategoria = "Outono / Inverno";
                } else {
                    Console.WriteLine ("Resposta Inválida");
                }

                if (resposta == 1 || resposta == 2 || resposta == 3 || resposta == 4 || resposta == 5) {
                    Console.WriteLine ($"A categoria escolhida foi: {categoria}\n");
                    Console.WriteLine ("Agora escolha uma subcategoria: ");
                }

                if (categoria != "" || subcategoria != "") {
                    Console.WriteLine ($"A subcategoria escolhida foi: {subcategoria}\n");
                    Console.WriteLine ($"Agora os itens mostrados na pagina pertencem à categoria '{categoria}' e a subcategoria '{subcategoria}'");
                }
            }
        }
    }
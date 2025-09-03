using System;

namespace Estoque
{
    class Estoque
    {
        static string[] bloco_lista = { "A","B","C","D","E","F"};

        static List<string> cod_lista = new List<string>();
        static List<string> Lista = new List<string>();
        static string[] lista_opcoes = { "Adicionar Estoque", "Substituir Estoque", "Limite do Estoque", "Quantidade de um determinado estoque", "Lista dos Estoques" };
        public string opcoes()
        {
            foreach (var item in lista_opcoes)
            {
                Console.WriteLine(item);
            }
            return Console.ReadLine();
        }

        public string adicionar()
        {
            string[] categoria = { "Matéria Prima", "Produtos Acabados", "Ferramentas", "Embalagens", "Produtos em processo", "Equipamentos" };
            Console.WriteLine("Escreva o nome do produto");
            string nome = Console.ReadLine();
            foreach (var item in categoria)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Escolha uma Categoria");
            string categoria = Console.ReadLine();

            Console.WriteLine("Peso desse produto");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de Unidades");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Código ainda ser feito");
            string codigo = Console.ReadLine();

            
        }

        public string blocos_possiveis()
        {
            int possiveis = 7;
            List<string> lista = new List<string>();
            for (int i = 1; i < possiveis; i++)
            {
                for (int i = 0; i < bloco_lista.Length; i++)
                {
                    lista.Add(i);
                    cod_lista.Add(lista);
                }
            }
            Console.WriteLine(cod_lista);
        }

        public static void Main(string[] args)
        {



            Estoque estoque = new Estoque();
            var busca_opcoes = estoque.opcoes();

            if (!string.IsNullOrEmpty(busca_opcoes))
            {
                foreach (var item in lista_opcoes)
                {
                    if (item == busca_opcoes)
                    {
                        switch (busca_opcoes)
                        {
                            case "Adicionar Estoque":
                                estoque.blocos_possiveis();

                            case "Substituir Estoque":
                                continue;

                            case "Limite do Estoque":
                                continue;

                            case "Quantidade de um determinado estoque":
                                continue;

                            case "Lista dos Estoques":
                                continue;

                            default:
                        }
                    }
                }
            }
        }
    }
}
using System;

namespace Estoque
{
    class Estoque
    {
        static string[] lista_opcoes = { "Adicionar Estoque", "Substituir Estoque", "Limite do Estoque", "Quantidade de um determinado estoque", "Lista dos Estoques" };
        public string opcoes()
        {
            foreach (var item in lista_opcoes)
            {
                Console.WriteLine(item);
            }
            return Console.ReadLine();
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
                        Console.WriteLine("qq to fazendo da vida");                        
                    }
                }
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information



using System;
namespace Program
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private string fone;

        private string dados;
        public Pessoa(string Nome, int Idade, string fone)
        {
            this.nome = Nome;
            this.idade = Idade;
            this.fone = fone;
            this.dados = "Nome: " + this.nome + " Idade: " + this.idade + " Fone: " + this.fone;
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                idade = value;
            }
        }
        public string Fone
        {
            get { return fone; }
            set
            {
                fone = value;
            }
        }
        public string Dados
        {
            get { return dados; }

            set
            {
                dados = value;
            }
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            var lista = new List<String>{};
#pragma warning disable IDE0090 // Usar 'new(...)'
            while (true)
            {
                try
                {

                    Console.WriteLine("Insira seu Nome:");
                    string? nome = Console.ReadLine();

                    Console.WriteLine("Insira sua Idade");
                    int idade = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Insira seu Fone");
                    string? fone = Console.ReadLine();

                    Pessoa pessoa = new Pessoa(nome!, idade, fone!);
                    lista.Add(pessoa.Dados);

                    Console.WriteLine("Lista de Pessoas Agora: " + lista);

                    Console.WriteLine("Quer Continuar? S para Sim/N para Não");
                    string? escolha = Console.ReadLine();
                    if (!string.IsNullOrEmpty(escolha))
                    {
                        char hm = escolha[0];
                        if (hm == 'S')
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                        ;
                    }
                    else
                    {
                        Console.WriteLine("Deu ruim");
                        break;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("É serio isso?");
                    throw;
                }



            }


        }   
    }
}
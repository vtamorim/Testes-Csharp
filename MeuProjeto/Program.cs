// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private string fone;
        public Pessoa(string Nome, int Idade, string fone)
        {
            this.nome = Nome;
            this.idade = Idade;
            this.fone = fone;
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
            }}
        public string Fone
        {
            get { return fone; }
            set
            {
                fone = value;
            }
        }
        public ToString()
        {
            return "Nome: " + nome + "\nIdade: " + idade + "\nFone: " + fone;
        }
    }
    class Main
    {
        public static void Main(string[] args)
        {
#pragma warning disable IDE0090 // Usar 'new(...)'
            Pessoa First = new Pessoa();
            First.Nome = "Viktor";
            First.Idade = 24;
            First.Fone = "(84) 91234-5678";


            Console.WriteLine(First.Nome);
            Console.WriteLine(First.Idade);
            Console.WriteLine(First.Fone);
        }   
    }
}
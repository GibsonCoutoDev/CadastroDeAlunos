using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercs
{
    internal class Program
    {
        class Alunos
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Curso { get; set; }
        }
        static void Main(string[] args)
        {
            List<Alunos> ListaDeAlunos = new List<Alunos>();

            while (true)
            {
                Console.WriteLine("Opções: ");
                Console.WriteLine(" 1. Adicionar Aluno a Caderneta");
                Console.WriteLine(" 2. Listagem de Alunos");
                Console.WriteLine(" 3. Sair");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        CadastroAlunos(ListaDeAlunos);
                        break;
                    case "2":
                        ListagemDeAlunos(ListaDeAlunos);
                        break;
                    case "3":
                        Console.WriteLine("Finalizando");
                        return;
                    default:
                        Console.WriteLine("Opção invalida. Tente novamente.");
                        break;
                    
                }
            }
        }

        static void CadastroAlunos(List<Alunos> lista)
        {
            Alunos aluno = new Alunos();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a idade do Aluno: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o Curso do Aluno: ");
            aluno.Curso = Console.ReadLine();

            lista.Add(aluno);
            Console.Write("Aluno adicionado.");

        }

        static void ListagemDeAlunos(List<Alunos> lista)
        {
            if (lista.Count == 0)
            {
                Console.Write("Nenhum aluno foi cadastro.");
                return;
            }
            Console.WriteLine("Lista de Alunos: ");
            foreach (var aluno in lista)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}");
            }
                

        }
    }
}

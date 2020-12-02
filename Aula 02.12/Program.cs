 using System;
using Aula_02.classes;

namespace Aula_02._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite o Curso do Aluno: ");
            aluno.curso = Console.ReadLine();

            Console.WriteLine("Digite o RG do Aluno:");
            aluno.rg = Console.ReadLine(); 

            Console.WriteLine("Digite a idade do Aluno:");
            aluno.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a media final do Aluno:");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da mensalidade");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o Aluno e Bolsista: s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                aluno.bolsista = true;
            }else{
                aluno.bolsista = false;
            }

            // MENU
            int opcao = 0;
            do
            {
                Console.WriteLine("Selecione uma opcao");
                Console.WriteLine("[1] - Ver media do Aluno");
                Console.WriteLine("[2] - Ver Mensalidade do Aluno");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A media final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                        break;

                    case 2:
                        Console.WriteLine($"O valor da mensalidade do aluno fica em {aluno.VerMensalidade()}");
                        break;

                    case 0:
                    Console.WriteLine("Obrigado por acessar!");
                        break;

                    default:
                    Console.WriteLine("Opcao invalida");
                        break;
                }
                

            } while (opcao != 0);
        }
    }
}

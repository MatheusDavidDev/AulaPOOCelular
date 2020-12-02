using System;
using COOCelular.classe;

namespace COOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            Console.WriteLine("Qual a cor do celular ?");
            celular.cor = Console.ReadLine();

            Console.WriteLine("Qual o modelo do celular ?");
            celular.modelo = Console.ReadLine();

            Console.WriteLine("Qual o tamano do celular ?");
            celular.tamanho = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Deseja ligar o celualr ? s/n");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                celular.ligado = true;
            int menu = 0;
            do
            {
                Console.WriteLine($"Celular {celular.modelo} esta ligado");
                Console.WriteLine("[1] - Fazer ligação"); 
                Console.WriteLine("[2] - Enviar mensagem");
                Console.WriteLine("[0] - Desligar celular");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o numero que deseja fazer a ligacao:");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine(celular.Ligar(numero));
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Deseja enviar mensagem para ?");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Escreva a mensagem");
                        string msg = Console.ReadLine();
                        Console.WriteLine(celular.Mensagem(nome));
                        break;

                    case 0:
                        Console.WriteLine("Celular desligado");
                        break;    

                    default:
                        Console.WriteLine("Opcao nao existe");
                        break;
                }
                
            } while (menu != 0);
            }
            else{
                celular.ligado = false;
                Console.WriteLine("Celular desligado");
            }
        }
    }
}

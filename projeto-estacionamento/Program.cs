using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string op;
            string oploop;
            string opupper = "S";


            Estacionamento e = new Estacionamento();
            while (opupper != "N")
            {
                Console.WriteLine("Qual opção irá fazer? \n1-Cadastrar veículo\n2-Remover veículo\n3-Listar veículo\n4-Encerrar programa");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                       
                            Console.WriteLine("Qual a placa do veículo?");
                            string placa = Console.ReadLine();

                            
                            e.AdicionarVeiculo(placa);
                        break;

                    case "2":
                        Console.WriteLine("Qual a placa do veículo que irá remover?");
                        string placaremove = Console.ReadLine();

                        e.RemoverVeiculo(placaremove);
                        break;

                    case "3":
                        e.ListarVeiculos();
                        break;

                    case "4":
                        Console.WriteLine("Programa encerrado.");
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Opção inválida, digite novamente.");
                        break;
                }

                Console.WriteLine("\nDeseja voltar ao menu?\nDigite 's' - sim ou 'n' - não");
            oploop = Console.ReadLine();
            // Deixa todos caracteres maiusculos.
            opupper = oploop.ToUpper();

                
            }
            



            Console.ReadLine();
        }
    }
}

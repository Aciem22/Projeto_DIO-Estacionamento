using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_estacionamento
{
    internal class Estacionamento
    {
        private decimal precoHora = 15;
        private decimal Hora, PrecoTotal;
        List<string> ListaVeiculos = new List<string>();

    public void AdicionarVeiculo(String placa)
        {
            if (ListaVeiculos.Contains(placa))
            {
                Console.WriteLine("Placa já cadastrada no sistema!");
            }
            else
            {
                ListaVeiculos.Add(placa);
                Console.WriteLine($"A placa {placa} foi adicionada no sistema");

            }
        }

    public void RemoverVeiculo(String placaremove)
        {
            if (ListaVeiculos.Contains(placaremove))
            {
                Console.WriteLine("Quanto tempo o veículo ficou estacionado?");
                Hora = Decimal.Parse(Console.ReadLine());

                PrecoTotal = Hora * precoHora;

                Console.WriteLine($"O cliente deverá pagar {PrecoTotal}R$");

                ListaVeiculos.Remove(placaremove);
                Console.WriteLine($"O veículo da placa {placaremove} foi removido do sistema");
                
            }
            else
            {
                Console.WriteLine("Placa do veículo não encontrada!\nTente de novo");
            }
            
        }

    public void ListarVeiculos()
        {
            int contador = 0;
            foreach (String item in ListaVeiculos)
            {
                Console.WriteLine($"Posição Nº{contador+1} - {item}");
                contador++;
            }
        }

    }
}

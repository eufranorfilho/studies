using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_fundamentos_dio.models
{
    public class Estacionamento
    {
        private decimal PrecoInicial {get;set;}
        private decimal PrecoPorHora{get;set;}

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial = 0, decimal precoPorHora = 0)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }   

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo abaixo: ");
            var placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            string placa = Console.ReadLine().ToUpper();
            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper() ))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo passou estacionado: ");

                var horas = Convert.ToDecimal(Console.ReadLine());
                var valorTotal = PrecoInicial + (PrecoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veiculo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }    

        public void ListarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são: ");
                foreach (string veiculo  in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            } else
            {
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }
    }
}
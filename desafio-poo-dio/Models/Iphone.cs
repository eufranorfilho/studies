using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo_dio.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(){}
             public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override string InstalarAplicativo(string nome)
        {
            string message = $"Instalando o aplicativo no iPhone: {nome}";
            Console.WriteLine(message);
            return message;
        }
        
    }
}
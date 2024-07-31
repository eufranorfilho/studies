using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo_dio.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(){}
         public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }
        public override  string InstalarAplicativo(string nome)
        {
            string message = $"Instalando o aplicativo da Nokia: {nome}";
            Console.WriteLine(message);
            return message;
        }
    }
}
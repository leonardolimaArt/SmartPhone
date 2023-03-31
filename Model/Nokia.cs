using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Model
{
    public class Nokia : Smatphone
    {

        public Nokia(string numero, string modelo, string imei, string memoria) : base( numero, modelo, imei, memoria){

        }

        public override void InstalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Instalando aplicativo {nome} no Nokia!\nModelo: {Modelo}");
        }
    }
}
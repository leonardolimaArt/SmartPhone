using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Model
{
    public abstract class Smatphone
    {
        public string numero;
        private string modelo;
        private string imei;
        private string memoria;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Imei { get => imei; set => imei = value; }
        public string Memoria { get => memoria; set => memoria = value; }

        public Smatphone(string numero, string modelo, string imei, string memoria){
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public void Ligar(){

        }

        public void ReceberLigacao(){

        }

        public abstract void InstalarAplicativo(string nome);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.Models {
    public abstract class Smartphone(string numero, string modelo, string IMEI, int memoria) {
        public string numero = numero;
        protected string _modelo = modelo;
        protected string IMEI = IMEI;
        protected int _memoria = memoria;

        public void Ligar() {
            Console.WriteLine("Ligando o smartphone...");
        }

        public void ReceberChamada() {
            Console.WriteLine("Recebendo chamada...");
        }

        public abstract void InstalarApp(string app);


    }
}
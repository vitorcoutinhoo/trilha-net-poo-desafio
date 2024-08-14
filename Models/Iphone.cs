using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.Models {
    public class Iphone(string numero, string modelo, string IMEI, int memoria) : Smartphone(numero, modelo, IMEI, memoria) {
        public override void InstalarApp(string app) {
            Console.WriteLine($"Instalando {app} no Iphone...");
        }
    }
}
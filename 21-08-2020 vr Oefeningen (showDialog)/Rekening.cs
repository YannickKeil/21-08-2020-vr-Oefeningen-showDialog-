using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    class Rekening
    {
        public string RekeningNummer { get; set; }
        public int Saldo { get; set; }

        public Rekening(string rekeningNummer, int saldo)
        {
            RekeningNummer= rekeningNummer;
            Saldo = saldo;
        }
    }
}

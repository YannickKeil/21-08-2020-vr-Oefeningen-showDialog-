using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    public class Rekening
    {
        public string RekeningNummer { get; set; }
        public double Saldo { get; set; }

        public Rekening(string rekeningNummer, double saldo)
        {
            RekeningNummer = rekeningNummer;
            Saldo = saldo;
        }
        public virtual bool Overschrijven(double bedrag)
        {
            Saldo -= bedrag;
            return true;
        }
        public override string ToString()
        {
            return RekeningNummer;
        }
        public virtual string RekeningNaam()
        {
            return "undefined";
        }
        public bool Remove()
        {
            
            if (Saldo == 0.00)
            {
                return true;
            }
            else
                return false;

        }

    }
}

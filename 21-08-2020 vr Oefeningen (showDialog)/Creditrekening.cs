using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    public class Creditrekening : Rekening
    {
        public int CSC { get; }
        public string Naam { get; }
        public Creditrekening(string rekeningNummer, double saldo) : base(rekeningNummer, saldo)
        {
            CSC = MaakCSC();
            Naam = "Creditrekening";
        }
        public override string RekeningNaam()
        {
            return $"{Naam} CVC is {CSC}";
        }
        public int MaakCSC()
        { 
            Random random = new Random();
            return random.Next(1000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    public class Spaarrekening : Rekening
    {
        public string Naam { get; }
        public Spaarrekening(string rekeningNummer, double saldo) : base(rekeningNummer, saldo)
        {
            Naam = "Spaarrekening";
        }
        public override bool Overschrijven(double bedrag)
        {
            MessageBox.Show("spaarrekeningen kunnen niet overschrijven");
            return false;
        }
        public override string RekeningNaam()
        {
            return Naam;
        }
    }
}

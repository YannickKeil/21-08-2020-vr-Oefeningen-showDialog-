using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    public class Debitrekening : Rekening
    {

        public string Naam { get; }
        public Debitrekening(string rekeningNummer, double saldo) : base(rekeningNummer, saldo)
        {
            Naam = "Debitrekening";
        }
        public override bool Overschrijven(double bedrag)
        {
            if (Saldo < bedrag)
            {
                MessageBox.Show("Ingegeven bedrag is groter dan u saldo. \nDebitrekeningen kunnen niet negatief gaan.");
                return false;
            }
            else
            {
                Saldo -= bedrag;
                return true;
            }
        }
        public override string RekeningNaam()
        {
            return Naam;
        }
    }
}


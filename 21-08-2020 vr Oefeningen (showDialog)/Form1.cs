using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Rekening> mijnRekeningen = new List<Rekening>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string startRekeningNummer = NewAccountGenerator();
            Rekening startrekening = new Debitrekening(startRekeningNummer, 10000);
            mijnRekeningen.Add(startrekening);
            LaadRekeningen();

        }
        public string NewAccountGenerator()
        {
            string nieuwRekening = "BE";
            Random random = new Random();
            for (int i = 0; i < 14; i++)
            {
                if (i == 2 || i == 6 || i == 10)
                {
                    nieuwRekening += $" {random.Next(10)}";
                }
                else
                {
                    nieuwRekening += $"{random.Next(10)}";
                }
            }
            return nieuwRekening;
        }
        private void btnNieuwRekening_Click(object sender, EventArgs e)
        {
            NieuwRekening nieuwRekening = new NieuwRekening();
            if (nieuwRekening.ShowDialog() == DialogResult.OK)
            {
                string newRekening = NewAccountGenerator();
                if (nieuwRekening.keuze == "Creditrekening")
                {
                    Rekening newCard = new Creditrekening(newRekening, 0);
                    mijnRekeningen.Add(newCard);
                }
                else if (nieuwRekening.keuze == "Debitrekening")
                {
                    Rekening newCard = new Debitrekening(newRekening, 0);
                    mijnRekeningen.Add(newCard);
                }
                else if (nieuwRekening.keuze == "Spaarrekening")
                {
                    Rekening newCard = new Spaarrekening(newRekening, 0);
                    mijnRekeningen.Add(newCard);
                }
            }
            LaadRekeningen();
        }
        private void lbRekeningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rekening selected = (Rekening)lbRekeningen.SelectedItem;
            if (lbRekeningen.DataSource != null)
            {
                lRekeningSaldo.Text = "€ " + Math.Round(selected.Saldo, 2).ToString();
                lRekeningNaam.Text = selected.RekeningNaam();
                if (selected.RekeningNaam() == "Spaarrekening")
                    btnOverschrijven.Enabled = false;
                else
                    btnOverschrijven.Enabled = true;
                lbRekeningen.SelectedIndex = 0;
            }
            
        }
        public void LaadRekeningen()
        {
            lbRekeningen.DataSource = null;
            lbRekeningen.DataSource = mijnRekeningen;
            if (lbRekeningen.SelectedItem != null)
            {
                Rekening selected = (Rekening)lbRekeningen.SelectedItem;
                lRekeningSaldo.Text = "€ " + Math.Round(selected.Saldo, 2).ToString();
                lRekeningNaam.Text = selected.RekeningNaam();
            }
                
            
        }
        private void btnOverschrijven_Click(object sender, EventArgs e)
        {
            Rekening selected = (Rekening)lbRekeningen.SelectedItem;
            
                Overschrijving overschrijving = new Overschrijving();
                if (overschrijving.ShowDialog() == DialogResult.OK)
                {
                    bool check = selected.Overschrijven(overschrijving.bedrag);
                    if (check)
                    {
                        foreach (var item in mijnRekeningen)
                        {
                            if (item.RekeningNummer == overschrijving.rekeningKeuze)
                            {
                                item.Saldo += overschrijving.bedrag;
                            }
                        }
                    }
                }
            LaadRekeningen();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Rekening selected = (Rekening)lbRekeningen.SelectedItem;
            bool GeenSaldo = selected.Remove();
            if (GeenSaldo)
            {
                foreach (var item in mijnRekeningen)
                {
                    if (item.RekeningNummer == selected.RekeningNummer)
                    {
                        mijnRekeningen.Remove(item);
                        LaadRekeningen();
                        
                        break;
                    }
                }
            }
            else
            { MessageBox.Show("je saldo moet op 0,00 staan om verwijdert te worden"); }
        }
    }
}

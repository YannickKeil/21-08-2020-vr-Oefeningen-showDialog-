using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_08_2020_vr_Oefeningen__showDialog_
{
    public partial class Overschrijving : Form
    {
        public Overschrijving()
        {
            InitializeComponent();
        }
        public string rekeningKeuze;
        public double bedrag;



        private void btnOverschrijven_Click(object sender, EventArgs e)
        {
            rekeningKeuze = mtbKeuzeRekening.Text;
            bedrag = Convert.ToDouble(nudKeuzeBedrag.Value);

            this.DialogResult = DialogResult.OK;
           
            //if (Regex.IsMatch(tbKeuzeRekening.Text.ToUpper(), @"BE\d{2} \d{4} \d{4} \d{4}"))
            //{
            //    rekeningKeuze = tbKeuzeRekening.Text.ToUpper();
            //    bedrag = Convert.ToDouble(nudKeuzeBedrag.Value);
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    MessageBox.Show("rekening is een verkeerde format kijk naar voorbeeld"); 
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Overschrijving_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string Test()
        {
            return $"ben je zeker dat je €{bedrag} wil overschrijven naar {rekeningKeuze}";
        }
    }
}

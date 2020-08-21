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
    public partial class NieuwRekening : Form
    {
        public NieuwRekening()
        {
            InitializeComponent();
        }
        public string keuze;
        private void btnAccept_Click(object sender, EventArgs e)
        {
            keuze = cbKeuzeRekening.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void NieuwRekening_Load(object sender, EventArgs e)
        {

        }
    }
}

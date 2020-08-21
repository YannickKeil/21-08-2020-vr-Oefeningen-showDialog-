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
        public int[] newAccount = new int[14];
        private void Form1_Load(object sender, EventArgs e)
        {
            string startAccount = NewAccountGenerator();
            

        }
        public string NewAccountGenerator()
        {
            string nieuwRekening = "BE";
            Random random = new Random();
            for (int i = 0; i < newAccount.Length; i++)
            {
                newAccount[i] = random.Next(10);
                if (i == 2 || i == 6 || i == 10)
                {
                    nieuwRekening += $" {newAccount[i]}";
                }
                else 
                {
                    nieuwRekening += $"{newAccount[i]}";
                }
            }
            
            return nieuwRekening;

        }
    }
}

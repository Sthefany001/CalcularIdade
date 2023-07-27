using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataNasc = dateTimePicker1.Value;
            //int idade = DateTime.Today.Year - dataNasc.Year;

            TimeSpan diasIdade = dataNasc.Subtract(DateTime.Today);
            //label2.Text = diasIdade.Days.ToString();

            double idadeOfc = diasIdade.Days / 365.2425;
            idadeOfc = Math.Floor(idadeOfc) * (-1);
            label2.Text = idadeOfc.ToString("0");
            
        }
    }
}

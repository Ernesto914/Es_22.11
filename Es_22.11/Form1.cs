using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_22._11
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Differenza_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(dtp_DATA1.Text, out DateTime d1);
            DateTime.TryParse(dtp_DATA2.Text, out DateTime d2);
            if (d1 > d2)
            {
                TimeSpan differenza = d1 - d2;
                lbl_DIFF.Text = "La differenza delle due date è di " + differenza.Days + " giorni";
            }
            else
            {
                TimeSpan differenza = d2 - d1;
                lbl_DIFF.Text = "La differenza delle due date è di " + differenza.Days + " giorni";
            }
        }

        private void button_agg_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int giorni))
            {
                MessageBox.Show("Errore: inserire un numero valido di giorni");
                return;
            }
            DateTime.TryParse(dateTimePicker1.Text, out DateTime d1);
            //la funzione per stampare solo la data presa su ChatGPT
            lbl_RISULTATO.Text = "La somma dei giorni della data ha dato come risultato la data " + d1.AddDays(giorni).ToString("dd/MM/yyyy"); 
        }

        private void button_rm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int giorni))
            {
                MessageBox.Show("Errore: inserire un numero valido di giorni");
                return;
            }
            DateTime.TryParse(dateTimePicker1.Text, out DateTime d1);
            lbl_RISULTATO.Text = "La sottrazione dei giorni della data ha dato come risultato la data " + d1.AddDays(-giorni).ToString("dd/MM/yyyy"); 
        }
    }
}
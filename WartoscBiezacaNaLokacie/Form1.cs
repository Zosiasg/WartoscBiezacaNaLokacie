using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WartoscBiezacaNaLokacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Matematyka finansowa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oprocentowanie_realne = (1 + oprocentowanie/100) / (1 + inflacja/100) - 1;
            wynik = kwota / Math.Pow(1 + oprocentowanie_realne, lata);
            textBox5.Text = wynik.ToString("0,0.00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                kwota = Convert.ToDouble(textBox1.Text); 
            }
            catch 
            {
                MessageBox.Show("Kwota musi być liczbą!", "Nieprawidłowa wartość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                oprocentowanie = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Oprocentowanie musi być liczbą!", "Nieprawidłowa wartość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lata = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Liczba lat musi być liczbą!", "Nieprawidłowa wartość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inflacja = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Wartość inflacji musi być liczbą!", "Nieprawidłowa wartość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        
}


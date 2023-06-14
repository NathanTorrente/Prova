using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRova
{
    public partial class Avaliacao : Form
    {
        public Avaliacao()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string texto = "Você acertou: ";
            string soma = "";

            string[] array = new string[10];

            array[0] = "A";
            array[1] = "B";
            array[2] = "D";
            array[3] = "E";
            array[4] = "C";
            array[5] = "A";
            array[6] = "A";
            array[7] = "D";
            array[8] = "E";
            array[9] = "B";

            

            if (textBox1.Text == array[0])
            {
                
             
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }

            if (textBox2.Text == array[1])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox3.Text == array[2])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox4.Text == array[3])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox5.Text == array[4])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox6.Text == array[5])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox7.Text == array[6])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox8.Text == array[7])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox9.Text == array[8])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox10.Text.ToUpper() == array[9])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }

            
            lb_resultado.Text = contador.ToString();
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

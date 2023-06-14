using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

            string[] array = new string[] { "A", "B" , "D", "E", "C", "A", "A", "D", "E", "B" }; // Troquei o tipo de array Lab 1


            if (textBox1.Text.ToUpper() == array[0])
            {             
                MessageBox.Show("Está Correto");
                contador++; 
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }

            if (textBox2.Text.ToUpper() == array[1])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox3.Text.ToUpper() == array[2])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox4.Text.ToUpper() == array[3])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox5.Text.ToUpper() == array[4])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox6.Text.ToUpper() == array[5])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox7.Text.ToUpper() == array[6])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox8.Text.ToUpper() == array[7])
            {
                MessageBox.Show("Está Correto");
                contador++;
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox9.Text.ToUpper() == array[8])
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

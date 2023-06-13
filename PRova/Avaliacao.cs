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



            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }


            if (textBox2.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox3.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox4.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox5.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox6.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox7.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox8.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox9.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            if (textBox10.Text == soma)
            {
                MessageBox.Show("Está Correto");
            }
            else
            {
                MessageBox.Show("Está Incorreto");
            }
            lb_resultado.Text = soma.ToString();
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

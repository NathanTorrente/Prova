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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
               
            }
            string armazenar = array[0];
            string armazenar1 = array[1];
            string armazenar2 = array[2];
            string armazenar3 = array[3];
            string armazenar4 = array[4];
            string armazenar5 = array[5];
            string armazenar6 = array[6];
            string armazenar7 = array[7];
            string armazenar8 = array[8];
            string armazenar9 = array[9];

            if (textBox1.Text == armazenar)
            {
                MessageBox.Show("Está Correto");
            }
            else 
            {
                MessageBox.Show("Está Errado");
            }
           
            if (textBox1.Text == armazenar1)
            {
                MessageBox.Show("Está Correto");
            }
            else if (textBox1.Text != armazenar1)
            {
                MessageBox.Show("Está Errado");
            }
            if (textBox1.Text == armazenar2)
            {
                MessageBox.Show("Está Correto");
            }
            else if (textBox1.Text != armazenar2)
            {
                MessageBox.Show("Está Errado");
            }
            if (textBox1.Text == armazenar)
            {
                MessageBox.Show("Está Correto");
            }
            else if (textBox1.Text != armazenar)
            {
                MessageBox.Show("Está Errado");
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondLab
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rand.Next(-500,+500);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] =" + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int count = 0;
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i] % 5 == 0)
                {
                    count += Mas[i];
                }
            }
            textBox2.Text += "Result = " + count.ToString();
        }
    }
}

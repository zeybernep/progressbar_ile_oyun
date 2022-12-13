using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._12._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0,100);
            progressBar1.Maximum = sayi;
            MessageBox.Show(sayi.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eklenen = Convert.ToInt32(textBox1.Text);
            
            if(progressBar1.Value+eklenen >= progressBar1.Maximum) MessageBox.Show("oyun bitti");
            else
            {
                progressBar1.Value += Convert.ToInt32(textBox1.Text);
            }

        }
    }
}

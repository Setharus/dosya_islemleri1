using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numara, isim;
            isim = textBox2.Text;
            numara = textBox1.Text;

            if (System.IO.File.Exists("C:\\" + numara + ".txt"))
            {
                MessageBox.Show("Dosya Mevcut");
            }
            else
            {
                StreamWriter dosya = File.AppendText("C:\\" + numara + ".txt");
                dosya.WriteLine("İsim: " + textBox2.Text);
                dosya.WriteLine("Numara: " + textBox1.Text);
                dosya.Close();
                MessageBox.Show("Dosya Oluştu");
            }
        }
    }
}
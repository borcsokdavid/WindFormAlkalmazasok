using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamolasiAlapok
{
    public partial class Feladat : Form
    {
        public Feladat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);
            double c = Math.Sqrt((a * a) + (b * b));
            
            double ker = a + b + c;
            
            double ter = (a + b + c) / 2;
            
            textBox3.Text = ($"C oldal ={c:F2}\n Kerület: {ker:F2}\n Terület: {ter:F2}");
            
        }
    }
}

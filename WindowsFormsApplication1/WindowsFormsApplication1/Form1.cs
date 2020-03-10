using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<tanulo> lista = new List<tanulo>();
        private void button1_Click(object sender, EventArgs e)
        {
            string nev = nev1.Text;
            nev1.Clear();
            string igazolt = igazolthianyzas1.Text;
            igazolthianyzas1.Clear();
            string igazolatlan = igazolatlanhianyzas1.Text;
            igazolatlanhianyzas1.Clear();

            tanulo tan = new tanulo(nev, igazolt, igazolatlan);
            lista.Add(tan);
            comboBox1.Items.Add(nev);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                if (comboBox1.SelectedItem.ToString() == item.Nev)
                {
                    label8.Text = item.Igazolt;
                    label6.Text = item.Igazolatlan;
                }
            }
        }
    }
}

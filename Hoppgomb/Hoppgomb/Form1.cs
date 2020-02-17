using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoppgomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            int maxszelesseg = this.Size.Width - button1.Size.Width - 10;
            int maxmagassag = this.Size.Width - button1.Size.Width - 10;
            if (int.Parse(textBox1.Text) <= maxszelesseg && int.Parse(textBox2.Text) <= maxmagassag)
            {
                button1.Location = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}

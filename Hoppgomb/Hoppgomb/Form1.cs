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
            int szelesseg = this.Size.Width - button1.Width - 10;
            int magassag = this.Size.Height - button1.Height - 10;
            Random rnd = new Random();
            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            button1.Location = new Point(x, y);
            if (int.Parse(textBox1.Text) <= szelesseg && int.Parse(textBox2.Text) <= magassag)
            {
                button1.Location = new Point(x, y);
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}

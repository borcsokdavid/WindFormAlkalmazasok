using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsoWinForm
{
    public partial class urlap : Form
    {
        public string belepoSzoveg = "Űrlap";
        public urlap()
        {
            InitializeComponent();
        }

        private void modositoGomb_Click(object sender, EventArgs e)
        {
            /*string modositandoSzoveg = beviteliMezo.Text;
            kimenoSzoveg.Text = modositandoSzoveg.ToUpper();*/
            //this.Close();
            MessageBox.Show("Éljen a 13 SZF", "Ez egy üdvözlő üzenet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        }

        private void urlap_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "Belépett";
        }

        private void urlap_MouseLeave(object sender, EventArgs e)
        {
            this.Text =  belepoSzoveg;
        }

        private void urlap_Load(object sender, EventArgs e)
        {
            this.Text = belepoSzoveg.ToUpper();
        }

        private void urlap_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mozgás";
        }

        private void beviteliMezo_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int szam = rnd.Next(5);
            switch (szam)
            {
                case 0:
                    {
                        this.BackColor = Color.Green;
                        break;
                    }
                case 1:
                    {
                        this.BackColor = Color.Blue;
                        break;
                    }
                case 2:
                    {
                        this.BackColor = Color.Red;
                        break;
                    }
                case 3:
                    {
                        this.BackColor = Color.Yellow;
                        break;
                    }
                case 4:
                    {
                        this.BackColor = Color.Brown;
                        break;
                    }


            }
            
        }

        private void gomb2_MouseEnter(object sender, EventArgs e)
        {
            gomb2.Visible = false;
        }

        private void gomb2_MouseLeave(object sender, EventArgs e)
        {
            gomb2.Visible = true;
        }

        private void elso_Click(object sender, EventArgs e)
        {
            if (masodik.Visible)
            {
                masodik.Visible = false;
            }
            else
            {
                masodik.Visible = true;
            }
        }

        private void masodik_Click(object sender, EventArgs e)
        {
            if (elso.Enabled)
            {
                elso.Enabled = false;
            }
            else
            {
                elso.Enabled = true;
            }
        }

        private void harmadik_Click(object sender, EventArgs e)
        {
            harmadik.Location = new Point(0, 0);
        }

        private void harmadik_MouseEnter(object sender, EventArgs e)
        {
            /*Random x = new Random();
            Point pt = new Point(int.Parse(x.Next(400).ToString()), int.Parse(x.Next(650).ToString()));
            harmadik.Location = pt;*/

            int szelesseg = this.Size.Width - harmadik.Width - 10;
            int magassag = this.Size.Height - harmadik.Height - 10;
            Random rnd = new Random();
            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            harmadik.Location = new Point(x, y);
        }
    }
}

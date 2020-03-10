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

namespace Balkezesek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string elsosor = "";
        List<adatok> adatoklista = new List<adatok>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("balkezesek.csv", Encoding.UTF8))
            {
                elsosor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string nev = sor.Split(';')[0];
                    string elso = sor.Split(';')[1];
                    string utolso = sor.Split(';')[2];
                    int suly = Int32.Parse(sor.Split(';')[3]);
                    int magassag = Int32.Parse(sor.Split(';')[4]);
                    adatok jatekos = new adatok(nev, elso, utolso, suly, magassag);
                    adatoklista.Add(jatekos);
                    columnHeader1.Text = elsosor.Split(';')[0];
                    columnHeader2.Text = elsosor.Split(';')[1];
                    columnHeader3.Text = elsosor.Split(';')[2];
                    columnHeader4.Text = elsosor.Split(';')[3];
                    columnHeader5.Text = elsosor.Split(';')[4];

                    ListViewItem lvi = new ListViewItem(nev);
                    lvi.SubItems.Add(elso);
                    lvi.SubItems.Add(utolso);
                    lvi.SubItems.Add(suly.ToString());
                    lvi.SubItems.Add(magassag.ToString());
                    listView1.Items.Add(lvi);
                }

                    textBox1.Text = $"{adatoklista.Count}";

                string kiiras = "";
                foreach (var item in adatoklista)
                {
                    if (item.utolso.Substring(0, 7) == "1999-10")
                    {
                        kiiras += $"{item.nev},{item.magassag * 2.54:F1}cm\r\n"; 
                    }
                }
                textBox2.Text = kiiras;

            }
        }
    }
}

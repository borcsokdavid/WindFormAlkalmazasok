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

namespace Snooker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string elsoSor = "";
        List<versenyzo> versenyzoLista = new List<versenyzo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("snooker.txt", Encoding.UTF8))
            {
                elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    for (int i = 0; i < elsoSor.Split(';').Length; i++)
                    {
                        listView1.Columns[i].Text = elsoSor.Split(';')[i];
                    }
                    
                    
                    int helyezes = Int32.Parse(sor.Split(';')[0]);
                    string nev = sor.Split(';')[1];
                    string orszag = sor.Split(';')[2];
                    int nyeremeny = Int32.Parse(sor.Split(';')[3]);
                    versenyzo Versenyzo = new versenyzo(helyezes, nev, orszag, nyeremeny);
                    versenyzoLista.Add(Versenyzo);
                    ListViewItem lvi = new ListViewItem(helyezes.ToString());
                    lvi.SubItems.Add(nev);
                    lvi.SubItems.Add(orszag);
                    lvi.SubItems.Add(nyeremeny.ToString());
                    listView1.Items.Add(lvi);

                    /*columnHeader1.Text = elsoSor.Split(';')[0];
                    columnHeader2.Text = elsoSor.Split(';')[1];
                    columnHeader3.Text = elsoSor.Split(';')[2];
                    columnHeader4.Text = elsoSor.Split(';')[3];*/

                    bool vanE = true;
                    foreach (var item in comboBox1.Items)
                    {
                        if (item.ToString() == orszag)
                        {
                            vanE = false;
                                break;
                        }
                    }
                    if (vanE)
                    {
                        comboBox1.Items.Add(orszag);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int osszeg = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                osszeg += int.Parse(item.SubItems[3].Text);
            }
            int atlag = osszeg / listView1.Items.Count;
            textBox1.Text = atlag.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            int index = -1;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[2].Text == "Kína" && int.Parse(item.SubItems[3].Text) > osszeg)
                {
                    osszeg = int.Parse(item.SubItems[3].Text);
                    index = item.Index;
                }
            }
            foreach  (ListViewItem item in listView1.Items)
            {
                if (item.Index == index)
                {
                    string helyezes = item.SubItems[0].Text;
                    string nev = item.SubItems[1].Text;
                    string orszag = item.SubItems[2].Text;
                    string nyeremeny = item.SubItems[3].Text;

                    textBox2.Text = $"{helyezes}, {nev}, {orszag}, {nyeremeny}"; 
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ertek = Int32.Parse(textBox3.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[2].Text != comboBox1.SelectedItem.ToString() || Int32.Parse(item.SubItems[3].Text) < ertek)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in listView1.Items)
            {
                if (Int32.Parse(item.SubItems[3].Text) < Int32.Parse( textBox3.Text))
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

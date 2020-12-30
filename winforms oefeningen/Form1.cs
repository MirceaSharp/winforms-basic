using System;
using System.IO;
using System.Windows.Forms;

namespace winforms_oefeningen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbSelectie.Items.Add("Andrew");
            cbSelectie.Items.Add("Curfew");
            cbSelectie.Items.Add("Mircea");
            cbSelectie.Items.Add("Bridge");
            cbSelectie.Items.Add("Melissa");
            cbSelectie.Items.Add("Andreea");
            
        }

        private void lbContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSelectie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbSelectie.SelectedIndex != -1)
            {
                //lbContent.Items.Insert(0, cbSelectie.SelectedItem);
                lbContent.Items.Add(cbSelectie.SelectedItem);
                cbSelectie.SelectedItem = -1;
                lbContent.SelectionMode = SelectionMode.MultiExtended;
                lbContent.Sorted = true;


            }
            else
            {
                MessageBox.Show("Er is geen naam gelesecteerd", "Foutmelding!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            using ( StreamWriter writer = new StreamWriter("namen.txt"))
                {
                string stringline;
                for (int i = 0; i < lbContent.Items.Count; i++)
                {
                    stringline = lbContent.Items[i].ToString();
                    writer.WriteLine(stringline);

                }
            }
            
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            lbContent.Items.Remove(lbContent.SelectedItem);
        }
    }
}

using System;
using System.Windows.Forms;

namespace Simple_text_editor
{
    public partial class Form1 : Form
    {
        string filepath = null;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string[] file)
        {
            if (file.Length != 0)
            {
                filepath = file[0];
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contenet.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog()== DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(of.FileName);
                contenet.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sf.FileName);
                sw.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Seif Uddean Alkowatli :) ");
        }
    }
}

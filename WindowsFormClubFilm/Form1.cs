using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormClubFilm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Film.ajouter_film(textBox1.Text, int.Parse(textBox2.Text),openFileDialog1.FileName);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Film.filmes) listBox1.Items.Add(item);
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            Image image = Image.FromFile(pictureBox1.ImageLocation);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}

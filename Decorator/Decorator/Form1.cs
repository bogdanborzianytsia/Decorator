using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            Tree boats1 = new YoungTree();
            boats1 = new YoungerTree(boats1);
            richTextBox1.Text += ("Название:", boats1.Name);
            richTextBox1.Text += ("Возраст:", boats1.GetYear()) + "\n";
            pictureBox1.ImageLocation = boats1.photo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            Tree boats2 = new YoungTree();
            boats2 = new OlderTree(boats2);
            richTextBox1.Text += ("Название:", boats2.Name);
            richTextBox1.Text += ("Возраст:", boats2.GetYear()) + "\n";
            pictureBox1.ImageLocation = boats2.photo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            Tree boats3 = new OldTree();
            boats3 = new YoungerTree(boats3);
            boats3 = new OlderTree(boats3);
            richTextBox1.Text += ("Название:", boats3.Name);
            richTextBox1.Text += ("Возраст:", boats3.GetYear()) + "\n";
            pictureBox1.ImageLocation = boats3.photo;
        }
    }
}

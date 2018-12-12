using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form2 settingsform;
        int laskin = 0;
        int project = 0;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            laskin++;
            richTextBox1.AppendText(DateTime.Now.ToString("HH:MM ") + (laskin.ToString()) + "\n");
            richTextBox1.ScrollToCaret();
            label1.Text = Convert.ToString(laskin);
            save_counter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(laskin > 0)
                laskin--;
            label1.Text = Convert.ToString(laskin);
            save_counter();
        }

        private void save_counter()
        {
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Properties.Settings.Default.Project_click);
            laskin = Convert.ToInt32(Properties.Settings.Default.Project_click);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            settingsform = new Form2();
            settingsform.Show();
        }
    }
}

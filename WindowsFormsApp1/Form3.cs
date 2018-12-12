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
    public partial class Form3 : Form
    {
        public Form2 settingsForm;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Project_click)
            {
                case 1:
                    Properties.Settings.Default.Project1 = textBox1.Text;
                    settingsForm.change_label(textBox1.Text);
                    break;
                case 2:
                    Properties.Settings.Default.Project2 = textBox1.Text;
                    settingsForm.label2.Text = Properties.Settings.Default.Project2;
                    break;
                case 3:
                    Properties.Settings.Default.Project3 = textBox1.Text;
                    break;
                case 4:
                    Properties.Settings.Default.Project4 = textBox1.Text;
                    settingsForm.label4.Text = Properties.Settings.Default.Project4;
                    break;
                case 5:
                    Properties.Settings.Default.Project5 = textBox1.Text;
                    settingsForm.label5.Text = Properties.Settings.Default.Project5;
                    break;
                case 6:
                    Properties.Settings.Default.Project6 = textBox1.Text;
                    settingsForm.label6.Text = Properties.Settings.Default.Project6;
                    break;
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            settingsForm = new Form2();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsForm.change_label("AAA");
            settingsForm.Show();
        }
    }
}

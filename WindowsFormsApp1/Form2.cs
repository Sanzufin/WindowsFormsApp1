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
    public partial class Form2 : Form
    {
        public Form3 textform;
        public Form2()
        {
            InitializeComponent();
        }

        public void change_label(string i)
        {
            switch(Properties.Settings.Default.Project_click)
            {
                case 1:
                    label1.Text = i;
                    this.Update();
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch(Properties.Settings.Default.Project_click)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.Project1;
        }
        /* panel click pitäisi olla niin että se menee  form 1 ja label click pitäisi muuttaa tekstiä*/
        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            textform = new Form3();
            Properties.Settings.Default.Project_click = 1;
            textform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textform = new Form3();
            Properties.Settings.Default.Project_click = 2;
            textform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textform = new Form3();
            Properties.Settings.Default.Project_click = 3;
            textform.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textform = new Form3();
            Properties.Settings.Default.Project_click = 4;
            textform.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textform = new Form3();
            Properties.Settings.Default.Project_click = 5;
            textform.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textform = new Form3();
            Properties.Settings.Default.Project_click = 6;
            textform.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform
{
    public partial class payform : Form
    {
        searchForm sf = new searchForm();
        public payform()
        {
            InitializeComponent(); 
            sf.pf = this;
        }

        private void payform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;

        }       
        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();

        }
        confirm_form cf = new confirm_form();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Contains("140112028031"))
            {
                textBox1.Text = "";
                cf.Show();
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

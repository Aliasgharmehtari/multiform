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
    public partial class confirm_form : Form
    {
        public payform pf;
        public confirm_form()
        {
            InitializeComponent();
                      
            listBox1.Items.Add("پرداخت شهریه دانشجو مریم صمیمی با موفقیت انجام شد ");
        }
        
        private void confirm_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}

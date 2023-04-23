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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        payform pf = new payform();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Contains("admin")&&textBox2.Text.Contains("admin"))
            {
                pf.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده نادرست است، دوباره تلاش کنید ");
            }
                
        }
    }
}

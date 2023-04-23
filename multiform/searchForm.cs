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
    public partial class searchForm : Form
    {
        public payform pf;
        public searchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("مریم"))
            {
              pf.textBox1.Text = "140112028031";
              this.Hide();
            }
        }
    }
}

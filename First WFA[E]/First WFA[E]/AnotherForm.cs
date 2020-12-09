using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_WFA_E_
{
    public partial class AnotherForm : Form
    {
        MyForm mf;
        public AnotherForm(MyForm mf)
        {
            this.mf = mf;
            InitializeComponent();
            label1.Text += mf.TextBox1.Text;
        }

        private void AnotherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mf.Show();
            //MyForm m = new MyForm();
            //m.Show();
            this.Hide();
        }
    }
}

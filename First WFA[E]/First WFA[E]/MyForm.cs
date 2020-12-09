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
    public partial class MyForm : Form
    {
        public TextBox TextBox1
        {
            get { return textBox1; }
        }
        public MyForm()
        {
            InitializeComponent();
            //this.Text = "First WFA";
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            //if(clickButton.Text=="Click")
            //{
            //    clickButton.Text = "Hello";
            //}
            //else
            //{
            //    clickButton.Text = "Click";
            //}

            //label1.Text += textBox1.Text;

            if (textBox1.Text == "")
            {
                DialogResult result=MessageBox.Show("Textbox is empty. Do you want to continue?","Confirmation",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AnotherForm af = new AnotherForm(this);
                    af.Show();
                    this.Hide();
                }
            }
            else
            {
                AnotherForm af = new AnotherForm(this);
                af.Show();
                this.Hide();
            }
        }
    }
}

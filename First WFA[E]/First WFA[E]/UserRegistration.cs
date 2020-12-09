using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_WFA_E_
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[E]"].ConnectionString);
            connection.Open();
            string gen = null;
            if (radioButton1.Checked)
            {
                gen = radioButton1.Text;
            }
            else
            {
                gen = radioButton2.Text;
            }
            string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('" + nameTextBox.Text + "','" + usernameTextBox.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + dateOfBirthDateTimePicker.Text + "','" + gen + "','" + comboBox1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            //ExecuteReader()->Data Read
            //ExecuteNonQuery()->Insert,Upate,Delete
            //ExecuteScalar()->Aggregate Function
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("User added successfully.");
                nameTextBox.Text = usernameTextBox.Text = textBox3.Text = textBox4.Text = textBox5.Text = dateOfBirthDateTimePicker.Text = comboBox1.Text = string.Empty;
                radioButton1.Checked = radioButton2.Checked = checkBox1.Checked = false;
            }
            else
            {
                MessageBox.Show("Error in user adding.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDataLoadForm lf = new UserDataLoadForm();
            lf.Show();
            this.Hide();
        }
    }
}

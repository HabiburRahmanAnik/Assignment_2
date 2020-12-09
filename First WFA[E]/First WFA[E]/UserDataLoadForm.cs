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
    public partial class UserDataLoadForm : Form
    {
        public UserDataLoadForm()
        {
            InitializeComponent();
        }

        private void UserDataLoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserDataLoadForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(sql,connection);
            SqlDataReader reader= command.ExecuteReader();
            List<User> list = new List<User>();
            while(reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();

                list.Add(user);
            }

            dataGridView1.DataSource = list;
        }
    }
}

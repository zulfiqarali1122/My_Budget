using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AddEmploye : Form
    {
        public AddEmploye()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
                gender = "male";
            else
                gender = "female";

            MySqlConnection con = new MySqlConnection("Server=\"localhost\";Database=\"employee_management\";Uid=\"root\";Pwd=\'\'");
            MySqlCommand cmd = new($"insert into employee(name, gender, address) VALUES('{textBox1.Text}', '{gender}', '{textBox3.Text}')", con);
            con.Open();
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {

            }
            con.Close();
            MessageBox.Show("Submited");
        }
    }
}

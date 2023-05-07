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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagement
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=\"localhost\";Database=\"employee_management\";Uid=\"root\";Pwd=\'\'");
            MySqlCommand cmd = new($"insert into project(emp_id, name) VALUES('{int.Parse(textBox1.Text)}', '{textBox2.Text}')", con);
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

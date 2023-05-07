using MySql.Data.MySqlClient;
using System.Data;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=\"localhost\";Database=\"employee_management\";Uid=\"root\";Pwd=\'\'");
            MySqlCommand cmd = new("select * from employee", con);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable mydata = new DataTable();
            adp.Fill(mydata);
            dataGridView1.DataSource = mydata;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=\"localhost\";Database=\"employee_management\";Uid=\"root\";Pwd=\'\'");
            MySqlCommand cmd = new("SELECT `d`.`name`, `d`.`location`, `e`.`name`, `e`.`gender`, `e`.`address`, `p`.`name`\r\nFROM department d JOIN employee e ON d.emp_id=e.id JOIN project p ON p.pro_id=d.pro_id", con);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable mydata = new DataTable();
            adp.Fill(mydata);
            dataGridView1.DataSource = mydata;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=\"localhost\";Database=\"employee_management\";Uid=\"root\";Pwd=\'\'");
            MySqlCommand cmd = new("select * from project", con);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable mydata = new DataTable();
            adp.Fill(mydata);
            dataGridView1.DataSource = mydata;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEmploye emp = new AddEmploye();
            emp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProject p = new AddProject();
            p.Show();
        }
    }
}
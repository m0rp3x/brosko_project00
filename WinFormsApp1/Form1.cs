using MySql.Data.MySqlClient;
using System.Data;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("Select * from datebase_with_cute_ass", conn);
            

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(textBox1.Text, conn);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"Select * from datebase_with_cute_ass where Email = '{textBox3.Text}'", conn);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

      

       

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"Select COUNT(*) AS status from datebase_with_cute_ass where status = 'online'", conn);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView3.DataSource = dataSet.Tables[0];

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("Select * FROM for_discord_bot", conn);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView2.DataSource = dataSet.Tables[0];
        }

      

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
            MySqlConnection conn = new MySqlConnection(constr.ToString());
            conn.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"Select * from datebase_with_cute_ass where Email = '{textBox2.Text}'", conn);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView2.DataSource = dataSet.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                MySqlConnectionStringBuilder constr = new MySqlConnectionStringBuilder($"Server=109.120.190.242;Database =datebaseass;Uid=root;pwd=qBND9KgPur9jAxDwcRrEmReN7y2HBwWFYTYc;charset=utf8");
                MySqlConnection conn = new MySqlConnection(constr.ToString());
                conn.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(textBox4.Text, conn);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
            
                dataGridView2.DataSource = dataSet.Tables[0];
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
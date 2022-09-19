using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Configuration;

namespace WinFormsApp1
{
    
    
    
    public partial class Form1 : Form
    {
        MySqlConnection xyi = ConnectWithDB().Result;        

        public static async Task<MySqlConnection> ConnectWithDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);
            var constr = new MySqlConnection(connectionString);
            
            return constr;
        }
        



        
        
        public Form1() => InitializeComponent();

        public async void Form1_Load(object sender, EventArgs e)
        {
            
            xyi.Open();

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)

        {

            

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("Select * from datebase_with_cute_ass", xyi);


            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
            
            xyi.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(textBox1.Text, xyi);
            MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter(
                $"INSERT INTO `datebase_with_cute_ass`(`Name`, `Email`, `Tier`) VALUES({textBox9.Text}, {textBox8.Text}, {textBox10.Text})",
                xyi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
            xyi.Close();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            MySqlDataAdapter dataAdapter =
                new MySqlDataAdapter($"Select * from datebase_with_cute_ass where Email = '{textBox3.Text}'", xyi);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            
            xyi.Close();
        }
        





        private void button5_Click(object sender, EventArgs e)
        {
           xyi.Open();

            MySqlDataAdapter dataAdapter =
                new MySqlDataAdapter($"Select COUNT(*) AS status from datebase_with_cute_ass where status = 'online'",
                    xyi);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView3.DataSource = dataSet.Tables[0];
            xyi.Close();
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
            

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("Select * FROM for_discord_bot", xyi);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView2.DataSource = dataSet.Tables[0];
            xyi.Close();
        }



        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            

            MySqlDataAdapter dataAdapter =
                new MySqlDataAdapter($"Select * from datebase_with_cute_ass where Email = '{textBox2.Text}'", xyi);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView2.DataSource = dataSet.Tables[0];
            
            xyi.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {


            

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(textBox4.Text, xyi);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView2.DataSource = dataSet.Tables[0];

            xyi.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            xyi.Open();

            MySqlCommand command;



            string abobka =
                $"INSERT INTO `datebase_with_cute_ass`(`Name`, `Email`, `Tier`,status) VALUES(@name, @email, @tier,'offline')";
            using (command = new MySqlCommand(abobka, xyi))
            {
                MySqlParameter nameParam = new MySqlParameter("@name", textBox9.Text);
                MySqlParameter nameParam2 = new MySqlParameter("@email", textBox8.Text);
                MySqlParameter nameParam3 = new MySqlParameter("@tier", textBox10.Text);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(nameParam2);
                command.Parameters.Add(nameParam3);
                MySqlDataReader reader;
                command.ExecuteReader();



                xyi.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

            MySqlCommand command;
            MySqlDataAdapter dataAdapter =
                new MySqlDataAdapter($"Select * from datebase_with_cute_ass where Email = '{textBox8.Text}'", xyi);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView4.DataSource = dataSet.Tables[0];

            textBox9.Clear();
            textBox8.Clear();
            textBox10.Clear();
        
            xyi.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            xyi.Open();
            string abobka = "DELETE from datebase_with_cute_ass where Email = @email";
            MySqlCommand command;
            using (command = new MySqlCommand(abobka, xyi))
            {
                MySqlParameter nameParam = new MySqlParameter("@email", textBox3.Text);
                command.Parameters.Add(nameParam);
                MySqlDataReader reader;
                command.ExecuteReader();
                xyi.Close();
            }
            

            textBox3.Clear();
        }
    }
}
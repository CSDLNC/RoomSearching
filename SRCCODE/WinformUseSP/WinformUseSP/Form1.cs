using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WinformUseSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demo02DataSet.KhachSan' table. You can move, or remove it, as needed.
            this.khachSanTableAdapter.Fill(this.demo02DataSet.KhachSan);
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ViDu1"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                //// So sao
                //SqlCommand command = new SqlCommand("SP_ChonSoSao", connection);
                //command.CommandType = CommandType.StoredProcedure; 
                //command.Connection = connection;

                //SqlDataAdapter adapter = new SqlDataAdapter(command);

                //DataTable table = new DataTable();

                //adapter.Fill(table);

                //sosao.DisplayMember = "soSao";
                //sosao.ValueMember = "maKS";
                //sosao.DataSource = table;

                //// Thanh pho
                //SqlCommand command1 = new SqlCommand("SP_ChonThanhPho", connection);
                //command1.CommandType = CommandType.StoredProcedure;
                //command1.Connection = connection;

                //SqlDataAdapter adapter1 = new SqlDataAdapter(command1);

                //DataTable table1 = new DataTable();

                //adapter1.Fill(table1);

                //thanhpho.DisplayMember = "thanhPho";
                //thanhpho.ValueMember = "maKS";
                //thanhpho.DataSource = table1;

                //// Gia TB
                //SqlCommand command2 = new SqlCommand("SP_ChonGiaTB", connection);
                //command2.CommandType = CommandType.StoredProcedure;
                //command2.Connection = connection;

                //SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

                //DataTable table2 = new DataTable();

                //adapter2.Fill(table2);

                //giatb1.DisplayMember = "giaTB";
                //giatb1.ValueMember = "maKS";
                //giatb1.DataSource = table2;

            }
            catch (Exception exc)
            {
                // Xử lý Exception
                Console.WriteLine("Error {0}", exc.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ViDu1"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            
          
            connection.Open();

            SqlCommand command3 = new SqlCommand();
            command3.CommandType = CommandType.StoredProcedure;
            command3.Connection = connection;
            command3.CommandText = "SP_SearchHotelInform";

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            
            
            command3.Parameters.Add("@City", SqlDbType.NVarChar, 30).Value = Convert.ToString(textBox2.Text);
            
            if(textBox1.Text != null || textBox3.Text != null)
            {
                command3.Parameters.Add("@voteStar", SqlDbType.Int, 50).Value = Convert.ToInt32(textBox1.Text);
                command3.Parameters.Add("@Price", SqlDbType.Money).Value = Convert.ToDecimal(textBox3.Text);
            }

            else 
            {
                MessageBox.Show("Thanh pho khong duoc de trong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

            SqlDataReader dtReader = command3.ExecuteReader();
            dt.Load(dtReader);

            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Khong tim thay thong tin khach san", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
            connection.Close();
            connection.Dispose();
            
                
            
        }

        private void sosao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thanhpho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void giatb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

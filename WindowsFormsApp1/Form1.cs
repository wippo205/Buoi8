using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ketnoi kn = new ketnoi();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = kn.connect;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            try
            {
                connsql.Open();

                
                string insertQuery = "INSERT INTO Khoa (TenKhoa) VALUES (@TenKhoa)";
                SqlCommand command = new SqlCommand(insertQuery, connsql);

                // Truyền giá trị trực tiếp vào các tham số @MaKhoa và @TenKhoa
                command.Parameters.AddWithValue("@TenKhoa", "Khoa ThucPham");

                command.ExecuteNonQuery();
                MessageBox.Show("Dữ liệu Khoa đã được thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connsql.Close();
            }
        }
        public class ketnoi
        {
            public SqlConnection connect;
            public ketnoi()
            {
                connect = new SqlConnection("Data Source = LAPTOP-L0J0D79V\\WIPPOO; Initial Catalog = Net; Integrated Security = True");
            }
            public ketnoi(string strcn)
            {
                connect = new SqlConnection(strcn);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-L0J0D79V\\WIPPOO; Initial Catalog=Net; Integrated Security=True"))
            {
                connection.Open();
                string selectQuery = "SELECT MaKhoa, TenKhoa FROM Khoa";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                string MaKhoa = row.Cells["Ma Khoa"].Value.ToString();
                string TenKhoa = row.Cells["Ten Khoa"].Value.ToString();

                MessageBox.Show($"MaKhoa: {MaKhoa}, TenKhoa: {TenKhoa}");
            }
        }
    }
}

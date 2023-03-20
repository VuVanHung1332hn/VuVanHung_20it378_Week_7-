using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_Connection
{
    public partial class NhapInfo : Form
    {
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\File năm 3 kì 2\Lập trình web nâng cao (1)\Bài tập web ngày 15_3\STUDENT_MANAGEMENT.mdf"";Integrated Security=True;Connect Timeout=30";
        // Đối tượng kết nối
        SqlConnection sqlCon = null;
        public NhapInfo()
        {
            InitializeComponent();
        }

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand command = new SqlCommand($"Select count(*) from STUDENT Where ClassID='{txtClassID.Text}'", sqlCon);

            int result = (int)command.ExecuteScalar();
            txtNumber.Text = result.ToString();
            sqlCon.Close();
        }
    }
}

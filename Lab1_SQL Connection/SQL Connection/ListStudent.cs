using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Connection
{
    public partial class ListStudent : Form
    {
        public ListStudent()
        {
            InitializeComponent();
        }

        //tạo 2 biến cục bộ
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\File năm 3 kì 2\Lập trình web nâng cao (1)\Bài tập web ngày 15_3\STUDENT_MANAGEMENT.mdf"";Integrated Security=True;Connect Timeout=30";
        // Đối tượng kết nối
        SqlConnection sqlCon = null;

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"select * from Class where ClassID ='{txtEnterClassID.Text}'";
            command.Connection = sqlCon;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtClassID.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }
            sqlCon.Close();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand command = new SqlCommand($"select * from Student where ClassID='{txtEnterClassID}'",sqlCon);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentID);

                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudents.Items.Add(item);
            }
            sqlCon.Close();
        }

        
    }
}

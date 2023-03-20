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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\File năm 3 kì 2\Lập trình web nâng cao (1)\Bài tập web ngày 15_3\STUDENT_MANAGEMENT.mdf"";Integrated Security=True;Connect Timeout=30";
        // Đối tượng kết nối
        SqlConnection sqlCon = null;
        

        private void Form4_Load(object sender, EventArgs e)
        {
            ViewListofStudents();
        }

        private void ViewListofStudents()
        {
            lvwStudent.Items.Clear();
            if(sqlCon == null ) 
            { 
                sqlCon = new SqlConnection(strCon);
            }
            if(sqlCon.State == ConnectionState.Closed) 
            { 
                sqlCon.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Student", sqlCon);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malop = reader.GetString(2);
                ListViewItem item = lvwStudent.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
            }
            sqlCon.Close();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand command = new SqlCommand($"update Student set Name ='{txtName.Text}', ClassID='{txtClassID.Text}' where StudentID='{txtStudentID.Text}'",sqlCon);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Cập nhật thất bại!!!");
            }

            if(result > 0)
            {
                ViewListofStudents();
            }
            
        }

        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
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
            command.Connection = sqlCon;
            command.CommandText = "insert into Student(StudentID, Name, ClassID)" +
                "values(@StudentID, @Name, @ClassID)";
            SqlParameter parameter1 = new SqlParameter("@StudentID", txtStudentID.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@Name", txtName.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("ClassID", txtClassID.Text);
            command.Parameters.Add(parameter3);

            try
            {
                result = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Thêm thông tin không thành công!!!");

            }

            if(result > 0)
            {
                ViewListofStudents();
            }


        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwStudent.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lvwStudent.SelectedItems[0].SubItems[0].Text;
                txtName.Text= lvwStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lvwStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand command = new SqlCommand($"delete from Student where StudentID='{txtStudentID.Text}'",sqlCon);
            try
            {
                result = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Xóa Không thành công!!!");
            }

            if( result > 0 )
            {
                ViewListofStudents();
                txtStudentID.Text = "";
                txtName.Text = "";
                txtClassID.Text = "";
            }
        }
    }
}

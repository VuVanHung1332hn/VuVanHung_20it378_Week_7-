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

namespace SQL_DATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\File năm 3 kì 2\Lập trình web nâng cao (1)\Bài tập web ngày 15_3\STUDENT_MANAGEMENT.mdf"";Integrated Security=True;Connect Timeout=30";
        // Đối tượng kết nối
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Student", strCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Student");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtgStudent.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            //Create a new row
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtStudentID.Text;
            row["Name"] = txtStudentName.Text;
            ds.Tables[0].Rows.Add(row);
            //Update Adapter
            try
            {
                adapter.Update(ds, "Student");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại \n" + ex.Message);
            }
            if(result > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
        }
        int position = -1;
        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if(position == -1)
            {
                MessageBox.Show("Không có hàng để chọn");
                return;

            }
            DataRow row = ds.Tables[0].Rows[position];
            txtStudentID.Text = row[0].ToString();
            txtStudentName.Text = row["Name"].ToString();
            txtClassID.Text = row[2].ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(position == -1)
            {
                MessageBox.Show("Không có hàng để chọn");
                return;
            }
            DataRow row = ds.Tables[0].Rows[position];

            row.BeginEdit();
            row[0] = txtStudentID.Text;
            row[1] = txtStudentName.Text;
            row[2] = txtClassID.Text;
            row.EndEdit();

            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công!!!");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(position == -1) 
            {
                return;
            }
            DataRow row = ds.Tables[0].Rows[position];
            row.Delete();
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Xoá thành công!!!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        

       
    }
}

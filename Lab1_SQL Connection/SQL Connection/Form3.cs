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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //tạo 2 biến cục bộ
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\File năm 3 kì 2\Lập trình web nâng cao (1)\Bài tập web ngày 15_3\STUDENT_MANAGEMENT.mdf"";Integrated Security=True;Connect Timeout=30";
        // Đối tượng kết nối
        SqlConnection sqlCon = null;
        private void Form3_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed) 
            { 
                sqlCon.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Class",sqlCon);

            //Execute SQL Command

            lsbClass.ClearSelected();
            SqlDataReader reader = command.ExecuteReader(); //Execute SQL Command
            while (reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = classID + "-" + className + "-" + year.ToString();
                lsbClass.Items.Add(line);
            }
            sqlCon.Close();

        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudent.Items.Clear();
            if (lsbClass.SelectedIndex == -1)  return; 
            string line = lsbClass.SelectedItems.ToString();
            string[] array = line.Split('-');
            string classID = array[0];

            if (sqlCon == null) 
            { 
                sqlCon= new SqlConnection(strCon);
            }
            if(sqlCon.State == ConnectionState.Closed) 
            { 
                sqlCon.Open(); 
            }
            SqlCommand command = new SqlCommand("Select * from Student where ClassID='{classID}'",sqlCon);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classIDRow = reader.GetString (2);
                ListViewItem item = lsvStudent.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);
            }
            sqlCon.Close();
        }

        private void lsvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

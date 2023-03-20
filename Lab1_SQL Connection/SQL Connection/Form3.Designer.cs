namespace SQL_Connection
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbClass = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvStudent = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classIDRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbClass);
            this.groupBox1.Location = new System.Drawing.Point(13, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lsbClass
            // 
            this.lsbClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsbClass.FormattingEnabled = true;
            this.lsbClass.ItemHeight = 20;
            this.lsbClass.Location = new System.Drawing.Point(3, 18);
            this.lsbClass.Name = "lsbClass";
            this.lsbClass.Size = new System.Drawing.Size(316, 216);
            this.lsbClass.TabIndex = 0;
            this.lsbClass.SelectedIndexChanged += new System.EventHandler(this.lsbClass_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvStudent);
            this.groupBox2.Location = new System.Drawing.Point(359, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lsvStudent
            // 
            this.lsvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.name,
            this.classIDRow});
            this.lsvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsvStudent.FullRowSelect = true;
            this.lsvStudent.GridLines = true;
            this.lsvStudent.HideSelection = false;
            this.lsvStudent.Location = new System.Drawing.Point(3, 18);
            this.lsvStudent.Name = "lsvStudent";
            this.lsvStudent.Size = new System.Drawing.Size(439, 216);
            this.lsvStudent.TabIndex = 0;
            this.lsvStudent.UseCompatibleStateImageBehavior = false;
            this.lsvStudent.View = System.Windows.Forms.View.Details;
            this.lsvStudent.SelectedIndexChanged += new System.EventHandler(this.lsvStudent_SelectedIndexChanged);
            // 
            // studentID
            // 
            this.studentID.Text = "Student ID";
            this.studentID.Width = 100;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // classIDRow
            // 
            this.classIDRow.Text = "Class ID";
            this.classIDRow.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách các lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách các học sinh";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvStudent;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader classIDRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
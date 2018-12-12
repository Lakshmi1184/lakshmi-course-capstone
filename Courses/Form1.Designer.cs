namespace Courses
{
    partial class frmStudentCoursesDetails
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
            this.components = new System.ComponentModel.Container();
            this._Service_based_Database1DataSet = new Courses._Service_based_Database1DataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Courses._Service_based_Database1DataSetTableAdapters.coursesTableAdapter();
            this.tableAdapterManager = new Courses._Service_based_Database1DataSetTableAdapters.TableAdapterManager();
            this.cmbCourseNumber = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtNumberCourses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblStudentFullName = new System.Windows.Forms.Label();
            this.txtStudentFullName = new System.Windows.Forms.TextBox();
            this.txtNumberOfCourses = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.lblNumberOfCourses = new System.Windows.Forms.Label();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.rdOnline = new System.Windows.Forms.RadioButton();
            this.rdHybrid = new System.Windows.Forms.RadioButton();
            this.txtCourseStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlDataComponents = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._Service_based_Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.pnlDataComponents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Service_based_Database1DataSet
            // 
            this._Service_based_Database1DataSet.DataSetName = "_Service_based_Database1DataSet";
            this._Service_based_Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this._Service_based_Database1DataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Courses._Service_based_Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbCourseNumber
            // 
            this.cmbCourseNumber.DataSource = this.coursesBindingSource;
            this.cmbCourseNumber.DisplayMember = "CourseNumber";
            this.cmbCourseNumber.FormattingEnabled = true;
            this.cmbCourseNumber.Location = new System.Drawing.Point(350, 184);
            this.cmbCourseNumber.Name = "cmbCourseNumber";
            this.cmbCourseNumber.Size = new System.Drawing.Size(165, 28);
            this.cmbCourseNumber.TabIndex = 1;
            this.cmbCourseNumber.ValueMember = "CourseNumber";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(350, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(350, 84);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(165, 26);
            this.txtSecondName.TabIndex = 3;
            // 
            // txtNumberCourses
            // 
            this.txtNumberCourses.Location = new System.Drawing.Point(350, 134);
            this.txtNumberCourses.Name = "txtNumberCourses";
            this.txtNumberCourses.Size = new System.Drawing.Size(165, 26);
            this.txtNumberCourses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of courses ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Course Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course Type";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(664, 46);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(104, 37);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 37);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(665, 120);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(103, 37);
            this.btnGet.TabIndex = 16;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblStudentFullName
            // 
            this.lblStudentFullName.AutoSize = true;
            this.lblStudentFullName.Location = new System.Drawing.Point(49, 32);
            this.lblStudentFullName.Name = "lblStudentFullName";
            this.lblStudentFullName.Size = new System.Drawing.Size(145, 20);
            this.lblStudentFullName.TabIndex = 18;
            this.lblStudentFullName.Text = "Student Full Name:";
            // 
            // txtStudentFullName
            // 
            this.txtStudentFullName.Location = new System.Drawing.Point(228, 29);
            this.txtStudentFullName.Name = "txtStudentFullName";
            this.txtStudentFullName.ReadOnly = true;
            this.txtStudentFullName.Size = new System.Drawing.Size(165, 26);
            this.txtStudentFullName.TabIndex = 19;
            // 
            // txtNumberOfCourses
            // 
            this.txtNumberOfCourses.Location = new System.Drawing.Point(228, 76);
            this.txtNumberOfCourses.Name = "txtNumberOfCourses";
            this.txtNumberOfCourses.ReadOnly = true;
            this.txtNumberOfCourses.Size = new System.Drawing.Size(165, 26);
            this.txtNumberOfCourses.TabIndex = 20;
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(228, 121);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.ReadOnly = true;
            this.txtCourseNumber.Size = new System.Drawing.Size(165, 26);
            this.txtCourseNumber.TabIndex = 21;
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(228, 167);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.ReadOnly = true;
            this.txtCourseType.Size = new System.Drawing.Size(165, 26);
            this.txtCourseType.TabIndex = 22;
            // 
            // lblNumberOfCourses
            // 
            this.lblNumberOfCourses.AutoSize = true;
            this.lblNumberOfCourses.Location = new System.Drawing.Point(49, 79);
            this.lblNumberOfCourses.Name = "lblNumberOfCourses";
            this.lblNumberOfCourses.Size = new System.Drawing.Size(153, 20);
            this.lblNumberOfCourses.TabIndex = 23;
            this.lblNumberOfCourses.Text = "Number Of Courses:";
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Location = new System.Drawing.Point(49, 121);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(124, 20);
            this.lblCourseNumber.TabIndex = 24;
            this.lblCourseNumber.Text = "Course Number:";
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Location = new System.Drawing.Point(49, 167);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(102, 20);
            this.lblCourseType.TabIndex = 25;
            this.lblCourseType.Text = "Course Type:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(49, 221);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(142, 20);
            this.lblStartDate.TabIndex = 26;
            this.lblStartDate.Text = "Course Start Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(228, 215);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(253, 26);
            this.txtStartDate.TabIndex = 27;
            // 
            // rdOnline
            // 
            this.rdOnline.AutoSize = true;
            this.rdOnline.Location = new System.Drawing.Point(436, 244);
            this.rdOnline.Name = "rdOnline";
            this.rdOnline.Size = new System.Drawing.Size(79, 24);
            this.rdOnline.TabIndex = 13;
            this.rdOnline.Text = "Online";
            this.rdOnline.UseVisualStyleBackColor = true;
            // 
            // rdHybrid
            // 
            this.rdHybrid.AutoSize = true;
            this.rdHybrid.Checked = true;
            this.rdHybrid.Location = new System.Drawing.Point(351, 242);
            this.rdHybrid.Name = "rdHybrid";
            this.rdHybrid.Size = new System.Drawing.Size(79, 24);
            this.rdHybrid.TabIndex = 12;
            this.rdHybrid.TabStop = true;
            this.rdHybrid.Text = "Hybrid";
            this.rdHybrid.UseVisualStyleBackColor = true;
            // 
            // txtCourseStartDate
            // 
            this.txtCourseStartDate.Location = new System.Drawing.Point(350, 306);
            this.txtCourseStartDate.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.txtCourseStartDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.txtCourseStartDate.Name = "txtCourseStartDate";
            this.txtCourseStartDate.Size = new System.Drawing.Size(296, 26);
            this.txtCourseStartDate.TabIndex = 28;
            this.txtCourseStartDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(664, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 37);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlDataComponents
            // 
            this.pnlDataComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataComponents.Controls.Add(this.btnExit);
            this.pnlDataComponents.Controls.Add(this.lblStudentFullName);
            this.pnlDataComponents.Controls.Add(this.txtStudentFullName);
            this.pnlDataComponents.Controls.Add(this.lblNumberOfCourses);
            this.pnlDataComponents.Controls.Add(this.txtNumberOfCourses);
            this.pnlDataComponents.Controls.Add(this.lblCourseNumber);
            this.pnlDataComponents.Controls.Add(this.txtStartDate);
            this.pnlDataComponents.Controls.Add(this.txtCourseNumber);
            this.pnlDataComponents.Controls.Add(this.lblStartDate);
            this.pnlDataComponents.Controls.Add(this.lblCourseType);
            this.pnlDataComponents.Controls.Add(this.txtCourseType);
            this.pnlDataComponents.Location = new System.Drawing.Point(67, 459);
            this.pnlDataComponents.Name = "pnlDataComponents";
            this.pnlDataComponents.Size = new System.Drawing.Size(728, 272);
            this.pnlDataComponents.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSet);
            this.panel2.Controls.Add(this.btnGet);
            this.panel2.Location = new System.Drawing.Point(64, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 399);
            this.panel2.TabIndex = 31;
            // 
            // frmStudentCoursesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 1050);
            this.Controls.Add(this.pnlDataComponents);
            this.Controls.Add(this.txtCourseStartDate);
            this.Controls.Add(this.rdHybrid);
            this.Controls.Add(this.rdOnline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberCourses);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cmbCourseNumber);
            this.Controls.Add(this.panel2);
            this.Name = "frmStudentCoursesDetails";
            this.Text = "StudentsCourseDetails";
            this.Load += new System.EventHandler(this.frmStudentCoursesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Service_based_Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.pnlDataComponents.ResumeLayout(false);
            this.pnlDataComponents.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Service_based_Database1DataSet _Service_based_Database1DataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private _Service_based_Database1DataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private _Service_based_Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCourseNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtNumberCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lblStudentFullName;
        private System.Windows.Forms.TextBox txtStudentFullName;
        private System.Windows.Forms.TextBox txtNumberOfCourses;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.Label lblNumberOfCourses;
        private System.Windows.Forms.Label lblCourseNumber;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.RadioButton rdOnline;
        private System.Windows.Forms.RadioButton rdHybrid;
        private System.Windows.Forms.DateTimePicker txtCourseStartDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlDataComponents;
        private System.Windows.Forms.Panel panel2;
    }
}


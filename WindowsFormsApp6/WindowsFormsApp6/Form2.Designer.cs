namespace WindowsFormsApp6
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marthscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radBirthday = new System.Windows.Forms.RadioButton();
            this.radGender = new System.Windows.Forms.RadioButton();
            this.radMarthscore = new System.Windows.Forms.RadioButton();
            this.radStudentID = new System.Windows.Forms.RadioButton();
            this.radName = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Yellow;
            this.tabPage1.Controls.Add(this.btnFix);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(38, 141);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(102, 29);
            this.btnFix.TabIndex = 18;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.StudentID,
            this.Gender,
            this.Birthday,
            this.Marthscore});
            this.dataGridView2.Location = new System.Drawing.Point(3, 278);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(787, 138);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 8;
            this.StudentID.Name = "StudentID";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 8;
            this.Birthday.Name = "Birthday";
            // 
            // Marthscore
            // 
            this.Marthscore.HeaderText = "Marthsore";
            this.Marthscore.MinimumWidth = 8;
            this.Marthscore.Name = "Marthscore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Marthscore";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(353, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(613, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 26);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "StudentID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2.Controls.Add(this.radBirthday);
            this.tabPage2.Controls.Add(this.radGender);
            this.tabPage2.Controls.Add(this.radMarthscore);
            this.tabPage2.Controls.Add(this.radStudentID);
            this.tabPage2.Controls.Add(this.radName);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // radBirthday
            // 
            this.radBirthday.AutoSize = true;
            this.radBirthday.Location = new System.Drawing.Point(251, 144);
            this.radBirthday.Name = "radBirthday";
            this.radBirthday.Size = new System.Drawing.Size(92, 24);
            this.radBirthday.TabIndex = 23;
            this.radBirthday.TabStop = true;
            this.radBirthday.Text = "Birthday";
            this.radBirthday.UseVisualStyleBackColor = true;
            // 
            // radGender
            // 
            this.radGender.AutoSize = true;
            this.radGender.Location = new System.Drawing.Point(251, 186);
            this.radGender.Name = "radGender";
            this.radGender.Size = new System.Drawing.Size(88, 24);
            this.radGender.TabIndex = 23;
            this.radGender.TabStop = true;
            this.radGender.Text = "Gender";
            this.radGender.UseVisualStyleBackColor = true;
            // 
            // radMarthscore
            // 
            this.radMarthscore.AutoSize = true;
            this.radMarthscore.Location = new System.Drawing.Point(514, 48);
            this.radMarthscore.Name = "radMarthscore";
            this.radMarthscore.Size = new System.Drawing.Size(114, 24);
            this.radMarthscore.TabIndex = 23;
            this.radMarthscore.TabStop = true;
            this.radMarthscore.Text = "Marthscore";
            this.radMarthscore.UseVisualStyleBackColor = true;
            // 
            // radStudentID
            // 
            this.radStudentID.AutoSize = true;
            this.radStudentID.Location = new System.Drawing.Point(251, 100);
            this.radStudentID.Name = "radStudentID";
            this.radStudentID.Size = new System.Drawing.Size(108, 24);
            this.radStudentID.TabIndex = 23;
            this.radStudentID.TabStop = true;
            this.radStudentID.Text = "StudentID";
            this.radStudentID.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(251, 45);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(76, 24);
            this.radName.TabIndex = 23;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(2, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(787, 146);
            this.dataGridView1.TabIndex = 22;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Name";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "StudentID";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Gender";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Birthday";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mathscore";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(356, 186);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox2.Location = new System.Drawing.Point(356, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(44, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 70);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(629, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(152, 26);
            this.textBox8.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(356, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(152, 26);
            this.textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(356, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 26);
            this.textBox6.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radBirthday;
        private System.Windows.Forms.RadioButton radGender;
        private System.Windows.Forms.RadioButton radMarthscore;
        private System.Windows.Forms.RadioButton radStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marthscore;
    }
}
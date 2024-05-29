using System.Windows.Forms;

namespace ElDee
{
    partial class AddStudent
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.dateBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.dateBirthLabel = new System.Windows.Forms.Label();
            this.secondNameTb = new System.Windows.Forms.TextBox();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.pathFileLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 40);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(732, 409);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 40);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 382);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.mainPanel);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить одного студента";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.groupComboBox);
            this.mainPanel.Controls.Add(this.groupLabel);
            this.mainPanel.Controls.Add(this.specialtyComboBox);
            this.mainPanel.Controls.Add(this.specialtyLabel);
            this.mainPanel.Controls.Add(this.departmentComboBox);
            this.mainPanel.Controls.Add(this.departmentLabel);
            this.mainPanel.Controls.Add(this.facultyComboBox);
            this.mainPanel.Controls.Add(this.facultyLabel);
            this.mainPanel.Controls.Add(this.dateBirthPicker);
            this.mainPanel.Controls.Add(this.dateBirthLabel);
            this.mainPanel.Controls.Add(this.secondNameTb);
            this.mainPanel.Controls.Add(this.secondNameLabel);
            this.mainPanel.Controls.Add(this.firstNameTb);
            this.mainPanel.Controls.Add(this.firstNameLabel);
            this.mainPanel.Controls.Add(this.lastNameTb);
            this.mainPanel.Controls.Add(this.lastNameLabel);
            this.mainPanel.Location = new System.Drawing.Point(30, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(813, 300);
            this.mainPanel.TabIndex = 3;
            // 
            // groupComboBox
            // 
            this.groupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.groupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.Enabled = false;
            this.groupComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupComboBox.IntegralHeight = false;
            this.groupComboBox.ItemHeight = 21;
            this.groupComboBox.Location = new System.Drawing.Point(400, 220);
            this.groupComboBox.MaxLength = 200;
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(370, 29);
            this.groupComboBox.TabIndex = 15;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupLabel.Location = new System.Drawing.Point(400, 200);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(71, 21);
            this.groupLabel.TabIndex = 14;
            this.groupLabel.Text = "Группа:";
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.specialtyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.specialtyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialtyComboBox.Enabled = false;
            this.specialtyComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyComboBox.IntegralHeight = false;
            this.specialtyComboBox.ItemHeight = 21;
            this.specialtyComboBox.Location = new System.Drawing.Point(400, 160);
            this.specialtyComboBox.MaxLength = 200;
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(370, 29);
            this.specialtyComboBox.TabIndex = 13;
            this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyComboBox_SelectedIndexChanged);
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.AutoSize = true;
            this.specialtyLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyLabel.Location = new System.Drawing.Point(400, 140);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(137, 21);
            this.specialtyLabel.TabIndex = 12;
            this.specialtyLabel.Text = "Специальность:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.Enabled = false;
            this.departmentComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentComboBox.IntegralHeight = false;
            this.departmentComboBox.ItemHeight = 21;
            this.departmentComboBox.Location = new System.Drawing.Point(400, 100);
            this.departmentComboBox.MaxLength = 200;
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(370, 29);
            this.departmentComboBox.TabIndex = 11;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.Location = new System.Drawing.Point(400, 80);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(83, 21);
            this.departmentLabel.TabIndex = 10;
            this.departmentLabel.Text = "Кафедра:";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.facultyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyComboBox.IntegralHeight = false;
            this.facultyComboBox.ItemHeight = 21;
            this.facultyComboBox.Location = new System.Drawing.Point(400, 40);
            this.facultyComboBox.MaxLength = 200;
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(370, 29);
            this.facultyComboBox.TabIndex = 9;
            this.facultyComboBox.SelectedIndexChanged += new System.EventHandler(this.facultyComboBox_SelectedIndexChanged);
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.Location = new System.Drawing.Point(400, 20);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(94, 21);
            this.facultyLabel.TabIndex = 8;
            this.facultyLabel.Text = "Факультет:";
            // 
            // dateBirthPicker
            // 
            this.dateBirthPicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBirthPicker.Location = new System.Drawing.Point(30, 220);
            this.dateBirthPicker.Name = "dateBirthPicker";
            this.dateBirthPicker.Size = new System.Drawing.Size(284, 29);
            this.dateBirthPicker.TabIndex = 7;
            this.dateBirthPicker.CustomFormat = "yyyy-MM-dd";
            this.dateBirthPicker.Format = DateTimePickerFormat.Custom;
            // 
            // dateBirthLabel
            // 
            this.dateBirthLabel.AutoSize = true;
            this.dateBirthLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBirthLabel.Location = new System.Drawing.Point(30, 200);
            this.dateBirthLabel.Name = "dateBirthLabel";
            this.dateBirthLabel.Size = new System.Drawing.Size(136, 21);
            this.dateBirthLabel.TabIndex = 6;
            this.dateBirthLabel.Text = "Дата рождения:";
            // 
            // secondNameTb
            // 
            this.secondNameTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameTb.Location = new System.Drawing.Point(30, 160);
            this.secondNameTb.MaxLength = 200;
            this.secondNameTb.Name = "secondNameTb";
            this.secondNameTb.Size = new System.Drawing.Size(284, 29);
            this.secondNameTb.TabIndex = 5;
            this.secondNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameLabel.Location = new System.Drawing.Point(30, 140);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(90, 21);
            this.secondNameLabel.TabIndex = 4;
            this.secondNameLabel.Text = "Отчество:";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTb.Location = new System.Drawing.Point(30, 100);
            this.firstNameTb.MaxLength = 200;
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(284, 29);
            this.firstNameTb.TabIndex = 3;
            this.firstNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(30, 80);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(48, 21);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Имя:";
            // 
            // lastNameTb
            // 
            this.lastNameTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTb.Location = new System.Drawing.Point(30, 40);
            this.lastNameTb.MaxLength = 200;
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(284, 29);
            this.lastNameTb.TabIndex = 1;
            this.lastNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(30, 20);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 21);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(876, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить несколько студентов из текстового файла";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(22, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 211);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата Рождения";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Группа";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Предварительный просмотр:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chooseFileButton);
            this.panel1.Controls.Add(this.pathFileLabel);
            this.panel1.Location = new System.Drawing.Point(22, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 44);
            this.panel1.TabIndex = 7;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.chooseFileButton.Location = new System.Drawing.Point(634, 0);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chooseFileButton.Size = new System.Drawing.Size(199, 42);
            this.chooseFileButton.TabIndex = 8;
            this.chooseFileButton.Text = "Выбрать";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // pathFileLabel
            // 
            this.pathFileLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pathFileLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pathFileLabel.Location = new System.Drawing.Point(0, 0);
            this.pathFileLabel.Name = "pathFileLabel";
            this.pathFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pathFileLabel.Size = new System.Drawing.Size(632, 42);
            this.pathFileLabel.TabIndex = 8;
            this.pathFileLabel.Text = "Выберите текстовый файл со студентами...";
            this.pathFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddStudent";
            this.ShowIcon = false;
            this.Text = "Форма добавления студентов";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.DateTimePicker dateBirthPicker;
        private System.Windows.Forms.Label dateBirthLabel;
        private System.Windows.Forms.TextBox secondNameTb;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pathFileLabel;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
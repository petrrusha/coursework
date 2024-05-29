namespace ElDee
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statistic_panel2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.searchTBox1 = new ElDee.SearchTBox();
            this.statusStr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myList1 = new ElDee.MyList();
            this.menuStrip1.SuspendLayout();
            this.statistic_panel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(598, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 329);
            this.panel1.TabIndex = 4;
            // 
            // statistic_panel2
            // 
            this.statistic_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statistic_panel2.Controls.Add(this.panel2);
            this.statistic_panel2.Controls.Add(this.label8);
            this.statistic_panel2.Controls.Add(this.label7);
            this.statistic_panel2.Location = new System.Drawing.Point(598, 27);
            this.statistic_panel2.Name = "statistic_panel2";
            this.statistic_panel2.Size = new System.Drawing.Size(552, 78);
            this.statistic_panel2.TabIndex = 7;
            this.statistic_panel2.Layout += new System.Windows.Forms.LayoutEventHandler(this.panel2_Layout);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 14);
            this.panel2.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel1.Location = new System.Drawing.Point(35, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "подробнее...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(550, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Статистика";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button1.Location = new System.Drawing.Point(514, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "🔍";
            this.toolTip1.SetToolTip(this.button1, "Найти");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTBox1
            // 
            this.searchTBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTBox1.DetectUrls = false;
            this.searchTBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchTBox1.Location = new System.Drawing.Point(12, 36);
            this.searchTBox1.Multiline = false;
            this.searchTBox1.Name = "searchTBox1";
            this.searchTBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.searchTBox1.Size = new System.Drawing.Size(507, 32);
            this.searchTBox1.TabIndex = 0;
            this.searchTBox1.Text = "";
            this.toolTip1.SetToolTip(this.searchTBox1, "Введите ФИО студента или номер группы");
            this.searchTBox1.WordWrap = false;
            this.searchTBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTBox1_KeyDown);
            // 
            // statusStr
            // 
            this.statusStr.BackColor = System.Drawing.SystemColors.Control;
            this.statusStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusStr.Location = new System.Drawing.Point(12, 71);
            this.statusStr.Name = "statusStr";
            this.statusStr.Size = new System.Drawing.Size(542, 23);
            this.statusStr.TabIndex = 9;
            this.statusStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 31);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(598, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Посмотреть учебный план";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(994, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(994, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(598, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Посмотреть успеваемость";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(598, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 33);
            this.panel3.TabIndex = 14;
            // 
            // myList1
            // 
            this.myList1.AutoScroll = true;
            this.myList1.BackColor = System.Drawing.Color.White;
            this.myList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myList1.Count = 0;
            this.myList1.Location = new System.Drawing.Point(12, 97);
            this.myList1.Name = "myList1";
            this.myList1.Size = new System.Drawing.Size(542, 450);
            this.myList1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTBox1);
            this.Controls.Add(this.myList1);
            this.Controls.Add(this.statistic_panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Электронный деканат";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statistic_panel2.ResumeLayout(false);
            this.statistic_panel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel statistic_panel2;
        private MyList myList1;
        private SearchTBox searchTBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label statusStr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
    }
}
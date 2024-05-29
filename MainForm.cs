using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ElDee
{
    public partial class MainForm : Form
    {
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Button infoButton;
        private int infoButtonFlag;




        public MainForm()
        {
            InitializeComponent();
            Panel3Setting();
            myList1.SelEvent += MyList1_MouseClick;
            myList1.CountChanged += MyList1_CountChanged;
            infoButton.Click += InfoButton_Click;

 
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            infoButtonFlag++;
            infoButtonFlag = infoButtonFlag == 2 ? 0 : infoButtonFlag;
            MyList1_MouseClick();
        }

        /// <summary>
        /// настройки для панели3
        /// </summary>
        private void Panel3Setting()
        {
            
            //последняя линия
            var sep1 = new Label() { BackColor = Color.AliceBlue, Dock = DockStyle.Bottom, Height = 10 };
            panel1.Controls.Add(sep1);
            //послднее текстовое
            l4 = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 15),
                Dock = DockStyle.Top,
                Height = 80
            };
            panel1.Controls.Add(l4);
            //третье текстовое 
            l3 = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 15),
                Dock = DockStyle.Top,
                Height = 80
            };
            panel1.Controls.Add(l3);
            //второе текстовое
            l2 = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 15),
                Dock = DockStyle.Top,
                Height = 80
            };
            panel1.Controls.Add(l2);
            //линия
            var sep = new Label() { BackColor = Color.AliceBlue, Dock = DockStyle.Top, Height = 10 };
            panel1.Controls.Add(sep);
            //первое главное текстовое
            l1 = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 15, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 60
            };
            panel1.Controls.Add(l1);


            infoButton = new Button()
            {
                BackgroundImage = Properties.Resources.info,
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(0, 0),
                Size = new Size(25, 25),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.Transparent },
                Dock = DockStyle.Right,
                Enabled = false,
            };

            panel3.Controls.Add(infoButton);
            infoButton.BringToFront();

        }
        
        private void MyList1_CountChanged()
        {
            if (myList1.Count == 0)
            {
                //button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                RightPanelCleaner();

            }
        }


        void RightPanelCleaner()
        {
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            label1.Text = "";
            infoButton.Enabled = false;
            infoButtonFlag = 0;
        }

        private void MyList1_MouseClick()
        {
            //При нажатии на элемент MyList1'а отобразить на правой панели информацию об этом элементе
            //Отслеживаем что нажали
            if (myList1.SelectedItem.IsStudent)
            {
                //ЕСЛИ выделенный элемент это студент
                var groupNumber = myList1.SelectedItem.Text4.Substring(myList1.SelectedItem.Text4.Length - 3, 3);
                //Обзываем текст над правой панелью 
                label1.Text = @"Личное дело студента";
                //запрос
                var info1 = Db.SqlSelect($@"SELECT Faculties.name, Departments.name, Specialties.name 
                FROM Faculties, Departments, Specialties, Groups 
                WHERE Groups.group_number = '{groupNumber}' AND 
                Groups.specialty_id = Specialties.id AND 
                Specialties.department_id = Departments.id AND 
                Departments.faculty_id = Faculties.id");

                var info2 =
                    Db.SqlSelect(
                        $@"SELECT Students.date_of_birth FROM Students WHERE Students.id = {myList1.SelectedItem.Id}");
                if (infoButtonFlag == 0)
                {
                    //послднее текстовое
                    l4.Text = $"Специальность: {info1[0][2]}";
                    //третье текстовое
                    l3.Text = $"Кафедра: {info1[0][1]}";
                    //второе текстовое
                    l2.Text = info1[0][0];
                }
                else
                {
                    //послднее текстовое
                    l4.Text = $"Курс: {myList1.SelectedItem.Text4.Substring(myList1.SelectedItem.Text4.IndexOf('-') + 1, 1)}";
                    //третье текстовое
                    l3.Text = $@"Группа: {myList1.SelectedItem.Text4}";
                    //второе текстовое
                    l2.Text = $@"Дата рождения: {DateTime.Parse(info2[0][0]).ToLongDateString()}";
                }

                //первое главное текстовое
                l1.Text = $"{myList1.SelectedItem.Text1} {myList1.SelectedItem.Text2} {myList1.SelectedItem.Text3}";
                //управление кнопками
                //button2.Text = @"Посмотреть учебный план";
                button3.Text = @"Редактировать";
                button4.Text = @"Удалить";
                button5.Text = @"Посмотреть успеваемость";
                if (myList1.Count != 0)
                {
                    //button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    infoButton.Enabled = true;
                }
            }
            else 
            {
                //ЕСЛИ выделенный элемент это Группа
                var groupNumber = myList1.SelectedItem.Text1.Substring(myList1.SelectedItem.Text1.Length - 3, 3);
                //Обзываем текст над правой панелью
                label1.Text = @"Информация о группе";
                //запрос

                //запрос
                var info1 = Db.SqlSelect($@"SELECT Faculties.name, Departments.name, Specialties.name 
                FROM Faculties, Departments, Specialties, Groups 
                WHERE Groups.group_number = '{groupNumber}' AND 
                Groups.specialty_id = Specialties.id AND 
                Specialties.department_id = Departments.id AND 
                Departments.faculty_id = Faculties.id");

                var info2 = Db.SqlSelect($@"SELECT
                creation_date
                FROM Groups 
                WHERE Groups.group_number = '{groupNumber}'");

                if (infoButtonFlag == 0)
                {
                    //послднее текстовое
                    l4.Text = $"Специальность: {info1[0][2]}";
                    //третье текстовое
                    l3.Text = $"Кафедра: {info1[0][1]}";
                    //второе текстовое
                    l2.Text = info1[0][0];
                }
                else
                {
                    //последнее текстовое
                    l4.Text = "";
                    //третье текстовое
                    l3.Text = $"Группа создана: {DateTime.Parse(info2[0][0]).ToLongDateString()}";
                    //второе текстовое
                    l2.Text = myList1.SelectedItem.Text2;
                }



                //первое главное текстовое
                l1.Text = myList1.SelectedItem.Text1;
                //управление кнопками
                //button2.Text = @"Посмотреть учебный план";
                button3.Text = @"Список студентов группы";
                button4.Text = @"Удалить";
                button5.Text = @"Посмотреть успеваемость";

                if (myList1.Count != 0)
                {
                    //button2.Enabled = true;
                    button3.Enabled = true;
                    infoButton.Enabled = true;
                }
            }


            
        }



        //нажатие кнопки найти
        private void button1_Click(object sender, EventArgs e)
        {
            string myStr;
            List<string[]> b = null;
            //запросы в БД
            //поиск
            if (searchTBox1.Text.Length != 0)
                if (char.IsLetter(searchTBox1.Text[0]))
                {
                    myStr = searchTBox1.Text.Replace(' ', '%') + "%";
                    b = Db.SqlSelect($@"SELECT
                            last_name,
                            first_name,
                            second_name,
                            (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number),
                            Students.id 
                            FROM
                            Students, Groups, Faculties, Specialties, Departments 
                            WHERE 
                            (((first_name + second_name + last_name) LIKE '{myStr}' OR 
                            (first_name + last_name + second_name) LIKE '{myStr}' OR 
                            (last_name + first_name + second_name) LIKE '{myStr}' OR 
                            (last_name + second_name + first_name) LIKE '{myStr}' OR 
                            (second_name + last_name + first_name) LIKE '{myStr}' OR 
                            (second_name + first_name + last_name) LIKE '{ myStr}') AND 
                            (Students.group_id = Groups.id AND Groups.specialty_id = Specialties.id AND Specialties.department_id = Departments.id AND Departments.faculty_id = Faculties.id))");
                }
                else
                {
                    myStr = searchTBox1.Text;
                    b = Db.SqlSelect($@"SELECT
                    (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number),
                    COUNT(Students.id),
                    Groups.id
                    FROM 
                    Faculties, Specialties, Departments,
                    Groups
                    FULL OUTER JOIN
                    Students
                    ON
                    Students.group_id = Groups.id
                    WHERE
                    (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number) LIKE '%{myStr}%' AND 
                    Groups.specialty_id = Specialties.id AND 
                    Specialties.department_id = Departments.id AND 
                    Departments.faculty_id = Faculties.id 
                    GROUP BY
                    Groups.id, (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number)
                    ORDER BY COUNT(Students.id)");
                }
            myList1.Controls.Clear();
            //Добавление элементов в лист
            if (b != null)
            {
                    if (char.IsDigit(searchTBox1.Text[0]))
                        foreach (var item in b)
                            myList1.AddItem(item[2], item[0], item[1]);
                    else if (char.IsLetter(searchTBox1.Text[0]))
                        foreach (var item in b)
                            myList1.AddItem(item[4], item[0], item[1], item[2], item[3]);

            }
            statusStr.Text = $"Результаты поиска по запросу \"{searchTBox1.Text}\".";
            searchTBox1.Text = "";
            if (myList1.Count != 0)
                statusStr.Text += $" Найдено { myList1.Count}.";
            if (myList1.Count == 0)
            {
                var le = new Label
                {
                    Font = new Font("New Times Roman", 16),
                    Text = "Ничего не найдено\nПопробуйте изменить условия поиска.",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                myList1.Controls.Add(le);
            }
        }
        //нажатие энтер
        private void searchTBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            button1_Click(sender, e);
        }

        //Статистика
        private void panel2_Layout(object sender, LayoutEventArgs e)
        {
            label8.Text = @"Всего студентов: " + Db.SqlSelect("SELECT COUNT(*) FROM Students")[0][0];
            label9.Text = @"Всего учебных групп: " + Db.SqlSelect("SELECT COUNT(*) FROM Groups")[0][0];

        }
        //подробнее группы
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myList1.Controls.Clear();

            var b = Db.SqlSelect(@"SELECT
                    (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number),
                    COUNT(Students.id),
                    Groups.id
                    FROM 
                    Faculties, Specialties, Departments,
                    Groups
                    FULL OUTER JOIN
                    Students
                    ON
                    Students.group_id = Groups.id
                    WHERE
                    Groups.specialty_id = Specialties.id AND 
                    Specialties.department_id = Departments.id AND 
                    Departments.faculty_id = Faculties.id 
                    GROUP BY
                    Groups.id, (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number)
                    ORDER BY COUNT(Students.id)");


            //Добавление элементов в лист
            if (b != null)
                foreach (var item in b)
                    myList1.AddItem(item[2], item[0], item[1]);
            statusStr.Text = $@"Найдено {myList1.Count} элементов.";
        }

        //Просмотр учебного плана
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    var newstr = myList1.SelectedItem.IsStudent ? myList1.SelectedItem.Text4.Substring(myList1.SelectedItem.Text4.Length - 3, 3) : myList1.SelectedItem.Text1.Substring(myList1.SelectedItem.Text1.Length - 3, 3);
        //    var myRequest = Db.SqlSelect($@"SELECT 
        //    Learning_plans.semester,
        //    Disciplines.name,
        //    Learning_plans.number_of_learning_hours,
        //    Types_of_control.name,
        //    Learning_plans.course_work
        //    FROM
        //    Groups_plans, Groups, Learning_plans, Types_of_control, Disciplines
        //    WHERE
        //    Groups.group_number = '{newstr}' AND 
        //    group_id = Groups.id AND
        //    learning_plan_id = Learning_plans.id AND
        //    discipline_id = Disciplines.id AND
        //    type_of_control_id = Types_of_control.id");

        //    var f = new Form
        //    {
        //        FormBorderStyle = FormBorderStyle.FixedDialog,
        //        Height = 600,
        //        Width = 1000
        //    };

        //    var btOk = new Button
        //    {
        //        Location = new Point(500, 535),
        //        Text = @"Закрыть",
        //        DialogResult = DialogResult.OK
        //    };
        //    f.Controls.Add(btOk);


        //    var mainPanel = new Panel
        //    {
        //        BorderStyle = BorderStyle.Fixed3D,
        //        Dock = DockStyle.Top,
        //        Height = 490
        //    };
        //    f.Controls.Add(mainPanel);
        //    for (var i = 8; i >= 1; i--)
        //    {
        //        var dgv = new DataGridView
        //        {
        //            ReadOnly = true,
        //            AllowUserToAddRows = false,
        //            AllowUserToDeleteRows = false,
        //            AllowUserToOrderColumns = false,
        //            AllowUserToResizeRows = false,
        //            AllowDrop = false,
        //            RowHeadersVisible = false,
        //            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
        //            Dock = DockStyle.Top,
        //            ColumnCount = 4,
        //            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        //            Height = 25
        //        };

        //        dgv.Columns[0].Name = @"Дисциплина";
        //        dgv.Columns[1].Name = @"Часы";
        //        dgv.Columns[2].Name = @"Курсовая";
        //        dgv.Columns[3].Name = @"Вид контроля";
        //        dgv.RowsAdded += DGV_RowsAdded;
        //        mainPanel.Controls.Add(dgv);

        //        var lb1 = new Label
        //        {
        //            BorderStyle = BorderStyle.FixedSingle,
        //            Text = $@"{i} семестр",
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            Font = new Font("Times New Roman", 14),
        //            Dock = DockStyle.Top
        //        };
        //        mainPanel.Controls.Add(lb1);
        //        foreach (var item in myRequest)
        //            if (Convert.ToInt32(item[0]) == i)
        //                dgv.Rows.Add(item[1], item[2], Convert.ToBoolean(item[4]) ? "да" : "нет", item[3]);

        //    }

        //    var lb = new Label
        //    {
        //        Text = @"Учебный план",
        //        Font = new Font("Times New Roman", 20),
        //        TextAlign = ContentAlignment.MiddleCenter,
        //        Height = 40,
        //        Dock = DockStyle.Top
        //    };
        //    f.Controls.Add(lb);

        //    mainPanel.AutoScroll = true;
        //    mainPanel.Controls[mainPanel.Controls.Count - 1].Select();

        //    f.ShowDialog();

        //}

        private void DGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ((DataGridView)sender).Height += 23;
        }

        //Удаление
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show("Вы действительно хотите удалить?", "Предупреждение!", buttons);

            if (result == DialogResult.Yes)
            {
                var flag = Db.SqlDelete($@"DELETE FROM Students WHERE (Students.id = {myList1.SelectedItem.Id})");
                if (flag)
                    MessageBox.Show("Студент успешно удален из базы!");
                panel2_Layout(null, null);

                myList1.Controls.Clear();
                statusStr.Text = "";
                //RightPanelCleaner();
            }


        }


        //список студентов группы и редактирование студентов
        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Height = 600,
                Width = 1000
            };
            if (!myList1.SelectedItem.IsStudent)
            {
                var btOk = new Button
                {
                    Location = new Point(500, 535),
                    Text = @"Закрыть",
                    DialogResult = DialogResult.OK
                };
                f.Controls.Add(btOk);

                var mainPanel = new Panel
                {
                    BorderStyle = BorderStyle.Fixed3D,
                    Dock = DockStyle.Top,
                    Height = 490
                };
                f.Controls.Add(mainPanel);

                var lb = new Label
                {
                    Text = @"Список студентов",
                    Font = new Font("Times New Roman", 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 40,
                    Dock = DockStyle.Top
                };
                f.Controls.Add(lb);
                //ЕСЛИ это группа то отобразить список группы
                var req = Db.SqlSelect($@"SELECT first_name, second_name, last_name, date_of_birth 
                FROM Students INNER JOIN Groups ON Students.group_id = Groups.id 
                WHERE Groups.group_number = '{myList1.SelectedItem.Text1.Substring(myList1.SelectedItem.Text1.Length - 3, 3)}'");
                var dgv = new DataGridView
                {
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToOrderColumns = false,
                    AllowUserToResizeRows = false,
                    AllowDrop = false,
                    RowHeadersVisible = false,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                    Dock = DockStyle.Top,
                    ColumnCount = 4,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    Height = 25
                };
                dgv.Columns[0].Name = @"Имя";
                dgv.Columns[1].Name = @"Отчество";
                dgv.Columns[2].Name = @"Фамилия";
                dgv.Columns[3].Name = @"Дата рождения";
                dgv.RowsAdded += DGV_RowsAdded;
                mainPanel.Controls.Add(dgv);


                foreach (var item in req)
                    dgv.Rows.Add(item[0], item[1], item[2], DateTime.Parse(item[3]).ToLongDateString());
                f.ShowDialog();
            }
            else
            {
               UpdateStudentForm g = new UpdateStudentForm(myList1.SelectedItem.Id);
                g.ShowDialog();
                myList1.Controls.Clear();
                statusStr.Text = "";
            }


        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new AddStudent();

            f.ShowDialog();
            panel2_Layout(this, null);
            
        }
        //Успеваемость
        private void button5_Click(object sender, EventArgs e)
        {
            var newstr = myList1.SelectedItem.IsStudent ? myList1.SelectedItem.Text4.Substring(myList1.SelectedItem.Text4.Length - 3, 3) : myList1.SelectedItem.Text1.Substring(myList1.SelectedItem.Text1.Length - 3, 3);
            var myRequest = Db.SqlSelect($@"SELECT
            Disciplines.name, Types_of_control.name, Marks.mark, Marks.date
            FROM
            Marks
            INNER JOIN
            Types_of_control
            ON
            Marks.type_of_control_id = Types_of_control.id 
            INNER JOIN
            Disciplines
            ON
            Marks.discipline_id = Disciplines.id
            WHERE
            Marks.student_id = {myList1.SelectedItem.Id}");

            var f = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Height = 600,
                Width = 1000
            };

            var btOk = new Button
            {
                Location = new Point(500, 535),
                Text = @"Закрыть",
                DialogResult = DialogResult.OK
            };
            f.Controls.Add(btOk);


            var mainPanel = new Panel
            {
                BorderStyle = BorderStyle.Fixed3D,
                Dock = DockStyle.Top,
                Height = 490
            };
            f.Controls.Add(mainPanel);
                var dgv = new DataGridView
                {
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToOrderColumns = false,
                    AllowUserToResizeRows = false,
                    AllowDrop = false,
                    RowHeadersVisible = false,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                    Dock = DockStyle.Top,
                    ColumnCount = 4,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    Height = 25
                };

                dgv.Columns[0].Name = @"Дисциплина";
                dgv.Columns[1].Name = @"Вид контроля";
                dgv.Columns[2].Name = @"Оценка";
                dgv.Columns[3].Name = @"Дата сдачи";
                dgv.RowsAdded += DGV_RowsAdded;
                mainPanel.Controls.Add(dgv);

            foreach (var item in myRequest)
                dgv.Rows.Add(item[0], item[1], item[1] == "Зачет" ? "Зачет" : item[2], DateTime.Parse(item[3]).ToLongDateString());

            

            var lb = new Label
            {
                Text = @"Оценки",
                Font = new Font("Times New Roman", 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40,
                Dock = DockStyle.Top
            };
            f.Controls.Add(lb);

            mainPanel.AutoScroll = true;
            mainPanel.Controls[mainPanel.Controls.Count - 1].Select();

            f.ShowDialog();
        }
    }
}

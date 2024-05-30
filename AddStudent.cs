using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ElDee
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 5, 0);

            var req = Db.SqlSelect(@"SELECT name FROM Faculties");
            foreach (var item in req)
                facultyComboBox.Items.Add(item[0]) ;

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tx = (TextBox)sender;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            if (tx.TextLength == 0)
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            else
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());

        }


        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentComboBox.Enabled = true;
            departmentComboBox.SelectedItem = null;
            specialtyComboBox.Enabled = false;
            specialtyComboBox.SelectedItem = null;
            groupComboBox.Enabled = false;
            groupComboBox.SelectedItem = null;

            departmentComboBox.Items.Clear();

            var req = Db.SqlSelect($@"SELECT Departments.name FROM Departments, Faculties WHERE Departments.faculty_id = Faculties.id AND Faculties.name = '{facultyComboBox.SelectedItem}'");
            foreach (var item in req)
                departmentComboBox.Items.Add(item[0]);
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialtyComboBox.Enabled = true;
            specialtyComboBox.SelectedItem = null;
            groupComboBox.Enabled = false;
            groupComboBox.SelectedItem = null;

            specialtyComboBox.Items.Clear();

            var req = Db.SqlSelect($@"SELECT Specialties.name FROM Departments, Specialties WHERE Specialties.department_id = Departments.id AND Departments.name = '{departmentComboBox.SelectedItem}'");
            foreach (var item in req)
                specialtyComboBox.Items.Add(item[0]);
        }

        private void specialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupComboBox.Enabled = true;
            groupComboBox.SelectedItem = null;

            groupComboBox.Items.Clear();

            var req = Db.SqlSelect($@"SELECT
            (CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + CAST(DATEDIFF(DAY, creation_date, GETDATE()) / 365 + 1 AS nvarchar(5)) + 'ДБ-' + group_number) 
            FROM
            Groups, Faculties, Specialties, Departments 
            WHERE 
            Groups.specialty_id = Specialties.id AND 
            Specialties.department_id = Departments.id AND 
            Departments.faculty_id = Faculties.id AND
            Specialties.name = '{specialtyComboBox.SelectedItem}'
            ");
            foreach (var item in req)
                groupComboBox.Items.Add(item[0]);
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //кнопка выбора файла
        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            string line;
            var f = new OpenFileDialog {Filter = "txt files (*.txt)|*.txt"};
            if (f.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                using (var file = new StreamReader(f.FileName))
                {
                    while ((line = file.ReadLine()) != null)
                        dataGridView1.Rows.Add(line.Split());

                    pathFileLabel.Text = f.FileName;
                }

            }
        }

        //кнопка добавить
        private void addButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                var flag = true;
                var regLastName = new Regex(@"^[а-яА-ЯёЁ]+$");
                var regFirstName = new Regex(@"^[а-яА-ЯёЁ]+$");
                var regSecondName = new Regex(@"^[а-яА-ЯёЁ]+$");
                var regDate = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
                var regGroup = new Regex(@"^[0-9][а-яА-ЯёЁ]{1,4}[-][0-9][а-яА-ЯёЁ]{1,2}[-][0-9][0-9][0-9]+$");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        MessageBox.Show($"Ошибка!\nПустая ячейка!");
                        dataGridView1.ClearSelection();
                        row.Cells[0].Selected = true;
                        flag = false;
                        break;
                    }
                    if (!regLastName.IsMatch(row.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show($"Ошибка!\n{row.Cells[0].Value}");
                        dataGridView1.ClearSelection();
                        row.Cells[0].Selected = true;
                        flag = false;
                        break;
                    }
                    if (row.Cells[1].Value == null)
                    {
                        MessageBox.Show($"Ошибка!\nПустая ячейка!");
                        dataGridView1.ClearSelection();
                        row.Cells[1].Selected = true;
                        flag = false;
                        break;
                    }
                    if (!regFirstName.IsMatch(row.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show($"Ошибка!\n{row.Cells[1].Value}");
                        dataGridView1.ClearSelection();
                        row.Cells[1].Selected = true;
                        flag = false;
                        break;
                    }
                    if (row.Cells[2].Value == null)
                    {
                        MessageBox.Show($"Ошибка!\nПустая ячейка!");
                        dataGridView1.ClearSelection();
                        row.Cells[2].Selected = true;
                        flag = false;
                        break;
                    }
                    if (!regSecondName.IsMatch(row.Cells[2].Value.ToString()))
                    {
                        MessageBox.Show($"Ошибка!\n{row.Cells[2].Value}");
                        dataGridView1.ClearSelection();
                        row.Cells[2].Selected = true;
                        flag = false;
                        break;
                    }
                    if (row.Cells[3].Value == null)
                    {
                        MessageBox.Show($"Ошибка!\nПустая ячейка!");
                        dataGridView1.ClearSelection();
                        row.Cells[3].Selected = true;
                        flag = false;
                        break;
                    }
                    if (!regDate.IsMatch(row.Cells[3].Value.ToString()))
                    {
                        MessageBox.Show($"Ошибка!\n{row.Cells[3].Value}");
                        dataGridView1.ClearSelection();
                        row.Cells[3].Selected = true;
                        flag = false;
                        break;
                    }
                    if (row.Cells[4].Value == null)
                    {
                        MessageBox.Show($"Ошибка!\nПустая ячейка!");
                        dataGridView1.ClearSelection();
                        row.Cells[4].Selected = true;
                        flag = false;
                        break;
                    }
                    if (!regGroup.IsMatch(row.Cells[4].Value.ToString()))
                    {
                        MessageBox.Show($"Ошибка!\n{row.Cells[4].Value}");
                        dataGridView1.ClearSelection();
                        row.Cells[4].Selected = true;
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    var sqlFlag = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var firstName = row.Cells[1].Value.ToString().ToLower();
                        var correctFirstName = firstName[0].ToString().ToUpper() + firstName.Substring(1);
                        var secondName = row.Cells[2].Value.ToString().ToLower();
                        var correctSecondName = secondName[0].ToString().ToUpper() + secondName.Substring(1); ;
                        var lastName = row.Cells[0].Value.ToString().ToLower();
                        var correctLastName = lastName[0].ToString().ToUpper() + lastName.Substring(1); ;
                        var dateOfBirth = row.Cells[3].Value.ToString().ToLower();
                        var group = row.Cells[4].Value.ToString().Substring(row.Cells[4].Value.ToString().Length - 3);
                        sqlFlag = Db.SqlInsert(
                            $@"
                        INSERT INTO Students
                        VALUES(
                        '{correctFirstName}',
                        '{correctSecondName}',
                        '{correctLastName}',
                        '{dateOfBirth}',
                        (SELECT id FROM Groups WHERE Groups.group_number = '{group}')
                        )");
                        if (!sqlFlag)
                        {
                            dataGridView1.ClearSelection();
                            row.Cells[4].Selected = true;
                        }
                    }

                    if (pathFileLabel.Text == @"Выберите текстовый файл со студентами...")
                    {
                        MessageBox.Show("Вы не выбрали файл!");
                    }
                    else
                    {
                        if (sqlFlag)
                        {
                            MessageBox.Show("Данные успешно добавлены!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Некорректная группа!");
                        }
                    }

                }
            }
            else
            {
                if (lastNameTb.Text != "" && firstNameTb.Text != "" && secondNameTb.Text != "" &&
                    facultyComboBox.SelectedItem != null && departmentComboBox.SelectedItem != null &&
                    specialtyComboBox.SelectedItem != null && groupComboBox.SelectedItem != null)
                {

                    ////////////////////////////////////////////
                    ///
                    var idx = groupComboBox.SelectedIndex;
                    var grp = (string)groupComboBox.Items[idx];
                    //MessageBox.Show(dateBirthPicker.Text);


                    var checkStudent = Db.SqlSelect(
                            $@"
                        SELECT  
                            id
                        FROM
                        Students
                        WHERE
                        last_name = '{lastNameTb.Text}' AND
                        first_name = '{firstNameTb.Text}' AND
                        second_name = '{secondNameTb.Text}' AND
                        date_of_birth = '{dateBirthPicker.Text}'
                        ");
                    if (checkStudent == null)
                    {


                        var sqlFlag = Db.SqlInsert(
                                $@"
                        INSERT INTO Students(
                            last_name,
                            first_name,
                            second_name,
                            date_of_birth,
                            group_id
                            )
                        VALUES(
                        '{lastNameTb.Text}',
                        '{firstNameTb.Text}',
                        '{secondNameTb.Text}',
                        '{dateBirthPicker.Text}',
                        (SELECT id FROM Groups WHERE Groups.group_number = '{grp.Substring(grp.Length - 3)}')
                        )");

                        if (sqlFlag)
                        {
                            MessageBox.Show("Данные успешно добавлены!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка!");
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Такой студент уже существует!");
                    }
                }
                else
                    MessageBox.Show("Не все поля заполнены!!!");
                
            }
      
        }

        //Отмена кнопка
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDee
{
    public partial class UpdateStudentForm : Form
    {
        private string studentId;
        public UpdateStudentForm(string id)
        {
            InitializeComponent();

            var info = Db.SqlSelect($@"
            SELECT
            Students.last_name,
            Students.first_name,
            Students.second_name,
            Students.date_of_birth,
            Faculties.name,
            Departments.name,
            Specialties.name,
            ('Б' + CAST(ABS(DATEDIFF(YEAR, creation_date, '2000')) AS nvarchar(5)) + '-' +  CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + group_number)

            FROM
            Students
            INNER JOIN
            Groups
            ON
            Students.group_id = Groups.id
            INNER JOIN
            Specialties
            ON
            Groups.specialty_id = Specialties.id
            INNER JOIN
            Departments
            ON
            Specialties.department_id = Departments.id
            INNER JOIN
            Faculties
            ON
            Departments.faculty_id = Faculties.id
            WHERE
            Students.id = {id}
            ");
            studentId = id;
            lastNameTb.Text = info[0][0];
            firstNameTb.Text = info[0][1];
            secondNameTb.Text = info[0][2];
            dateBirthPicker.Value = DateTime.Parse(info[0][3]);
            var req = Db.SqlSelect(@"SELECT name FROM Faculties");
            foreach (var item in req)
                facultyComboBox.Items.Add(item[0]);
            facultyComboBox.SelectedItem = info[0][4];
            departmentComboBox.SelectedItem = info[0][5];
            specialtyComboBox.SelectedItem = info[0][6];
            groupComboBox.SelectedItem = info[0][7];
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
            ('Б' + CAST(ABS(DATEDIFF(YEAR, creation_date, '2000')) AS nvarchar(5)) + '-' +  CAST(Faculties.number AS nvarchar(20)) + Specialties.short_name + '-' + group_number) 
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (lastNameTb.Text != "" && firstNameTb.Text != "" && secondNameTb.Text != "" &&
                    facultyComboBox.SelectedItem != null && departmentComboBox.SelectedItem != null &&
                    specialtyComboBox.SelectedItem != null && groupComboBox.SelectedItem != null)
            {
                var idx = groupComboBox.SelectedIndex;
                var grp = (string)groupComboBox.Items[idx];
                var date = dateBirthPicker.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

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
                        date_of_birth = '{date}'
                        ");

                var studentExists = false;

                foreach (var item in checkStudent)
                    if (item[0] != null) studentExists = true;

                if (!studentExists)
                {
                    var sql = Db.SqlInsert($@"
                    UPDATE top(1) 
                    Students 
                    SET 
                    last_name = '{lastNameTb.Text}',
                    first_name = '{firstNameTb.Text}',
                    second_name = '{secondNameTb.Text}',
                    date_of_birth = '{date}',
                    group_id = (SELECT id FROM Groups WHERE Groups.group_number = '{grp.Substring(grp.Length - 3)}') 
                    where id = {studentId};
                    ");
                    
                    if (sql)
                    {
                        MessageBox.Show("Данные успешно обновлены!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Сломалось");
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
}

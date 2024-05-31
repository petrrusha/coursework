using Microsoft.IdentityModel.Tokens;
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

        
        //кнопка добавить
        private void addButton_Click(object sender, EventArgs e)
        {
            
                if (lastNameTb.Text != "" && firstNameTb.Text != "" && secondNameTb.Text != "" &&
                    facultyComboBox.SelectedItem != null && departmentComboBox.SelectedItem != null &&
                    specialtyComboBox.SelectedItem != null && groupComboBox.SelectedItem != null)
                {

                    
                    var idx = groupComboBox.SelectedIndex;
                    var grp = (string)groupComboBox.Items[idx];
                   


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

                var studentExists = false;

                foreach (var item in checkStudent)
                    if (item[0] != null) studentExists = true;

                if (!studentExists)
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

        //Отмена кнопка
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

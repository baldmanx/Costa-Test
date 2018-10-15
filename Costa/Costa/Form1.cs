using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costa
{
    public partial class Form1 : Form
    {
        TestDBEntities context = new TestDBEntities();

        // Функция отображения данных о сотрудниках
        public void UpdateEmployees()
        {
            employeeDataGridView.AutoGenerateColumns = false;

            using (TestDBEntities tdb = new TestDBEntities())
            {
                employeeDataGridView.DataSource = tdb.Empoyee.ToList<Empoyee>();
            }
        }

        // Функция отображения данных об отделах
        public void UpdateDepartments()
        {
            departmentsDataGridView.AutoGenerateColumns = false;

            using (TestDBEntities tdb = new TestDBEntities())
            {
                departmentsDataGridView.DataSource = tdb.Department.ToList<Department>();

                FillingComboBoxes(tdb);
            }
        }

        // Функция отчистки полей ввода данных о сотрудниках
        public void ClearTextEmployees()
        {
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtPatronymic.Text = "";
            dateOfBirthPicker.Value = DateTime.Now;
            txtSeries.Text = "";
            txtNumber.Text = "";
            txtPosition.Text = "";         
        }

        // Функция отчистки полей ввода данных об отделах
        public void ClearTextDepartments()
        {
            txtName.Text = "";
            txtCode.Text = "";
        }

        // Функция заполнения выпадающих списков названиями существущих отделов
        public void FillingComboBoxes(TestDBEntities t)
        {
            departmentComboBox.Items.Clear();
            parentDepartmentComboBox.Items.Clear();
            edComboBox.Items.Clear();

            foreach (Department d in t.Department)
            {
                departmentComboBox.Items.Add(d.Name);
                parentDepartmentComboBox.Items.Add(d.Name);
                edComboBox.Items.Add(d.Name);
            }
        }
        
        public Form1()
        {
            InitializeComponent();


            // Контроль ввода данных
            txtFirstName.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtSurname.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtPatronymic.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtSeries.KeyPress += new KeyPressEventHandler(docSeries_KeyPress);
            txtNumber.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtPosition.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            txtName.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateEmployees();
            UpdateDepartments();

            departmentComboBox.SelectedIndex = 0;
            parentDepartmentComboBox.SelectedIndex = 0;
            edComboBox.SelectedIndex = 0;
        }

        // Добавление записи о сотруднике
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            Empoyee empoyee = new Empoyee();

            empoyee.FirstName = txtFirstName.Text.Trim();
            empoyee.SurName = txtSurname.Text.Trim();
            empoyee.Patronymic = txtPatronymic.Text.Trim();
            empoyee.DateOfBirth = dateOfBirthPicker.Value;
            empoyee.DocSeries = txtSeries.Text.Trim();
            empoyee.DocNumber = txtNumber.Text.Trim();
            empoyee.Position = txtPosition.Text.Trim();

            foreach (Department d in context.Department)
            {
                if (d.Name == departmentComboBox.SelectedItem.ToString())
                {
                    empoyee.DepartmentID = d.ID;
                }
            }

            context.Empoyee.Add(empoyee);
            context.SaveChanges();

            ClearTextEmployees();
            UpdateEmployees();
        }

        // Добавление записи об отделе
        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();

            department.ID = Guid.NewGuid();
            department.Name = txtName.Text.Trim();
            department.Code = txtCode.Text.Trim();

            foreach (Department d in context.Department)
            {
                if (d.Name == parentDepartmentComboBox.SelectedItem.ToString())
                {
                    department.ParentDepartmentID = d.ID;
                }
            }

            context.Department.Add(department);
            context.SaveChanges();

            ClearTextDepartments();
            UpdateDepartments();
        }

        public Empoyee deleting_employee = new Empoyee();
        public Department deleting_department = new Department();

        // Получение данных об удаляемой записи о сотруднике
        private void employeeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeDataGridView.CurrentRow.Index != -1)
            {
                deleting_employee.ID = (decimal)employeeDataGridView.CurrentRow.Cells["EID"].Value;

                using (TestDBEntities tdb = new TestDBEntities())
                {
                    deleting_employee = tdb.Empoyee.Where(x => x.ID == deleting_employee.ID).FirstOrDefault();
                }

                deleteEmployeeButton.Enabled = true;
            }
        }

        // Удаление записи о сотруднике
        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение операции", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TestDBEntities tdb = new TestDBEntities())
                {
                    var entry = tdb.Entry(deleting_employee);
                    if (entry.State == EntityState.Detached)
                    {
                        tdb.Empoyee.Attach(deleting_employee);
                        tdb.Empoyee.Remove(deleting_employee);
                        tdb.SaveChanges();
                        UpdateEmployees();
                        ClearTextEmployees();
                    }
                }
            }
            deleteEmployeeButton.Enabled = false;
        }

        // Получение данных об удаляемой записи об отделе
        private void departmentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (departmentsDataGridView.CurrentRow.Index != -1)
            {
                deleting_department.ID = (Guid)departmentsDataGridView.CurrentRow.Cells["DID"].Value;

                using (TestDBEntities tdb = new TestDBEntities())
                {
                    deleting_department = tdb.Department.Where(x => x.ID == deleting_department.ID).FirstOrDefault();
                }

                deleteDepartmentButton.Enabled = true;
            }
        }

        // Удаление записи об отделе
        private void deleteDepartmentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все записи о сотрудниках этого отдела в таблице 'Сотрудники' будут удалены. Вы действительно хотите удалить этот отдел?", "Подтверждение операции", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TestDBEntities tdb = new TestDBEntities())
                {
                    var entry = tdb.Entry(deleting_department);
                    if (entry.State == EntityState.Detached)
                    {
                        tdb.Department.Attach(deleting_department);
                        tdb.Department.Remove(deleting_department);
                        tdb.SaveChanges();
                        UpdateEmployees();
                        ClearTextDepartments();
                        UpdateDepartments();
                        FillingComboBoxes(tdb);
                    }
                }
            }

            deleteDepartmentButton.Enabled = false;
        }
        
        public Empoyee updating_employee = new Empoyee();
        public Department updating_department = new Department();

        // Получение данных о редактируемой записи об сотруднике
        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeDataGridView.CurrentRow.Index != -1)
            {
                updating_employee.ID = (decimal)employeeDataGridView.CurrentRow.Cells["EID"].Value;

                using (TestDBEntities tdb = new TestDBEntities())
                {
                    updating_employee = tdb.Empoyee.Where(x => x.ID == updating_employee.ID).FirstOrDefault();

                    txtFirstName.Text = updating_employee.FirstName;
                    txtSurname.Text = updating_employee.SurName;
                    txtPatronymic.Text = updating_employee.Patronymic;
                    dateOfBirthPicker.Value = updating_employee.DateOfBirth;
                    txtSeries.Text = updating_employee.DocSeries;
                    txtNumber.Text = updating_employee.DocNumber;
                    txtPosition.Text = updating_employee.Position;
                }

            }
        }

        // Получение данных о редактируемой записи об отделе
        private void departmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (departmentsDataGridView.CurrentRow.Index != -1)
            {
                updating_department.ID = (Guid)departmentsDataGridView.CurrentRow.Cells["DID"].Value;

                using (TestDBEntities tdb = new TestDBEntities())
                {
                    updating_department = tdb.Department.Where(x => x.ID == updating_department.ID).FirstOrDefault();

                    txtName.Text = updating_department.Name;
                    txtCode.Text = updating_department.Code;
                }

            }
        }

        // Редактирование записи об отделе
        private void editDepartmentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение операции", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TestDBEntities tdb = new TestDBEntities())
                {
                    var entry = tdb.Entry(updating_department);
                    if (entry.State == EntityState.Detached)
                    {
                        tdb.Department.Attach(updating_department);

                        updating_department.Name = txtName.Text.Trim();
                        updating_department.Code = txtCode.Text.Trim();

                        tdb.SaveChanges();
                        UpdateDepartments();
                        ClearTextDepartments();
                        FillingComboBoxes(tdb);
                    }
                }
            }
        }

        // Редактирование записи о сотруднике
        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение операции", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TestDBEntities tdb = new TestDBEntities())
                {
                    var entry = tdb.Entry(updating_employee);
                    if (entry.State == EntityState.Detached)
                    {
                        tdb.Empoyee.Attach(updating_employee);

                        updating_employee.FirstName = txtFirstName.Text.Trim();
                        updating_employee.SurName = txtSurname.Text.Trim();
                        updating_employee.Patronymic = txtPatronymic.Text.Trim();
                        updating_employee.DateOfBirth = dateOfBirthPicker.Value;
                        updating_employee.DocSeries = txtSeries.Text.Trim();
                        updating_employee.DocNumber = txtNumber.Text.Trim();
                        updating_employee.Position = txtPosition.Text.Trim();

                        tdb.SaveChanges();
                        UpdateEmployees();
                        ClearTextEmployees();
                        FillingComboBoxes(tdb);
                    }
                }
            }
        }

        // Отображение информации по сотрудникам выбранного отдела
        private void edComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            edDataGridView.AutoGenerateColumns = false;

            Guid guid = new Guid();
            //var query = 0;

            foreach (Department d in context.Department)
            {
                if (edComboBox.SelectedItem.ToString() == d.Name)
                {
                    guid = d.ID;
                }
            }

            var query = from em in context.Empoyee
                        where em.DepartmentID == guid
                        select new
                        {
                            em.FirstName,
                            em.SurName,
                            em.Position,
                            Age = DateTime.Now.Year - em.DateOfBirth.Year
                        };

            edDataGridView.DataSource = query.ToList();
        }

        // Ввод только цифр и букв в серию
        private void docSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        // Ввод только букв
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        // В поле ввода Code разрешены любые символы
    }
}

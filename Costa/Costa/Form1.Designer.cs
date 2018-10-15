namespace Costa
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.departmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.parentDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editDepartmentButton = new System.Windows.Forms.Button();
            this.deleteDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.departmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.edGroupBox = new System.Windows.Forms.GroupBox();
            this.edDataGridView = new System.Windows.Forms.DataGridView();
            this.edFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edComboBox = new System.Windows.Forms.ComboBox();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentDepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.employeeGroupBox.SuspendLayout();
            this.departmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).BeginInit();
            this.edGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.employeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.FirstName,
            this.Surname,
            this.Patronymic,
            this.DateOfBirth,
            this.DocSeries,
            this.DocNumber,
            this.Position,
            this.DepartmentID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeeDataGridView.EnableHeadersVisualStyles = false;
            this.employeeDataGridView.Location = new System.Drawing.Point(258, 19);
            this.employeeDataGridView.MultiSelect = false;
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(774, 254);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.TabStop = false;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
            this.employeeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellDoubleClick);
            // 
            // EID
            // 
            this.EID.DataPropertyName = "ID";
            this.EID.HeaderText = "ID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            this.EID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "SurName";
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "Patronymic";
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Дата рождения";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // DocSeries
            // 
            this.DocSeries.DataPropertyName = "DocSeries";
            this.DocSeries.HeaderText = "Серия";
            this.DocSeries.Name = "DocSeries";
            this.DocSeries.ReadOnly = true;
            this.DocSeries.Width = 60;
            // 
            // DocNumber
            // 
            this.DocNumber.DataPropertyName = "DocNumber";
            this.DocNumber.HeaderText = "Номер";
            this.DocNumber.Name = "DocNumber";
            this.DocNumber.ReadOnly = true;
            this.DocNumber.Width = 60;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 200;
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "DepartmentID";
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.ReadOnly = true;
            this.DepartmentID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(107, 112);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(145, 20);
            this.dateOfBirthPicker.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(107, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(145, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(107, 86);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(145, 20);
            this.txtPatronymic.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(107, 138);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(145, 20);
            this.txtSeries.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Серия";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(107, 164);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(145, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(107, 190);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(145, 20);
            this.txtPosition.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Должность";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(15, 250);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.addEmployeeButton.TabIndex = 8;
            this.addEmployeeButton.Text = "Добавить";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Enabled = false;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(96, 250);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployeeButton.TabIndex = 17;
            this.deleteEmployeeButton.TabStop = false;
            this.deleteEmployeeButton.Text = "Удалить";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeGroupBox.Controls.Add(this.label10);
            this.employeeGroupBox.Controls.Add(this.departmentComboBox);
            this.employeeGroupBox.Controls.Add(this.editEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.employeeDataGridView);
            this.employeeGroupBox.Controls.Add(this.label1);
            this.employeeGroupBox.Controls.Add(this.deleteEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.addEmployeeButton);
            this.employeeGroupBox.Controls.Add(this.txtPosition);
            this.employeeGroupBox.Controls.Add(this.txtFirstName);
            this.employeeGroupBox.Controls.Add(this.label7);
            this.employeeGroupBox.Controls.Add(this.dateOfBirthPicker);
            this.employeeGroupBox.Controls.Add(this.txtNumber);
            this.employeeGroupBox.Controls.Add(this.label2);
            this.employeeGroupBox.Controls.Add(this.label6);
            this.employeeGroupBox.Controls.Add(this.txtSurname);
            this.employeeGroupBox.Controls.Add(this.txtSeries);
            this.employeeGroupBox.Controls.Add(this.label3);
            this.employeeGroupBox.Controls.Add(this.label5);
            this.employeeGroupBox.Controls.Add(this.txtPatronymic);
            this.employeeGroupBox.Controls.Add(this.label4);
            this.employeeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(1045, 296);
            this.employeeGroupBox.TabIndex = 18;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Сотрудники";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Отдел";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(65, 216);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(187, 21);
            this.departmentComboBox.TabIndex = 7;
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(177, 250);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.editEmployeeButton.TabIndex = 18;
            this.editEmployeeButton.TabStop = false;
            this.editEmployeeButton.Text = "Изменить";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.editEmployeeButton_Click);
            // 
            // departmentsGroupBox
            // 
            this.departmentsGroupBox.Controls.Add(this.parentDepartmentComboBox);
            this.departmentsGroupBox.Controls.Add(this.label11);
            this.departmentsGroupBox.Controls.Add(this.editDepartmentButton);
            this.departmentsGroupBox.Controls.Add(this.deleteDepartmentButton);
            this.departmentsGroupBox.Controls.Add(this.addDepartmentButton);
            this.departmentsGroupBox.Controls.Add(this.label8);
            this.departmentsGroupBox.Controls.Add(this.txtName);
            this.departmentsGroupBox.Controls.Add(this.label9);
            this.departmentsGroupBox.Controls.Add(this.txtCode);
            this.departmentsGroupBox.Controls.Add(this.departmentsDataGridView);
            this.departmentsGroupBox.Location = new System.Drawing.Point(12, 314);
            this.departmentsGroupBox.Name = "departmentsGroupBox";
            this.departmentsGroupBox.Size = new System.Drawing.Size(515, 244);
            this.departmentsGroupBox.TabIndex = 19;
            this.departmentsGroupBox.TabStop = false;
            this.departmentsGroupBox.Text = "Отделы";
            // 
            // parentDepartmentComboBox
            // 
            this.parentDepartmentComboBox.FormattingEnabled = true;
            this.parentDepartmentComboBox.Location = new System.Drawing.Point(65, 63);
            this.parentDepartmentComboBox.Name = "parentDepartmentComboBox";
            this.parentDepartmentComboBox.Size = new System.Drawing.Size(187, 21);
            this.parentDepartmentComboBox.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Род. отдел";
            // 
            // editDepartmentButton
            // 
            this.editDepartmentButton.Location = new System.Drawing.Point(177, 199);
            this.editDepartmentButton.Name = "editDepartmentButton";
            this.editDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.editDepartmentButton.TabIndex = 21;
            this.editDepartmentButton.TabStop = false;
            this.editDepartmentButton.Text = "Изменить";
            this.editDepartmentButton.UseVisualStyleBackColor = true;
            this.editDepartmentButton.Click += new System.EventHandler(this.editDepartmentButton_Click);
            // 
            // deleteDepartmentButton
            // 
            this.deleteDepartmentButton.Enabled = false;
            this.deleteDepartmentButton.Location = new System.Drawing.Point(96, 199);
            this.deleteDepartmentButton.Name = "deleteDepartmentButton";
            this.deleteDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDepartmentButton.TabIndex = 20;
            this.deleteDepartmentButton.TabStop = false;
            this.deleteDepartmentButton.Text = "Удалить";
            this.deleteDepartmentButton.UseVisualStyleBackColor = true;
            this.deleteDepartmentButton.Click += new System.EventHandler(this.deleteDepartmentButton_Click);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(15, 199);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(75, 23);
            this.addDepartmentButton.TabIndex = 12;
            this.addDepartmentButton.Text = "Добавить";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Название";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Код";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(65, 115);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(187, 20);
            this.txtCode.TabIndex = 11;
            // 
            // departmentsDataGridView
            // 
            this.departmentsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.departmentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.departmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.DName,
            this.Code,
            this.ParentDepartmentID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.departmentsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.departmentsDataGridView.EnableHeadersVisualStyles = false;
            this.departmentsDataGridView.Location = new System.Drawing.Point(258, 19);
            this.departmentsDataGridView.MultiSelect = false;
            this.departmentsDataGridView.Name = "departmentsDataGridView";
            this.departmentsDataGridView.ReadOnly = true;
            this.departmentsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.departmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentsDataGridView.Size = new System.Drawing.Size(251, 203);
            this.departmentsDataGridView.TabIndex = 0;
            this.departmentsDataGridView.TabStop = false;
            this.departmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsDataGridView_CellClick);
            this.departmentsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentsDataGridView_CellDoubleClick);
            // 
            // edGroupBox
            // 
            this.edGroupBox.Controls.Add(this.edDataGridView);
            this.edGroupBox.Controls.Add(this.edComboBox);
            this.edGroupBox.Location = new System.Drawing.Point(533, 314);
            this.edGroupBox.Name = "edGroupBox";
            this.edGroupBox.Size = new System.Drawing.Size(524, 244);
            this.edGroupBox.TabIndex = 20;
            this.edGroupBox.TabStop = false;
            this.edGroupBox.Text = "Информация по сотрудникам";
            // 
            // edDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.edDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.edDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.edDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edFirstName,
            this.edSurname,
            this.edPosition,
            this.Age});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.edDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.edDataGridView.EnableHeadersVisualStyles = false;
            this.edDataGridView.Location = new System.Drawing.Point(6, 46);
            this.edDataGridView.Name = "edDataGridView";
            this.edDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.edDataGridView.Size = new System.Drawing.Size(505, 176);
            this.edDataGridView.TabIndex = 1;
            this.edDataGridView.TabStop = false;
            // 
            // edFirstName
            // 
            this.edFirstName.DataPropertyName = "FirstName";
            this.edFirstName.HeaderText = "Имя";
            this.edFirstName.Name = "edFirstName";
            // 
            // edSurname
            // 
            this.edSurname.DataPropertyName = "Surname";
            this.edSurname.HeaderText = "Фамилия";
            this.edSurname.Name = "edSurname";
            // 
            // edPosition
            // 
            this.edPosition.DataPropertyName = "Position";
            this.edPosition.HeaderText = "Должность";
            this.edPosition.Name = "edPosition";
            this.edPosition.Width = 200;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.Width = 70;
            // 
            // edComboBox
            // 
            this.edComboBox.FormattingEnabled = true;
            this.edComboBox.Location = new System.Drawing.Point(6, 19);
            this.edComboBox.Name = "edComboBox";
            this.edComboBox.Size = new System.Drawing.Size(187, 21);
            this.edComboBox.TabIndex = 13;
            this.edComboBox.SelectedIndexChanged += new System.EventHandler(this.edComboBox_SelectedIndexChanged);
            // 
            // DID
            // 
            this.DID.DataPropertyName = "ID";
            this.DID.HeaderText = "DID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            this.DID.Visible = false;
            // 
            // DName
            // 
            this.DName.DataPropertyName = "Name";
            this.DName.HeaderText = "Название";
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Код отдела";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // ParentDepartmentID
            // 
            this.ParentDepartmentID.DataPropertyName = "ParentDepartmentID";
            this.ParentDepartmentID.HeaderText = "ParentDepartmentID";
            this.ParentDepartmentID.Name = "ParentDepartmentID";
            this.ParentDepartmentID.ReadOnly = true;
            this.ParentDepartmentID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1070, 570);
            this.Controls.Add(this.edGroupBox);
            this.Controls.Add(this.departmentsGroupBox);
            this.Controls.Add(this.employeeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1086, 609);
            this.MinimumSize = new System.Drawing.Size(1086, 609);
            this.Name = "Form1";
            this.Text = "Costa Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.employeeGroupBox.ResumeLayout(false);
            this.employeeGroupBox.PerformLayout();
            this.departmentsGroupBox.ResumeLayout(false);
            this.departmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).EndInit();
            this.edGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.GroupBox departmentsGroupBox;
        private System.Windows.Forms.DataGridView departmentsDataGridView;
        private System.Windows.Forms.Button editDepartmentButton;
        private System.Windows.Forms.Button deleteDepartmentButton;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox edGroupBox;
        private System.Windows.Forms.DataGridView edDataGridView;
        private System.Windows.Forms.ComboBox edComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox parentDepartmentComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn edFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn edSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn edPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentDepartmentID;
    }
}


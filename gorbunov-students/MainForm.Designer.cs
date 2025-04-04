namespace StudentsApp
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxFilterGroup = new System.Windows.Forms.ComboBox();
            this.labelFilterGroup = new System.Windows.Forms.Label();
            this.comboBoxFilterCourse = new System.Windows.Forms.ComboBox();
            this.labelFilterCourse = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(776, 200);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.textBoxEmail);
            this.groupBoxInput.Controls.Add(this.labelEmail);
            this.groupBoxInput.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxInput.Controls.Add(this.labelBirthDate);
            this.groupBoxInput.Controls.Add(this.textBoxGroup);
            this.groupBoxInput.Controls.Add(this.labelGroup);
            this.groupBoxInput.Controls.Add(this.comboBoxCourse);
            this.groupBoxInput.Controls.Add(this.labelCourse);
            this.groupBoxInput.Controls.Add(this.textBoxMiddleName);
            this.groupBoxInput.Controls.Add(this.labelMiddleName);
            this.groupBoxInput.Controls.Add(this.textBoxFirstName);
            this.groupBoxInput.Controls.Add(this.labelFirstName);
            this.groupBoxInput.Controls.Add(this.textBoxLastName);
            this.groupBoxInput.Controls.Add(this.labelLastName);
            this.groupBoxInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInput.Location = new System.Drawing.Point(12, 218);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(776, 100);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(650, 45);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.textBoxEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(650, 29);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email:";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(550, 45);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerBirthDate.TabIndex = 11;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(550, 29);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(89, 13);
            this.labelBirthDate.TabIndex = 10;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(450, 45);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(94, 20);
            this.textBoxGroup.TabIndex = 9;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(450, 29);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(45, 13);
            this.labelGroup.TabIndex = 8;
            this.labelGroup.Text = "Группа:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(350, 45);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(94, 21);
            this.comboBoxCourse.TabIndex = 7;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(350, 29);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(34, 13);
            this.labelCourse.TabIndex = 6;
            this.labelCourse.Text = "Курс:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(250, 45);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(94, 20);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(250, 29);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(150, 45);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(94, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(150, 29);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(50, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(94, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(50, 29);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.buttonImport);
            this.groupBoxActions.Controls.Add(this.buttonExport);
            this.groupBoxActions.Controls.Add(this.buttonLoad);
            this.groupBoxActions.Controls.Add(this.buttonSave);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.buttonEdit);
            this.groupBoxActions.Controls.Add(this.buttonAdd);
            this.groupBoxActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxActions.Location = new System.Drawing.Point(12, 324);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(776, 60);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(650, 20);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(120, 30);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Импорт CSV";
            this.buttonImport.UseVisualStyleBackColor = false;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(524, 20);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(120, 30);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Экспорт CSV";
            this.buttonExport.UseVisualStyleBackColor = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(398, 20);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(120, 30);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(272, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(146, 20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(74, 20);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(66, 30);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(2, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Controls.Add(this.textBoxSearch);
            this.groupBoxFilters.Controls.Add(this.labelSearch);
            this.groupBoxFilters.Controls.Add(this.comboBoxFilterGroup);
            this.groupBoxFilters.Controls.Add(this.labelFilterGroup);
            this.groupBoxFilters.Controls.Add(this.comboBoxFilterCourse);
            this.groupBoxFilters.Controls.Add(this.labelFilterCourse);
            this.groupBoxFilters.Controls.Add(this.comboBoxSortBy);
            this.groupBoxFilters.Controls.Add(this.labelSortBy);
            this.groupBoxFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 390);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(776, 98);
            this.groupBoxFilters.TabIndex = 3;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры и сортировка";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(764, 20);
            this.textBoxSearch.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(6, 16);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(42, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Поиск:";
            // 
            // comboBoxFilterGroup
            // 
            this.comboBoxFilterGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterGroup.FormattingEnabled = true;
            this.comboBoxFilterGroup.Location = new System.Drawing.Point(272, 71);
            this.comboBoxFilterGroup.Name = "comboBoxFilterGroup";
            this.comboBoxFilterGroup.Size = new System.Drawing.Size(260, 21);
            this.comboBoxFilterGroup.TabIndex = 3;
            // 
            // labelFilterGroup
            // 
            this.labelFilterGroup.AutoSize = true;
            this.labelFilterGroup.Location = new System.Drawing.Point(272, 55);
            this.labelFilterGroup.Name = "labelFilterGroup";
            this.labelFilterGroup.Size = new System.Drawing.Size(45, 13);
            this.labelFilterGroup.TabIndex = 2;
            this.labelFilterGroup.Text = "Группа:";
            // 
            // comboBoxFilterCourse
            // 
            this.comboBoxFilterCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterCourse.FormattingEnabled = true;
            this.comboBoxFilterCourse.Location = new System.Drawing.Point(6, 71);
            this.comboBoxFilterCourse.Name = "comboBoxFilterCourse";
            this.comboBoxFilterCourse.Size = new System.Drawing.Size(260, 21);
            this.comboBoxFilterCourse.TabIndex = 1;
            // 
            // labelFilterCourse
            // 
            this.labelFilterCourse.AutoSize = true;
            this.labelFilterCourse.Location = new System.Drawing.Point(6, 55);
            this.labelFilterCourse.Name = "labelFilterCourse";
            this.labelFilterCourse.Size = new System.Drawing.Size(34, 13);
            this.labelFilterCourse.TabIndex = 0;
            this.labelFilterCourse.Text = "Курс:";
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Фамилия",
            "Группа",
            "Курс"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(538, 71);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(232, 21);
            this.comboBoxSortBy.TabIndex = 1;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(538, 55);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(90, 13);
            this.labelSortBy.TabIndex = 0;
            this.labelSortBy.Text = "Сортировать по:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.dataGridViewStudents);
            this.MinimumSize = new System.Drawing.Size(816, 539);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет студентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterGroup;
        private System.Windows.Forms.Label labelFilterGroup;
        private System.Windows.Forms.ComboBox comboBoxFilterCourse;
        private System.Windows.Forms.Label labelFilterCourse;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label labelSortBy;
    }
} 
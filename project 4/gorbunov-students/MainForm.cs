using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace StudentsApp
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private bool isDataChanged = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeControls();
        }

        private void InitializeDataGridView()
        {
            dataGridViewStudents.Columns.Add("LastName", "Фамилия");
            dataGridViewStudents.Columns.Add("FirstName", "Имя");
            dataGridViewStudents.Columns.Add("MiddleName", "Отчество");
            dataGridViewStudents.Columns.Add("Course", "Курс");
            dataGridViewStudents.Columns.Add("Group", "Группа");
            dataGridViewStudents.Columns.Add("BirthDate", "Дата рождения");
            dataGridViewStudents.Columns.Add("Email", "Email");

            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.MultiSelect = false;
        }

        private void InitializeControls()
        {
            dateTimePickerBirthDate.MaxDate = DateTime.Today;
            dateTimePickerBirthDate.MinDate = new DateTime(1992, 1, 1);
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;

            for (int i = 1; i <= 4; i++)
            {
                comboBoxCourse.Items.Add(i);
                comboBoxFilterCourse.Items.Add(i);
            }

            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonEdit_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonSave.Click += ButtonSave_Click;
            buttonLoad.Click += ButtonLoad_Click;
            buttonExport.Click += ButtonExport_Click;
            buttonImport.Click += ButtonImport_Click;

            comboBoxSortBy.SelectedIndexChanged += ComboBoxSortBy_SelectedIndexChanged;
            comboBoxFilterCourse.SelectedIndexChanged += ComboBoxFilterCourse_SelectedIndexChanged;
            comboBoxFilterGroup.SelectedIndexChanged += ComboBoxFilterGroup_SelectedIndexChanged;
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Student student = new Student(
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    textBoxMiddleName.Text,
                    (int)comboBoxCourse.SelectedItem,
                    textBoxGroup.Text,
                    dateTimePickerBirthDate.Value,
                    textBoxEmail.Text
                );

                students.Add(student);
                UpdateDataGridView();
                isDataChanged = true;
                ClearInputFields();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0 && ValidateInput())
            {
                int index = dataGridViewStudents.SelectedRows[0].Index;
                students[index] = new Student(
                    textBoxLastName.Text,
                    textBoxFirstName.Text,
                    textBoxMiddleName.Text,
                    (int)comboBoxCourse.SelectedItem,
                    textBoxGroup.Text,
                    dateTimePickerBirthDate.Value,
                    textBoxEmail.Text
                );

                UpdateDataGridView();
                isDataChanged = true;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int index = dataGridViewStudents.SelectedRows[0].Index;
                students.RemoveAt(index);
                UpdateDataGridView();
                isDataChanged = true;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML files (*.xml)|*.xml";
            saveDialog.DefaultExt = "xml";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        serializer.Serialize(writer, students);
                    }
                    isDataChanged = false;
                    MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "XML files (*.xml)|*.xml";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    using (StreamReader reader = new StreamReader(openDialog.FileName))
                    {
                        students = (List<Student>)serializer.Deserialize(reader);
                    }
                    UpdateDataGridView();
                    isDataChanged = false;
                    MessageBox.Show("Данные успешно загружены!", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV files (*.csv)|*.csv";
            saveDialog.DefaultExt = "csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine("Фамилия;Имя;Отчество;Курс;Группа;Дата рождения;Email");

                        foreach (var student in students)
                        {
                            writer.WriteLine($"{student.LastName};{student.FirstName};{student.MiddleName};" +
                                           $"{student.Course};{student.Group};{student.BirthDate.ToShortDateString()};{student.Email}");
                        }
                    }
                    MessageBox.Show("Данные успешно экспортированы!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Student> importedStudents = new List<Student>();
                    string[] lines = File.ReadAllLines(openDialog.FileName);

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(';');
                        if (values.Length == 7)
                        {
                            Student student = new Student(
                                values[0],
                                values[1],
                                values[2],
                                int.Parse(values[3]),
                                values[4],
                                DateTime.Parse(values[5]),
                                values[6]
                            );
                            importedStudents.Add(student);
                        }
                    }

                    students.AddRange(importedStudents);
                    UpdateDataGridView();
                    isDataChanged = true;
                    MessageBox.Show("Данные успешно импортированы!", "Импорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при импорте данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortBy = comboBoxSortBy.SelectedItem.ToString();
            switch (sortBy)
            {
                case "Фамилия":
                    students = students.OrderBy(s => s.LastName).ToList();
                    break;
                case "Группа":
                    students = students.OrderBy(s => s.Group).ToList();
                    break;
                case "Курс":
                    students = students.OrderBy(s => s.Course).ToList();
                    break;
            }
            UpdateDataGridView();
        }

        private void ComboBoxFilterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ComboBoxFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var filteredStudents = students.AsQueryable();

            if (comboBoxFilterCourse.SelectedItem != null)
            {
                int course = (int)comboBoxFilterCourse.SelectedItem;
                filteredStudents = filteredStudents.Where(s => s.Course == course);
            }

            if (!string.IsNullOrEmpty(comboBoxFilterGroup.Text))
            {
                filteredStudents = filteredStudents.Where(s => s.Group == comboBoxFilterGroup.Text);
            }

            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                filteredStudents = filteredStudents.Where(s => s.LastName.Contains(textBoxSearch.Text));
            }

            UpdateDataGridView(filteredStudents.ToList());
        }

        private void UpdateDataGridView(List<Student> studentsToShow = null)
        {
            dataGridViewStudents.Rows.Clear();
            var studentsList = studentsToShow ?? students;

            foreach (var student in studentsList)
            {
                dataGridViewStudents.Rows.Add(
                    student.LastName,
                    student.FirstName,
                    student.MiddleName,
                    student.Course,
                    student.Group,
                    student.BirthDate.ToShortDateString(),
                    student.Email
                );
            }
        }

        private void ClearInputFields()
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxMiddleName.Clear();
            comboBoxCourse.SelectedIndex = -1;
            textBoxGroup.Clear();
            dateTimePickerBirthDate.Value = DateTime.Today;
            textBoxEmail.Clear();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxMiddleName.Text) ||
                comboBoxCourse.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxGroup.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Неверный формат email! Используйте домены: yandex.ru, gmail.com, icloud.com", 
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                string domain = addr.Host.ToLower();
                return email.Length >= 3 && 
                       (domain == "yandex.ru" || domain == "gmail.com" || domain == "icloud.com");
            }
            catch
            {
                return false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isDataChanged)
            {
                DialogResult result = MessageBox.Show(
                    "У вас есть несохраненные изменения. Хотите сохранить их перед выходом?",
                    "Предупреждение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ButtonSave_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }
    }
} 
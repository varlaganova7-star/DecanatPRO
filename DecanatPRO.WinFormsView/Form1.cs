using DecanatPRO.BusinessLogic;
using System;
using System.Windows.Forms;

namespace DecanatPRO.WinFormsView
{
    public partial class Form1 : Form
    {
        private Logic logic = new Logic();

        public Form1()
        {
            InitializeComponent();
            RefreshStudentList();
        }

        private void RefreshStudentList()
        {
            try
            {
                dataGridViewStudents.DataSource = null;
                var students = logic.GetAllStudents();

                if (students != null && students.Count > 0)
                {
                    dataGridViewStudents.DataSource = students;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка: {ex.Message}");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm(logic);
            addForm.ShowDialog();
            RefreshStudentList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value?.ToString();
                string speciality = selectedRow.Cells["Speciality"].Value?.ToString();
                string group = selectedRow.Cells["Group"].Value?.ToString();

                logic.DeleteStudent(name, speciality, group);
                RefreshStudentList();
                MessageBox.Show("Студент удален!");
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления!");
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            try
            {
                ChartForm chartForm = new ChartForm(logic);
                chartForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии гистограммы: {ex.Message}\n\nПодробности: {ex.StackTrace}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
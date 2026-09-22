using DecanatPRO.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecanatPRO.WinFormsView
{
    public partial class AddStudentForm : Form
    {

        private Logic logic;

        public AddStudentForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string speciality = textBoxSpeciality.Text.Trim();
            string group = textBoxGroup.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(speciality) || string.IsNullOrEmpty(group))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            logic.AddStudent(name, speciality, group);
            MessageBox.Show("Студент добавлен!");
            this.Close();
        }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


   
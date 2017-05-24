using System;
using System.Drawing;
using System.Windows.Forms;
using Taslim.BAL;
using Taslim.DAL.Model;

namespace Taslim
{
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }
        StudentPerformanceManager aStudentPerformanceManager = new StudentPerformanceManager();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduleSelect mo = new moduleSelect();
            mo.Show();
        }


        private void attendance_Load(object sender, EventArgs e)
        {
            departmentComboBox.SelectedIndex = 0;
            semesterComboBox.SelectedIndex = 0;
            batchComboBox.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

        }

        StudentPerformanceManager studentPerformanceManager = new StudentPerformanceManager();

        private void insertButton_Click(object sender, EventArgs e)
        {
            StudentPerformance student = new StudentPerformance();

            student.Department = departmentComboBox.Text;
            student.Semester = semesterComboBox.Text;
            student.Batch = batchComboBox.Text;
            student.StudentId = studnetIdTextBox.Text;
            student.Exam = Convert.ToDecimal(examTextBox.Text);
            student.ExtraCurriculum = Convert.ToDecimal(extraCurriculumTextBox.Text);
            student.TotalPerformanceValue = Convert.ToDecimal(performanceTextBox.Text);


            string message = studentPerformanceManager.Add(student);
        }

        public void clear()
        {
            departmentComboBox.SelectedIndex = 0;
            semesterComboBox.SelectedIndex = 0;
            batchComboBox.SelectedIndex = 0;
            studnetIdTextBox.Text = String.Empty;
            examTextBox.Text = String.Empty;
            extraCurriculumTextBox.Text = String.Empty;
            performanceTextBox.Text = String.Empty;
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(examTextBox.Text)) || (string.IsNullOrEmpty(extraCurriculumTextBox.Text)))
            {
                MessageBox.Show("Please insert a number any value", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                decimal exam, extracurriculum, TotalValue;

                exam = Convert.ToDecimal(examTextBox.Text);
                extracurriculum = Convert.ToDecimal(extraCurriculumTextBox.Text);


                decimal total = (exam + extracurriculum);

                TotalValue = Convert.ToDecimal(total);
                if (TotalValue >= 0)
                {
                    performanceTextBox.Text = TotalValue.ToString();

                }
                else
                {
                    performanceTextBox.Text = "Not Accepted your Discount ";
                    performanceTextBox.BackColor = Color.Red;
                }
            }
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string department = comboBox1.Text;
            if (department == "CSE")
            {
                DepartmentMaxPer aStudent = aStudentPerformanceManager.FindMaxPerformanceCSE();
                ClearTextBox();
                txt_IDCSE.Text = aStudent.StudentID.ToString();
                txt_Department.Text = aStudent.Department;
                txt_MaxPerformanceValueCSE.Text = aStudent.MaxPerformanceValue.ToString();
            }
            else if (department == "EEE")
            {
                DepartmentMaxPer aStudentEEE = aStudentPerformanceManager.FindMaxPerformanceEEE();
                ClearTextBox();
                txt_IDCSE.Text = aStudentEEE.StudentID.ToString();
                txt_Department.Text = aStudentEEE.Department;
                txt_MaxPerformanceValueCSE.Text = aStudentEEE.MaxPerformanceValue.ToString();
            }
            else
            {
                ClearTextBox();
            }
        }

        private void ClearTextBox()
        {
            txt_IDCSE.Text = String.Empty;
            txt_Department.Text = String.Empty;
            txt_MaxPerformanceValueCSE.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentMaxPer aStudentCSE = aStudentPerformanceManager.FindMaxPerformanceCSE();
            decimal PerformanceCSE = aStudentCSE.MaxPerformanceValue;

            DepartmentMaxPer aStudentEEE = aStudentPerformanceManager.FindMaxPerformanceEEE();
            decimal PerformanceEEE = aStudentEEE.MaxPerformanceValue;

            if (PerformanceCSE > PerformanceEEE)
            {
                textBox1.Text = aStudentCSE.MaxPerformanceValue.ToString();
                textBox2.Text = aStudentCSE.Department;
                textBox3.Text = aStudentCSE.StudentID.ToString();
            }
            else if (PerformanceEEE > PerformanceCSE)
            {
                textBox1.Text = aStudentEEE.MaxPerformanceValue.ToString();
                textBox2.Text = aStudentEEE.Department;
                textBox3.Text = aStudentEEE.StudentID.ToString();
            }
            else
            {
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                MessageBox.Show("Performance Value are equal !", "Same", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

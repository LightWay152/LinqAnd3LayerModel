using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QueryLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private class Student
        {
            public int Id { set; get; }
            public string Name { set; get; }
            public int Age { set; get; }
        }

        private class Class
        {
            public int Id { set; get; }
            public string ClassName { set; get; }
        }

        private List<Student> students = new List<Student> { new Student {Id=1,Name="An",Age=15},
                                                     new Student {Id=2,Name="Bao",Age=20},
                                                     new Student {Id=2,Name="Bao",Age=20},
                                                     new Student {Id=3,Name="Binh",Age=25}
                                                    };

        private List<Class> classes = new List<Class> { new Class {Id=1,ClassName="Class A"},
                                                     new Class {Id=2,ClassName="Class B"}
                                                };

        private void btnSelect_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       where student.Age >= int.Parse(txtWhere.Text)
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int stu = (from student in students
                       select student.Age).Sum();
            MessageBox.Show("Sum of student's age is: " + stu);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int stu = (from student in students
                       select student.Age).Max();
            MessageBox.Show("Max of student's age is: " + stu);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int stu = (from student in students
                       select student.Age).Min();
            MessageBox.Show("Min of student's age is: " + stu);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double stu = (from student in students
                          select student.Age).Average();
            MessageBox.Show("Average of student's age is: " + stu);
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = (from student in students
                                        select student).Take(2);
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = (from student in students
                                        select student).Skip(2);
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       where student.Name.StartsWith("B")
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       where student.Name.EndsWith("o")
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnOrderByASC_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       orderby student.Id ascending
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnOrderByDSC_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       orderby student.Id descending
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            var stu = from student in students
                      group student by student.Name;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int stu = (from student in students
                       select student).Count();
            MessageBox.Show("Number of students are: " + stu);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            string stu = (from student in students
                          select student).FirstOrDefault().Name;
            MessageBox.Show("Name of first student is: " + stu);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            string stu = (from student in students
                          select student).LastOrDefault().Name;
            MessageBox.Show("Name of Last student is: " + stu);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       where student.Name.Contains(txtContains.Text)
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            IEnumerable<Student> stu = from student in students
                                       where student.Age.Equals(int.Parse(txtEquals.Text))
                                       select student;
            dgvDisplay.DataSource = stu.ToList();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var ClassStudent = (from student in students
                                join classOfStudent in classes on student.Id equals classOfStudent.Id
                                select new { ClassName = classOfStudent.ClassName, Name = student.Name, Age = student.Age }).Distinct();
            dgvDisplay.DataSource = ClassStudent.ToList();
        }
    }
}
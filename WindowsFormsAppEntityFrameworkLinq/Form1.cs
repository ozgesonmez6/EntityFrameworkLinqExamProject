using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFrameworkLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbExamEntities db = new DbExamEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //Student List with Entity Framework
            
            dataGridView1.DataSource = db.Student.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnLessonList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EntityFrameworkLinqDbExam;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * from lesson", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnNoteList_Click(object sender, EventArgs e)
        {
            var query = from item in db.Note
                        select new
                        {
                            item.NoteId,
                            item.Student1.Name,
                            item.Student1.Lastname,
                            item.Lesson1.LessonName,
                            item.Exam1,
                            item.Exam2,
                            item.Exam3,
                            item.Average,
                            item.Status,
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = TxtName.Text;
            s.Lastname = TxtLastname.Text;
            db.Student.Add(s);
            db.SaveChanges();
            MessageBox.Show("Öğrenci listeye eklendi!");

            //Lesson l = new Lesson();
            //l.LessonName = TxtLessonName.Text;
            //db.Lesson.Add(l);
            //db.SaveChanges();
            //MessageBox.Show("Ders listeye eklendi!"); 

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentID.Text);
            var x = db.Student.Find(id);
            db.Student.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silindi!");

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentID.Text);
            var x = db.Student.Find(id);
            x.Name = TxtName.Text;
            x.Lastname = TxtLastname.Text;
            x.Photo = TxtPhotoLink.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci güncellendi!");
        }

        private void BtnProcedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NoteList();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Student.Where(x => x.Name == TxtName.Text | x.Lastname==TxtLastname.Text).ToList();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string search = TxtName.Text;
            var values = from item in db.Student
                         where item.Name.Contains(search)
                         select item;
            dataGridView1.DataSource = values.ToList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Asc - Ascending
                List<Student> list = db.Student.OrderBy(p => p.Name).ToList();
                dataGridView1.DataSource = list;
            }
            if (radioButton2.Checked == true)
            {
                //Desc - Descending
                List<Student> list = db.Student.OrderByDescending(p => p.Name).ToList();
                dataGridView1.DataSource = list;
            }
            if (radioButton3.Checked == true)
            {
                List<Student> list = db.Student.OrderBy(p => p.Name).Take(3).ToList();
                dataGridView1.DataSource = list;
            }
            if (radioButton4.Checked == true)
            {
                List<Student> list = db.Student.Where(p => p.Id == 5).ToList();
                dataGridView1.DataSource = list;
            }
            if (radioButton5.Checked == true)
            {
                List<Student> list = db.Student.Where(p => p.Name.StartsWith("a")).ToList();
                dataGridView1.DataSource = list;
            }
            if (radioButton6.Checked == true)
            {
                List<Student> list = db.Student.Where(p => p.Name.EndsWith("l")).ToList();
                dataGridView1.DataSource = list;
            }
            if (radioButton7.Checked == true)
            {
                bool value = db.Student.Any();
                MessageBox.Show(value.ToString());
            }
            if (radioButton8.Checked == true)
            {
                int total = db.Student.Count();
                MessageBox.Show(total.ToString());
            }
            if (radioButton9.Checked == true)
            {
                var total = db.Note.Sum(p => p.Exam1);
                MessageBox.Show(total.ToString());
            }
            if (radioButton10.Checked == true)
            {
                var average = db.Note.Average(p => p.Exam1);
                MessageBox.Show(average.ToString());
            }
            if (radioButton11.Checked == true)
            {
                var max = db.Note.Max(p => p.Exam1);
                MessageBox.Show(max.ToString());
            }
            if (radioButton12.Checked == true)
            {
                var min = db.Note.Min(p => p.Exam1);
                MessageBox.Show(min.ToString());
            }
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var query = from n in db.Note
                        join s in db.Student
                        on n.Student equals s.Id
                        join l in db.Lesson
                        on n.Lesson equals l.LessonId

                        select new
                        {
                            Student = s.Name,
                            Lastname = s.Lastname,
                            Lesson = l.LessonName,
                            Exam1 = n.Exam1,
                            Exam2 = n.Exam2,
                            Exam3 = n.Exam3,
                            Average=n.Average,
                        };

            dataGridView1.DataSource = query.ToList();
        }
    }
}

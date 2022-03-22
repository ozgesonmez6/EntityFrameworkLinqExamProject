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
                            item.Student,
                            item.Lesson,
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
    }
}

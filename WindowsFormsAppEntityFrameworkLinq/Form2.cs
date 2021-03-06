using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFrameworkLinq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DbExamEntities db = new DbExamEntities();
        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var values = db.Note.Where(x => x.Exam1 < 50);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton2.Checked == true)
            {
                var values = db.Student.Where(x => x.Name == "ali");
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton3.Checked == true)
            {
                var values = db.Student.Where(x => x.Name == textBox1.Text || x.Lastname == textBox1.Text);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton4.Checked == true)
            {
                var values = db.Student.Select(x => new { lastname = x.Lastname});
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton5.Checked == true)
            {
                var values = db.Student.Select(x => new { name=x.Name.ToUpper(), lastname=x.Lastname.ToLower() }).Where(x=>x.name != "ali");
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var values = db.Student.Select(x => new { name = x.Name.ToUpper(), lastname = x.Lastname.ToLower() });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton7.Checked == true)
            {
                var values = db.Note.Select(x =>new {name= x.Student, average=x.Average, status=x.Status==true ? "Geçti" : "Kaldı"});
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton8.Checked == true)
            {
                var values = db.Note.SelectMany(x => db.Student.Where(y => y.Id == x.Student),(x,y) => new
                { 
                    y.Name,
                    x.Average,
                });
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton9.Checked == true)
            {
                var values = db.Student.OrderBy(x => x.Id).Take(3);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton10.Checked == true)
            {
                var values = db.Student.OrderByDescending(x => x.Id).Take(3);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton11.Checked == true)
            {
                var values = db.Student.OrderBy(x => x.Name);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton12.Checked == true)
            {
                var values = db.Student.OrderBy(x => x.Id).Skip(5);
                dataGridView1.DataSource = values.ToList();
            }
        }
    }
}

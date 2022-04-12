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
        }
    }
}

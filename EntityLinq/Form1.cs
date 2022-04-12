using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityLinq
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
            //Her şehirde kaç öğrenci olduğunu listeleme
            var values = db.Student.OrderBy(x => x.City).GroupBy(y => y.City).Select(z=>new { city=z.Key, total=z.Count()});
            dataGridView1.DataSource = values.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = db.Note.Max(x => x.Average).ToString();
            label2.Text = db.Note.Min(x => x.Exam1).ToString();
        }
    }
}

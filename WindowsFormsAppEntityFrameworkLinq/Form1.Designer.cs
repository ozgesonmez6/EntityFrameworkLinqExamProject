
namespace WindowsFormsAppEntityFrameworkLinq
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStudentList = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPhotoLink = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lesson = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLessonName = new System.Windows.Forms.TextBox();
            this.TxtLessonID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.GroupBox();
            this.BtnExamUpdate = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLessonList = new System.Windows.Forms.Button();
            this.BtnNoteList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Student.SuspendLayout();
            this.Lesson.SuspendLayout();
            this.Note.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnStudentList
            // 
            this.BtnStudentList.Location = new System.Drawing.Point(12, 235);
            this.BtnStudentList.Name = "BtnStudentList";
            this.BtnStudentList.Size = new System.Drawing.Size(130, 37);
            this.BtnStudentList.TabIndex = 1;
            this.BtnStudentList.Text = "Student List";
            this.BtnStudentList.UseVisualStyleBackColor = true;
            this.BtnStudentList.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 278);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 37);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 321);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 37);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(12, 364);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(130, 37);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(12, 407);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(130, 37);
            this.BtnFind.TabIndex = 5;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.Controls.Add(this.label4);
            this.Student.Controls.Add(this.label3);
            this.Student.Controls.Add(this.label2);
            this.Student.Controls.Add(this.TxtPhotoLink);
            this.Student.Controls.Add(this.TxtLastname);
            this.Student.Controls.Add(this.TxtName);
            this.Student.Controls.Add(this.TxtStudentID);
            this.Student.Controls.Add(this.label1);
            this.Student.Location = new System.Drawing.Point(148, 241);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(247, 203);
            this.Student.TabIndex = 6;
            this.Student.TabStop = false;
            this.Student.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Photo Link :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lastname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name :";
            // 
            // TxtPhotoLink
            // 
            this.TxtPhotoLink.Location = new System.Drawing.Point(137, 151);
            this.TxtPhotoLink.Name = "TxtPhotoLink";
            this.TxtPhotoLink.Size = new System.Drawing.Size(100, 22);
            this.TxtPhotoLink.TabIndex = 18;
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(137, 108);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(100, 22);
            this.TxtLastname.TabIndex = 17;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(137, 65);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 16;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Location = new System.Drawing.Point(137, 29);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(100, 22);
            this.TxtStudentID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID :";
            // 
            // Lesson
            // 
            this.Lesson.Controls.Add(this.label7);
            this.Lesson.Controls.Add(this.TxtLessonName);
            this.Lesson.Controls.Add(this.TxtLessonID);
            this.Lesson.Controls.Add(this.label8);
            this.Lesson.Location = new System.Drawing.Point(148, 460);
            this.Lesson.Name = "Lesson";
            this.Lesson.Size = new System.Drawing.Size(247, 110);
            this.Lesson.TabIndex = 7;
            this.Lesson.TabStop = false;
            this.Lesson.Text = "Lesson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Name :";
            // 
            // TxtLessonName
            // 
            this.TxtLessonName.Location = new System.Drawing.Point(137, 65);
            this.TxtLessonName.Name = "TxtLessonName";
            this.TxtLessonName.Size = new System.Drawing.Size(100, 22);
            this.TxtLessonName.TabIndex = 16;
            // 
            // TxtLessonID
            // 
            this.TxtLessonID.Location = new System.Drawing.Point(137, 29);
            this.TxtLessonID.Name = "TxtLessonID";
            this.TxtLessonID.Size = new System.Drawing.Size(100, 22);
            this.TxtLessonID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID :";
            // 
            // Note
            // 
            this.Note.Controls.Add(this.BtnExamUpdate);
            this.Note.Controls.Add(this.BtnCalculate);
            this.Note.Controls.Add(this.TxtStatus);
            this.Note.Controls.Add(this.label11);
            this.Note.Controls.Add(this.label9);
            this.Note.Controls.Add(this.label6);
            this.Note.Controls.Add(this.label5);
            this.Note.Controls.Add(this.TxtAverage);
            this.Note.Controls.Add(this.TxtExam3);
            this.Note.Controls.Add(this.TxtExam2);
            this.Note.Controls.Add(this.TxtExam1);
            this.Note.Controls.Add(this.label10);
            this.Note.Location = new System.Drawing.Point(438, 241);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(265, 329);
            this.Note.TabIndex = 8;
            this.Note.TabStop = false;
            this.Note.Text = "Note";
            // 
            // BtnExamUpdate
            // 
            this.BtnExamUpdate.Location = new System.Drawing.Point(107, 267);
            this.BtnExamUpdate.Name = "BtnExamUpdate";
            this.BtnExamUpdate.Size = new System.Drawing.Size(130, 37);
            this.BtnExamUpdate.TabIndex = 25;
            this.BtnExamUpdate.Text = "Exam Update";
            this.BtnExamUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(107, 219);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(130, 37);
            this.BtnCalculate.TabIndex = 24;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(137, 186);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(100, 22);
            this.TxtStatus.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Status :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Average :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Exam 3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Exam 2 :";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(137, 151);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(100, 22);
            this.TxtAverage.TabIndex = 18;
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(137, 108);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(100, 22);
            this.TxtExam3.TabIndex = 17;
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(137, 65);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(100, 22);
            this.TxtExam2.TabIndex = 16;
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(137, 29);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(100, 22);
            this.TxtExam1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Exam 1 :";
            // 
            // BtnLessonList
            // 
            this.BtnLessonList.Location = new System.Drawing.Point(12, 450);
            this.BtnLessonList.Name = "BtnLessonList";
            this.BtnLessonList.Size = new System.Drawing.Size(130, 37);
            this.BtnLessonList.TabIndex = 9;
            this.BtnLessonList.Text = "Lesson List";
            this.BtnLessonList.UseVisualStyleBackColor = true;
            this.BtnLessonList.Click += new System.EventHandler(this.BtnLessonList_Click);
            // 
            // BtnNoteList
            // 
            this.BtnNoteList.Location = new System.Drawing.Point(12, 493);
            this.BtnNoteList.Name = "BtnNoteList";
            this.BtnNoteList.Size = new System.Drawing.Size(130, 37);
            this.BtnNoteList.TabIndex = 10;
            this.BtnNoteList.Text = "Note List";
            this.BtnNoteList.UseVisualStyleBackColor = true;
            this.BtnNoteList.Click += new System.EventHandler(this.BtnNoteList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.BtnNoteList);
            this.Controls.Add(this.BtnLessonList);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Lesson);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnStudentList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Student.ResumeLayout(false);
            this.Student.PerformLayout();
            this.Lesson.ResumeLayout(false);
            this.Lesson.PerformLayout();
            this.Note.ResumeLayout(false);
            this.Note.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStudentList;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.GroupBox Student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPhotoLink;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Lesson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLessonName;
        private System.Windows.Forms.TextBox TxtLessonID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Note;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLessonList;
        private System.Windows.Forms.Button BtnNoteList;
        private System.Windows.Forms.Button BtnExamUpdate;
        private System.Windows.Forms.Button BtnCalculate;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstSessionwindowsform.forms
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        public class RoundedPanel : Panel
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                int radius = 40;
                base.OnPaint(e);
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                this.Region = new Region(path);

            }
        }
        public class RoundedButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                int radius = 40;
                base.OnPaint(e);
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                this.Region = new Region(path);

            }
        }
        private void studentsToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StudentCreateAcount studentCreateAcount = new StudentCreateAcount();
            studentCreateAcount.ShowDialog();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherCreateAcount teacherCreateAcount = new TeacherCreateAcount();
            teacherCreateAcount.ShowDialog();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void EnglishEnrollButton_Click(object sender, EventArgs e)
        {
            EnglishForm englishForm = new EnglishForm();
            englishForm.ShowDialog();
        }

        private void FrenchEnrollButton_Click(object sender, EventArgs e)
        {
            FrenchForm frenchForm = new FrenchForm();
            frenchForm.ShowDialog();
        }

        private void SpanishEnrollButton_Click(object sender, EventArgs e)
        {
            SpanishForm spanishForm = new SpanishForm();
            spanishForm.ShowDialog();
        }

        private void GermanEnrollButton_Click(object sender, EventArgs e)
        {
            GermanForm germanForm = new GermanForm();
            germanForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            StudentCreateAcount studentCreateAcount = new StudentCreateAcount();
            studentCreateAcount.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TeacherCreateAcount teacherCreateAcount = new TeacherCreateAcount();
            teacherCreateAcount.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnglishForm englishForm = new EnglishForm();
        }

        private void informationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrenchForm frenchForm = new FrenchForm();
            frenchForm.ShowDialog();
        }

        private void informationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SpanishForm spanishForm = new SpanishForm();
            spanishForm.ShowDialog();
        }

        private void informationToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GermanForm germanForm = new GermanForm();
            germanForm.ShowDialog();
        }
    }
}

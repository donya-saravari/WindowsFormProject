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
    public partial class GermanForm : Form
    {
        public GermanForm()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
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

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnglishForm englishForm = new EnglishForm();
            englishForm.ShowDialog();
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
    }

}

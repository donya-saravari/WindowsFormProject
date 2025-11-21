using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace firstSessionwindowsform.forms
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
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

    }
}

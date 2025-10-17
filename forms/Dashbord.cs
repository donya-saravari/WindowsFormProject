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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        private void Dashbord_Load(object sender, EventArgs e)
        {

        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentCreateAcount studentCreateAcount = new StudentCreateAcount();
            studentCreateAcount.ShowDialog();
        }

        private void coursesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.ShowDialog();
        }
    }
}

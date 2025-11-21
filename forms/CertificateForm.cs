using System;
using System.Windows.Forms;
using BaseBackend.classes;
using BaseBackend.Services;

namespace firstSessionwindowsform.EnglishForms
{
    public partial class CertificateForm : Form
    {
        public CertificateForm(int studentId)
        {
            InitializeComponent();
            LoadCertificate(studentId);
        }

        private void LoadCertificate(int studentId)
        {
            CertificateService service = new CertificateService();
            Certificate cert = service.GetByStudentId(studentId);

            if (cert != null)
            {
                // نمایش اطلاعات روی کنترل‌ها
                labelStudentName.Text = cert.StudentId.FullName;
                labelTeacherValue.Text = cert.TeacherName.FullName;
                labelCourseValue.Text = cert.CourseId.CourseTitle;
                labelGradeValue.Text = cert.Status.ToString();
                labelDateValue.Text = cert.Date.ToString("yyyy/MM/dd");
            }
            else
            {
                MessageBox.Show("گواهی‌نامه‌ای برای این دانشجو یافت نشد.");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            CertificateService service = new CertificateService();
            Certificate cert = service.GetByStudentId(1); // یا studentId واقعی

            if (cert != null)
            {
                CertificatePrinter printer = new CertificatePrinter(cert);
                printer.Print();
            }
            else
            {
                MessageBox.Show("اطلاعاتی برای چاپ یافت نشد.");
            }
        }
    }
}
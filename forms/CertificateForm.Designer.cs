namespace firstSessionwindowsform.EnglishForms
{
    partial class CertificateForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateForm));
            panelCertificate = new Panel();
            buttonPrint = new Button();
            pictureBoxSeal = new PictureBox();
            tableLayoutPanelInfo = new TableLayoutPanel();
            labelTeacherTitle = new Label();
            labelTeacherValue = new Label();
            labelCourseTitle = new Label();
            labelCourseValue = new Label();
            labelGradeTitle = new Label();
            labelGradeValue = new Label();
            labelDateTitle = new Label();
            labelDateValue = new Label();
            labelStudentName = new Label();
            labelTitle = new Label();
            panelCertificate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeal).BeginInit();
            tableLayoutPanelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelCertificate
            // 
            panelCertificate.Controls.Add(buttonPrint);
            panelCertificate.Controls.Add(pictureBoxSeal);
            panelCertificate.Controls.Add(tableLayoutPanelInfo);
            panelCertificate.Controls.Add(labelStudentName);
            panelCertificate.Controls.Add(labelTitle);
            panelCertificate.Dock = DockStyle.Fill;
            panelCertificate.Location = new Point(0, 0);
            panelCertificate.Name = "panelCertificate";
            panelCertificate.Size = new Size(800, 450);
            panelCertificate.TabIndex = 0;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.BlueViolet;
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(73, 365);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(94, 29);
            buttonPrint.TabIndex = 0;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // pictureBoxSeal
            // 
            pictureBoxSeal.BackColor = Color.Transparent;
            pictureBoxSeal.Image = (Image)resources.GetObject("pictureBoxSeal.Image");
            pictureBoxSeal.Location = new Point(607, 288);
            pictureBoxSeal.Name = "pictureBoxSeal";
            pictureBoxSeal.Size = new Size(150, 150);
            pictureBoxSeal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSeal.TabIndex = 1;
            pictureBoxSeal.TabStop = false;
            // 
            // tableLayoutPanelInfo
            // 
            tableLayoutPanelInfo.ColumnCount = 2;
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelInfo.Controls.Add(labelTeacherTitle, 0, 0);
            tableLayoutPanelInfo.Controls.Add(labelTeacherValue, 1, 0);
            tableLayoutPanelInfo.Controls.Add(labelCourseTitle, 0, 1);
            tableLayoutPanelInfo.Controls.Add(labelCourseValue, 1, 1);
            tableLayoutPanelInfo.Controls.Add(labelGradeTitle, 0, 2);
            tableLayoutPanelInfo.Controls.Add(labelGradeValue, 1, 2);
            tableLayoutPanelInfo.Controls.Add(labelDateTitle, 0, 3);
            tableLayoutPanelInfo.Controls.Add(labelDateValue, 1, 3);
            tableLayoutPanelInfo.Location = new Point(201, 140);
            tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            tableLayoutPanelInfo.RowCount = 4;
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelInfo.Size = new Size(400, 200);
            tableLayoutPanelInfo.TabIndex = 2;
            // 
            // labelTeacherTitle
            // 
            labelTeacherTitle.Location = new Point(3, 0);
            labelTeacherTitle.Name = "labelTeacherTitle";
            labelTeacherTitle.Size = new Size(100, 23);
            labelTeacherTitle.TabIndex = 0;
            labelTeacherTitle.Text = "Teacher:";
            // 
            // labelTeacherValue
            // 
            labelTeacherValue.Location = new Point(163, 0);
            labelTeacherValue.Name = "labelTeacherValue";
            labelTeacherValue.Size = new Size(100, 23);
            labelTeacherValue.TabIndex = 1;
            labelTeacherValue.Text = "-";
            // 
            // labelCourseTitle
            // 
            labelCourseTitle.Location = new Point(3, 50);
            labelCourseTitle.Name = "labelCourseTitle";
            labelCourseTitle.Size = new Size(100, 23);
            labelCourseTitle.TabIndex = 2;
            labelCourseTitle.Text = "Course:";
            // 
            // labelCourseValue
            // 
            labelCourseValue.Location = new Point(163, 50);
            labelCourseValue.Name = "labelCourseValue";
            labelCourseValue.Size = new Size(100, 23);
            labelCourseValue.TabIndex = 3;
            labelCourseValue.Text = "-";
            // 
            // labelGradeTitle
            // 
            labelGradeTitle.Location = new Point(3, 100);
            labelGradeTitle.Name = "labelGradeTitle";
            labelGradeTitle.Size = new Size(100, 23);
            labelGradeTitle.TabIndex = 4;
            labelGradeTitle.Text = "Grade:";
            // 
            // labelGradeValue
            // 
            labelGradeValue.Location = new Point(163, 100);
            labelGradeValue.Name = "labelGradeValue";
            labelGradeValue.Size = new Size(100, 23);
            labelGradeValue.TabIndex = 5;
            labelGradeValue.Text = "-";
            // 
            // labelDateTitle
            // 
            labelDateTitle.Location = new Point(3, 150);
            labelDateTitle.Name = "labelDateTitle";
            labelDateTitle.Size = new Size(100, 23);
            labelDateTitle.TabIndex = 6;
            labelDateTitle.Text = "Date:";
            // 
            // labelDateValue
            // 
            labelDateValue.Location = new Point(163, 150);
            labelDateValue.Name = "labelDateValue";
            labelDateValue.Size = new Size(100, 23);
            labelDateValue.TabIndex = 7;
            labelDateValue.Text = "-";
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Segoe Script", 16F);
            labelStudentName.Location = new Point(273, 70);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(228, 42);
            labelStudentName.TabIndex = 3;
            labelStudentName.Text = "Student Name";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.BlueViolet;
            labelTitle.Location = new Point(173, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(465, 41);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "CERTIFICATE OF ACHIEVEMENT";
            // 
            // CertificateForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(panelCertificate);
            Name = "CertificateForm";
            Text = "Certificate";
            panelCertificate.ResumeLayout(false);
            panelCertificate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSeal).EndInit();
            tableLayoutPanelInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCertificate;
        private Button buttonPrint;
        private PictureBox pictureBoxSeal;
        private TableLayoutPanel tableLayoutPanelInfo;
        private Label labelStudentName;
        private Label labelTitle;
        private Label labelTeacherTitle;
        private Label labelTeacherValue;
        private Label labelCourseTitle;
        private Label labelCourseValue;
        private Label labelGradeTitle;
        private Label labelGradeValue;
        private Label labelDateTitle;
        private Label labelDateValue;
    }
}
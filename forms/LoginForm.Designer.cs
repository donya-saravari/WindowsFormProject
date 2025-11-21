namespace firstSessionwindowsform
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LogInbutton = new Button();
            StudentRadioButton = new RadioButton();
            TeacherRadioButton = new RadioButton();
            CreateAcountLinkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            welcomeLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            RadioButtoErrorProvider = new ErrorProvider(components);
            RadioButtonGroupBox = new GroupBox();
            AdminRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioButtoErrorProvider).BeginInit();
            RadioButtonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(17, 133);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(85, 20);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "User Name:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(29, 173);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(109, 130);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(167, 27);
            UserNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(108, 170);
            PasswordTextBox.MaxLength = 20;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(168, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // LogInbutton
            // 
            LogInbutton.BackColor = Color.Black;
            LogInbutton.ForeColor = Color.White;
            LogInbutton.Location = new Point(182, 251);
            LogInbutton.Name = "LogInbutton";
            LogInbutton.Size = new Size(94, 29);
            LogInbutton.TabIndex = 4;
            LogInbutton.Text = "Log In";
            LogInbutton.UseVisualStyleBackColor = false;
            LogInbutton.Click += LogInbutton_Click;
            // 
            // StudentRadioButton
            // 
            StudentRadioButton.AutoSize = true;
            StudentRadioButton.Location = new Point(172, 6);
            StudentRadioButton.Name = "StudentRadioButton";
            StudentRadioButton.Size = new Size(81, 24);
            StudentRadioButton.TabIndex = 5;
            StudentRadioButton.TabStop = true;
            StudentRadioButton.Text = "Student";
            StudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // TeacherRadioButton
            // 
            TeacherRadioButton.AutoSize = true;
            TeacherRadioButton.Location = new Point(83, 6);
            TeacherRadioButton.Name = "TeacherRadioButton";
            TeacherRadioButton.Size = new Size(81, 24);
            TeacherRadioButton.TabIndex = 6;
            TeacherRadioButton.TabStop = true;
            TeacherRadioButton.Text = "Teacher";
            TeacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateAcountLinkLabel
            // 
            CreateAcountLinkLabel.AutoSize = true;
            CreateAcountLinkLabel.Location = new Point(29, 254);
            CreateAcountLinkLabel.Name = "CreateAcountLinkLabel";
            CreateAcountLinkLabel.Size = new Size(103, 20);
            CreateAcountLinkLabel.TabIndex = 8;
            CreateAcountLinkLabel.TabStop = true;
            CreateAcountLinkLabel.Text = "Create Acount";
            CreateAcountLinkLabel.LinkClicked += CreateAcountLinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(293, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 333);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            welcomeLabel.Location = new Point(82, 33);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(106, 28);
            welcomeLabel.TabIndex = 10;
            welcomeLabel.Text = "Welcome!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(10, 71);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 11;
            label1.Text = "Please enter your informations to log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(145, 258);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 12;
            label2.Text = "OR";
            // 
            // RadioButtoErrorProvider
            // 
            RadioButtoErrorProvider.ContainerControl = this;
            // 
            // RadioButtonGroupBox
            // 
            RadioButtonGroupBox.Controls.Add(AdminRadioButton);
            RadioButtonGroupBox.Controls.Add(StudentRadioButton);
            RadioButtonGroupBox.Controls.Add(TeacherRadioButton);
            RadioButtonGroupBox.Location = new Point(10, 208);
            RadioButtonGroupBox.Name = "RadioButtonGroupBox";
            RadioButtonGroupBox.Size = new Size(266, 37);
            RadioButtonGroupBox.TabIndex = 13;
            RadioButtonGroupBox.TabStop = false;
            // 
            // AdminRadioButton
            // 
            AdminRadioButton.AutoSize = true;
            AdminRadioButton.Location = new Point(5, 6);
            AdminRadioButton.Name = "AdminRadioButton";
            AdminRadioButton.Size = new Size(74, 24);
            AdminRadioButton.TabIndex = 15;
            AdminRadioButton.TabStop = true;
            AdminRadioButton.Text = "Admin";
            AdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 332);
            Controls.Add(RadioButtonGroupBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(welcomeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(CreateAcountLinkLabel);
            Controls.Add(LogInbutton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioButtoErrorProvider).EndInit();
            RadioButtonGroupBox.ResumeLayout(false);
            RadioButtonGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button LogInbutton;
        private RadioButton StudentRadioButton;
        private RadioButton TeacherRadioButton;
        private LinkLabel CreateAcountLinkLabel;
        private PictureBox pictureBox1;
        private Label welcomeLabel;
        private Label label1;
        private Label label2;
        private ErrorProvider RadioButtoErrorProvider;
        private GroupBox RadioButtonGroupBox;
        private RadioButton AdminRadioButton;
    }
}

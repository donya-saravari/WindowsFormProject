namespace firstSessionwindowsform.forms
{
    partial class TeacherCreateAcount
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
            ResetButton = new Button();
            BirthDateDateTimePicker = new DateTimePicker();
            createAcountButton = new Button();
            registerDatedateTimePicker = new DateTimePicker();
            BirthDateLabel = new Label();
            nationalCodeLabel = new Label();
            nationalCodeTextBox = new TextBox();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            TeacherIdLabel = new Label();
            TeacherIDTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            DegreeComboBox = new ComboBox();
            DegreeLabel = new Label();
            PasswordLabel = new Label();
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.LightCoral;
            ResetButton.Location = new Point(360, 195);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 31;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // BirthDateDateTimePicker
            // 
            BirthDateDateTimePicker.Location = new Point(373, 108);
            BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            BirthDateDateTimePicker.Size = new Size(251, 27);
            BirthDateDateTimePicker.TabIndex = 30;
            // 
            // createAcountButton
            // 
            createAcountButton.BackColor = Color.LightGreen;
            createAcountButton.FlatAppearance.BorderColor = Color.LimeGreen;
            createAcountButton.Location = new Point(473, 195);
            createAcountButton.Name = "createAcountButton";
            createAcountButton.Size = new Size(137, 29);
            createAcountButton.TabIndex = 29;
            createAcountButton.Text = "Create Acount";
            createAcountButton.UseVisualStyleBackColor = false;
            createAcountButton.Click += createAcountButton_Click;
            // 
            // registerDatedateTimePicker
            // 
            registerDatedateTimePicker.Enabled = false;
            registerDatedateTimePicker.Location = new Point(374, 151);
            registerDatedateTimePicker.Name = "registerDatedateTimePicker";
            registerDatedateTimePicker.Size = new Size(250, 27);
            registerDatedateTimePicker.TabIndex = 28;
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(292, 113);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(75, 20);
            BirthDateLabel.TabIndex = 27;
            BirthDateLabel.Text = "BirthDate:";
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(15, 195);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(108, 20);
            nationalCodeLabel.TabIndex = 26;
            nationalCodeLabel.Text = "National Code:";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(133, 195);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(125, 27);
            nationalCodeTextBox.TabIndex = 25;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(16, 149);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(111, 20);
            phoneNumberLabel.TabIndex = 24;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(133, 147);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(125, 27);
            phoneNumberTextBox.TabIndex = 23;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(16, 103);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(15, 55);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name:";
            // 
            // TeacherIdLabel
            // 
            TeacherIdLabel.AutoSize = true;
            TeacherIdLabel.Location = new Point(16, 18);
            TeacherIdLabel.Name = "TeacherIdLabel";
            TeacherIdLabel.Size = new Size(82, 20);
            TeacherIdLabel.TabIndex = 20;
            TeacherIdLabel.Text = "Teacher ID:";
            // 
            // TeacherIDTextBox
            // 
            TeacherIDTextBox.Enabled = false;
            TeacherIDTextBox.Location = new Point(133, 11);
            TeacherIDTextBox.Name = "TeacherIDTextBox";
            TeacherIDTextBox.Size = new Size(125, 27);
            TeacherIDTextBox.TabIndex = 19;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(133, 55);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 18;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(133, 100);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 17;
            // 
            // DegreeComboBox
            // 
            DegreeComboBox.FormattingEnabled = true;
            DegreeComboBox.Location = new Point(133, 240);
            DegreeComboBox.Name = "DegreeComboBox";
            DegreeComboBox.Size = new Size(125, 28);
            DegreeComboBox.TabIndex = 32;
            // 
            // DegreeLabel
            // 
            DegreeLabel.AutoSize = true;
            DegreeLabel.Location = new Point(16, 243);
            DegreeLabel.Name = "DegreeLabel";
            DegreeLabel.Size = new Size(65, 20);
            DegreeLabel.TabIndex = 33;
            DegreeLabel.Text = "Degree: ";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(292, 55);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 37;
            PasswordLabel.Text = "Password:";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(292, 18);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(85, 20);
            UserNameLabel.TabIndex = 36;
            UserNameLabel.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Enabled = false;
            UserNameTextBox.Location = new Point(409, 11);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(125, 27);
            UserNameTextBox.TabIndex = 35;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(409, 55);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 34;
            // 
            // TeacherCreateAcount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 284);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(DegreeLabel);
            Controls.Add(DegreeComboBox);
            Controls.Add(ResetButton);
            Controls.Add(BirthDateDateTimePicker);
            Controls.Add(createAcountButton);
            Controls.Add(registerDatedateTimePicker);
            Controls.Add(BirthDateLabel);
            Controls.Add(nationalCodeLabel);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(TeacherIdLabel);
            Controls.Add(TeacherIDTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Name = "TeacherCreateAcount";
            Text = "TeacherCreateAcount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetButton;
        private DateTimePicker BirthDateDateTimePicker;
        private Button createAcountButton;
        private DateTimePicker registerDatedateTimePicker;
        private Label BirthDateLabel;
        private Label nationalCodeLabel;
        private TextBox nationalCodeTextBox;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label TeacherIdLabel;
        private TextBox TeacherIDTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private ComboBox DegreeComboBox;
        private Label DegreeLabel;
        private Label PasswordLabel;
        private Label UserNameLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
    }
}
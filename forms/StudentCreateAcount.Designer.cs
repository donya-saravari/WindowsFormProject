namespace firstSessionwindowsform
{
    partial class StudentCreateAcount
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
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            studentIdTextBox = new TextBox();
            StudentIdLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            nationalCodeLabel = new Label();
            nationalCodeTextBox = new TextBox();
            birthDateLabel = new Label();
            registerDatedateTimePicker = new DateTimePicker();
            createAcountButton = new Button();
            AgeDateTimePicker = new DateTimePicker();
            ResetButton = new Button();
            PasswordLabel = new Label();
            UserNameLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(129, 97);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(129, 52);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Enabled = false;
            studentIdTextBox.Location = new Point(129, 8);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(125, 27);
            studentIdTextBox.TabIndex = 2;
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Location = new Point(12, 15);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new Size(82, 20);
            StudentIdLabel.TabIndex = 3;
            StudentIdLabel.Text = "Student ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(11, 52);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 100);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(82, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(12, 146);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(111, 20);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(129, 144);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(125, 27);
            phoneNumberTextBox.TabIndex = 6;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(372, 15);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(108, 20);
            nationalCodeLabel.TabIndex = 9;
            nationalCodeLabel.Text = "National Code:";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(497, 12);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(125, 27);
            nationalCodeTextBox.TabIndex = 8;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(290, 52);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(75, 20);
            birthDateLabel.TabIndex = 11;
            birthDateLabel.Text = "BirthDate:";
            // 
            // registerDatedateTimePicker
            // 
            registerDatedateTimePicker.Enabled = false;
            registerDatedateTimePicker.Location = new Point(372, 93);
            registerDatedateTimePicker.Name = "registerDatedateTimePicker";
            registerDatedateTimePicker.Size = new Size(250, 27);
            registerDatedateTimePicker.TabIndex = 12;
            // 
            // createAcountButton
            // 
            createAcountButton.BackColor = Color.LightGreen;
            createAcountButton.FlatAppearance.BorderColor = Color.LimeGreen;
            createAcountButton.Location = new Point(485, 142);
            createAcountButton.Name = "createAcountButton";
            createAcountButton.Size = new Size(137, 29);
            createAcountButton.TabIndex = 14;
            createAcountButton.Text = "Create Acount";
            createAcountButton.UseVisualStyleBackColor = false;
            createAcountButton.Click += createAcountButton_Click;
            // 
            // AgeDateTimePicker
            // 
            AgeDateTimePicker.Location = new Point(371, 52);
            AgeDateTimePicker.Name = "AgeDateTimePicker";
            AgeDateTimePicker.Size = new Size(251, 27);
            AgeDateTimePicker.TabIndex = 15;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.LightCoral;
            ResetButton.Location = new Point(372, 142);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 16;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(12, 229);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Password:";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(12, 192);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(85, 20);
            UserNameLabel.TabIndex = 19;
            UserNameLabel.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(129, 185);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(125, 27);
            UserNameTextBox.TabIndex = 18;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(129, 229);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 17;
            // 
            // StudentCreateAcount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 275);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(ResetButton);
            Controls.Add(AgeDateTimePicker);
            Controls.Add(createAcountButton);
            Controls.Add(registerDatedateTimePicker);
            Controls.Add(birthDateLabel);
            Controls.Add(nationalCodeLabel);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(StudentIdLabel);
            Controls.Add(studentIdTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Name = "StudentCreateAcount";
            Text = "Student Create Acount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox studentIdTextBox;
        private Label StudentIdLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private Label nationalCodeLabel;
        private TextBox nationalCodeTextBox;
        private Label birthDateLabel;
        private DateTimePicker registerDatedateTimePicker;
        private Button createAcountButton;
        private DateTimePicker AgeDateTimePicker;
        private Button ResetButton;
        private Label PasswordLabel;
        private Label UserNameLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
    }
}
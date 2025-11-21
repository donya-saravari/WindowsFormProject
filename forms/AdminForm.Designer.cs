namespace firstSessionwindowsform.forms
{
    partial class AdminForm
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
            CoursesDataGridView = new DataGridView();
            RegisterLabel = new Label();
            CourseLabel = new Label();
            CourseTextBox = new TextBox();
            SubmitButton = new Button();
            RegisterDateTimePicker = new DateTimePicker();
            ExamDateTimePicker = new DateTimePicker();
            ExamLlabel = new Label();
            TeacherLabel = new Label();
            CapacityLabel = new Label();
            AvailableLabel = new Label();
            PriceLabel = new Label();
            AvailableCheckBox = new CheckBox();
            CapacityNumericUpDown = new NumericUpDown();
            PriceTextBox = new TextBox();
            TeacherComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)CoursesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CapacityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // CoursesDataGridView
            // 
            CoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesDataGridView.Location = new Point(1, 164);
            CoursesDataGridView.Name = "CoursesDataGridView";
            CoursesDataGridView.RowHeadersWidth = 51;
            CoursesDataGridView.Size = new Size(827, 188);
            CoursesDataGridView.TabIndex = 0;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Location = new Point(12, 67);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(102, 20);
            RegisterLabel.TabIndex = 24;
            RegisterLabel.Text = "Register Date:";
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Location = new Point(20, 30);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(57, 20);
            CourseLabel.TabIndex = 23;
            CourseLabel.Text = "Course:";
            // 
            // CourseTextBox
            // 
            CourseTextBox.Location = new Point(137, 23);
            CourseTextBox.Name = "CourseTextBox";
            CourseTextBox.Size = new Size(125, 27);
            CourseTextBox.TabIndex = 22;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.LightGreen;
            SubmitButton.FlatAppearance.BorderColor = Color.LimeGreen;
            SubmitButton.Location = new Point(679, 106);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(137, 29);
            SubmitButton.TabIndex = 25;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // RegisterDateTimePicker
            // 
            RegisterDateTimePicker.Location = new Point(120, 62);
            RegisterDateTimePicker.Name = "RegisterDateTimePicker";
            RegisterDateTimePicker.Size = new Size(251, 27);
            RegisterDateTimePicker.TabIndex = 26;
            // 
            // ExamDateTimePicker
            // 
            ExamDateTimePicker.Location = new Point(120, 106);
            ExamDateTimePicker.Name = "ExamDateTimePicker";
            ExamDateTimePicker.Size = new Size(251, 27);
            ExamDateTimePicker.TabIndex = 27;
            // 
            // ExamLlabel
            // 
            ExamLlabel.AutoSize = true;
            ExamLlabel.Location = new Point(12, 111);
            ExamLlabel.Name = "ExamLlabel";
            ExamLlabel.Size = new Size(84, 20);
            ExamLlabel.TabIndex = 28;
            ExamLlabel.Text = "Exam Date:";
            // 
            // TeacherLabel
            // 
            TeacherLabel.AutoSize = true;
            TeacherLabel.Location = new Point(394, 30);
            TeacherLabel.Name = "TeacherLabel";
            TeacherLabel.Size = new Size(63, 20);
            TeacherLabel.TabIndex = 30;
            TeacherLabel.Text = "Teacher:";
            // 
            // CapacityLabel
            // 
            CapacityLabel.AutoSize = true;
            CapacityLabel.Location = new Point(394, 67);
            CapacityLabel.Name = "CapacityLabel";
            CapacityLabel.Size = new Size(69, 20);
            CapacityLabel.TabIndex = 31;
            CapacityLabel.Text = "Capacity:";
            // 
            // AvailableLabel
            // 
            AvailableLabel.AutoSize = true;
            AvailableLabel.Location = new Point(660, 30);
            AvailableLabel.Name = "AvailableLabel";
            AvailableLabel.Size = new Size(74, 20);
            AvailableLabel.TabIndex = 32;
            AvailableLabel.Text = "Available:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(400, 111);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(44, 20);
            PriceLabel.TabIndex = 33;
            PriceLabel.Text = "Price:";
            // 
            // AvailableCheckBox
            // 
            AvailableCheckBox.AutoSize = true;
            AvailableCheckBox.Location = new Point(741, 32);
            AvailableCheckBox.Name = "AvailableCheckBox";
            AvailableCheckBox.Size = new Size(18, 17);
            AvailableCheckBox.TabIndex = 34;
            AvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // CapacityNumericUpDown
            // 
            CapacityNumericUpDown.Location = new Point(511, 67);
            CapacityNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            CapacityNumericUpDown.Name = "CapacityNumericUpDown";
            CapacityNumericUpDown.Size = new Size(125, 27);
            CapacityNumericUpDown.TabIndex = 35;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(511, 111);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(125, 27);
            PriceTextBox.TabIndex = 36;
            // 
            // TeacherComboBox
            // 
            TeacherComboBox.FormattingEnabled = true;
            TeacherComboBox.Location = new Point(511, 23);
            TeacherComboBox.Name = "TeacherComboBox";
            TeacherComboBox.Size = new Size(125, 28);
            TeacherComboBox.TabIndex = 37;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(TeacherComboBox);
            Controls.Add(PriceTextBox);
            Controls.Add(CapacityNumericUpDown);
            Controls.Add(AvailableCheckBox);
            Controls.Add(PriceLabel);
            Controls.Add(AvailableLabel);
            Controls.Add(CapacityLabel);
            Controls.Add(TeacherLabel);
            Controls.Add(ExamLlabel);
            Controls.Add(ExamDateTimePicker);
            Controls.Add(RegisterDateTimePicker);
            Controls.Add(SubmitButton);
            Controls.Add(RegisterLabel);
            Controls.Add(CourseLabel);
            Controls.Add(CourseTextBox);
            Controls.Add(CoursesDataGridView);
            Name = "AdminForm";
            Text = "Create Course";
            ((System.ComponentModel.ISupportInitialize)CoursesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CapacityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CoursesDataGridView;
        private Label RegisterLabel;
        private Label CourseLabel;
        private TextBox CourseTextBox;
        private Button SubmitButton;
        private DateTimePicker RegisterDateTimePicker;
        private DateTimePicker ExamDateTimePicker;
        private Label ExamLlabel;
        private Label TeacherLabel;
        private Label CapacityLabel;
        private Label AvailableLabel;
        private Label PriceLabel;
        private CheckBox AvailableCheckBox;
        private NumericUpDown CapacityNumericUpDown;
        private TextBox PriceTextBox;
        private ComboBox TeacherComboBox;
    }
}
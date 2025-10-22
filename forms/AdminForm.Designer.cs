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
            ((System.ComponentModel.ISupportInitialize)CoursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CoursesDataGridView
            // 
            CoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesDataGridView.Location = new Point(-1, 164);
            CoursesDataGridView.Name = "CoursesDataGridView";
            CoursesDataGridView.RowHeadersWidth = 51;
            CoursesDataGridView.Size = new Size(430, 188);
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
            SubmitButton.Location = new Point(277, 23);
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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(ExamLlabel);
            Controls.Add(ExamDateTimePicker);
            Controls.Add(RegisterDateTimePicker);
            Controls.Add(SubmitButton);
            Controls.Add(RegisterLabel);
            Controls.Add(CourseLabel);
            Controls.Add(CourseTextBox);
            Controls.Add(CoursesDataGridView);
            Name = "Admin";
            Text = "Basket";
            ((System.ComponentModel.ISupportInitialize)CoursesDataGridView).EndInit();
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
    }
}
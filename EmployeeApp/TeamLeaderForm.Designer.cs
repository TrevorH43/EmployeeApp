namespace EmployeeApp
{
    partial class TeamLeaderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.monthlySalaryTextBox = new System.Windows.Forms.TextBox();
            this.monthlyBonusTextBox = new System.Windows.Forms.TextBox();
            this.trainingHrsRequiredTextBox = new System.Windows.Forms.TextBox();
            this.trainingHrsTakenTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Location = new System.Drawing.Point(486, 69);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(38, 15);
            this.employeeIDLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monthly Bonus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Training Hrs Required:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Training Hrs Completed:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(486, 114);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(188, 23);
            this.employeeNameTextBox.TabIndex = 13;
            // 
            // monthlySalaryTextBox
            // 
            this.monthlySalaryTextBox.Location = new System.Drawing.Point(486, 160);
            this.monthlySalaryTextBox.Name = "monthlySalaryTextBox";
            this.monthlySalaryTextBox.Size = new System.Drawing.Size(100, 23);
            this.monthlySalaryTextBox.TabIndex = 15;
            // 
            // monthlyBonusTextBox
            // 
            this.monthlyBonusTextBox.Location = new System.Drawing.Point(486, 204);
            this.monthlyBonusTextBox.Name = "monthlyBonusTextBox";
            this.monthlyBonusTextBox.Size = new System.Drawing.Size(100, 23);
            this.monthlyBonusTextBox.TabIndex = 17;
            // 
            // trainingHrsRequiredTextBox
            // 
            this.trainingHrsRequiredTextBox.Location = new System.Drawing.Point(486, 243);
            this.trainingHrsRequiredTextBox.Name = "trainingHrsRequiredTextBox";
            this.trainingHrsRequiredTextBox.Size = new System.Drawing.Size(100, 23);
            this.trainingHrsRequiredTextBox.TabIndex = 19;
            // 
            // trainingHrsTakenTextBox
            // 
            this.trainingHrsTakenTextBox.Location = new System.Drawing.Point(486, 281);
            this.trainingHrsTakenTextBox.Name = "trainingHrsTakenTextBox";
            this.trainingHrsTakenTextBox.Size = new System.Drawing.Size(100, 23);
            this.trainingHrsTakenTextBox.TabIndex = 21;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(343, 336);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(486, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TeamLeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.trainingHrsTakenTextBox);
            this.Controls.Add(this.trainingHrsRequiredTextBox);
            this.Controls.Add(this.monthlyBonusTextBox);
            this.Controls.Add(this.monthlySalaryTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.label1);
            this.Name = "TeamLeaderForm";
            this.Text = "TeamLeaderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label employeeIDLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox employeeNameTextBox;
        private TextBox monthlySalaryTextBox;
        private TextBox monthlyBonusTextBox;
        private TextBox trainingHrsRequiredTextBox;
        private TextBox trainingHrsTakenTextBox;
        private Button addButton;
        private Button cancelButton;
    }
}
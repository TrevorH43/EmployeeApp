namespace EmployeeApp
{
    partial class ProductionWorkerForm
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
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.hrsPerWeekTextBox = new System.Windows.Forms.TextBox();
            this.hrlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.shiftListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(379, 64);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(0, 15);
            this.employeeIDLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shift:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours Per Week:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hourly Pay Rate:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(379, 108);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(207, 23);
            this.employeeNameTextBox.TabIndex = 9;
            // 
            // hrsPerWeekTextBox
            // 
            this.hrsPerWeekTextBox.Location = new System.Drawing.Point(379, 221);
            this.hrsPerWeekTextBox.Name = "hrsPerWeekTextBox";
            this.hrsPerWeekTextBox.Size = new System.Drawing.Size(113, 23);
            this.hrsPerWeekTextBox.TabIndex = 11;
            // 
            // hrlyPayRateTextBox
            // 
            this.hrlyPayRateTextBox.Location = new System.Drawing.Point(379, 260);
            this.hrlyPayRateTextBox.Name = "hrlyPayRateTextBox";
            this.hrlyPayRateTextBox.Size = new System.Drawing.Size(113, 23);
            this.hrlyPayRateTextBox.TabIndex = 12;
            // 
            // shiftListBox
            // 
            this.shiftListBox.FormattingEnabled = true;
            this.shiftListBox.ItemHeight = 15;
            this.shiftListBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.shiftListBox.Location = new System.Drawing.Point(379, 137);
            this.shiftListBox.Name = "shiftListBox";
            this.shiftListBox.Size = new System.Drawing.Size(113, 79);
            this.shiftListBox.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(314, 336);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(433, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee ID:";
            // 
            // ProductionWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.shiftListBox);
            this.Controls.Add(this.hrlyPayRateTextBox);
            this.Controls.Add(this.hrsPerWeekTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeIDLabel);
            this.Name = "ProductionWorkerForm";
            this.Text = "ProductionWorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label employeeIDLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox employeeNameTextBox;
        private TextBox hrsPerWeekTextBox;
        private TextBox hrlyPayRateTextBox;
        private ListBox shiftListBox;
        private Button addButton;
        private Button cancelButton;
        private Label label1;
    }
}
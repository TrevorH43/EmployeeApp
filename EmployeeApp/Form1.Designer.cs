namespace EmployeeApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamLeadButton = new System.Windows.Forms.Button();
            this.supervisorButton = new System.Windows.Forms.Button();
            this.workerButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.43108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56891F));
            this.tableLayoutPanel1.Controls.Add(this.employeeDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // employeeDataGridView
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            this.employeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowTemplate.Height = 25;
            this.employeeDataGridView.Size = new System.Drawing.Size(658, 442);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.SelectionChanged += new System.EventHandler(this.employeeDataGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teamLeadButton);
            this.panel1.Controls.Add(this.supervisorButton);
            this.panel1.Controls.Add(this.workerButton);
            this.panel1.Controls.Add(this.displayButton);
            this.panel1.Location = new System.Drawing.Point(667, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 435);
            this.panel1.TabIndex = 1;
            // 
            // teamLeadButton
            // 
            this.teamLeadButton.Location = new System.Drawing.Point(3, 223);
            this.teamLeadButton.Name = "teamLeadButton";
            this.teamLeadButton.Size = new System.Drawing.Size(117, 44);
            this.teamLeadButton.TabIndex = 3;
            this.teamLeadButton.Text = "Add Team Leader";
            this.teamLeadButton.UseVisualStyleBackColor = true;
            this.teamLeadButton.Click += new System.EventHandler(this.teamLeadButton_Click);
            // 
            // supervisorButton
            // 
            this.supervisorButton.Location = new System.Drawing.Point(3, 158);
            this.supervisorButton.Name = "supervisorButton";
            this.supervisorButton.Size = new System.Drawing.Size(117, 43);
            this.supervisorButton.TabIndex = 2;
            this.supervisorButton.Text = "Add Supervisor";
            this.supervisorButton.UseVisualStyleBackColor = true;
            this.supervisorButton.Click += new System.EventHandler(this.supervisorButton_Click);
            // 
            // workerButton
            // 
            this.workerButton.Location = new System.Drawing.Point(0, 86);
            this.workerButton.Name = "workerButton";
            this.workerButton.Size = new System.Drawing.Size(123, 46);
            this.workerButton.TabIndex = 1;
            this.workerButton.Text = "Add Worker";
            this.workerButton.UseVisualStyleBackColor = true;
            this.workerButton.Click += new System.EventHandler(this.workerButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(3, 22);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(117, 40);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display Details";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView employeeDataGridView;
        private Panel panel1;
        private Button teamLeadButton;
        private Button supervisorButton;
        private Button workerButton;
        private Button displayButton;
    }
}
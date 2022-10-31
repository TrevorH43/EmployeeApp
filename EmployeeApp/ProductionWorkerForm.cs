using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class ProductionWorkerForm : Form
    {
        // Production Worker Instance
        public ProductionWorker productionWorker { get; private set; }

        public ProductionWorkerForm()
        {
            InitializeComponent();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        internal void AddNewEmployee(int employeeID)
        {
            employeeIDLabel.Text = employeeID.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            int employeeId = 0;
            int shiftNo = 0;
            int hoursWorked = 0;
            decimal hourlyPayRate = 0;

            try
            {
                // Validate the Employee ID
                if (!int.TryParse(employeeIDLabel.Text, out employeeId))
                    message.AppendLine("Employee ID has not been assigned. ");

                // Validate the Employee Name
                if (String.IsNullOrEmpty(employeeNameTextBox.Text))
                    message.AppendLine("Employee Name is required. ");

                // Validate the Shift
                if (shiftListBox.SelectedIndex < 0)
                    message.AppendLine("A shift must be selected. ");
                else
                    int.TryParse(shiftListBox.SelectedItem.ToString(), out shiftNo);

                // Validate the Hours Worked
                if (!int.TryParse(hrsPerWeekTextBox.Text, out hoursWorked))
                    message.AppendLine("Hours per Week is required. ");

                // Validate the Hourly Pay Rate
                if (!decimal.TryParse(hrlyPayRateTextBox.Text, out hourlyPayRate))
                    message.AppendLine("Hourly Pay Rate is required. ");

                if (message.Length == 0)
                {
                    productionWorker = new ProductionWorker(employeeId,
                        employeeNameTextBox.Text, shiftNo, hourlyPayRate, hoursWorked);

                    // Then Close the window.
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                // Add it to the message list to return
                message.AppendLine(ex.Message);
            }

            // If we had an error, the message length will be greater than 0
            if (message.Length > 0)
            {
                MessageBox.Show(message.ToString());
            }
        }
        internal void DisplayEmployee(ProductionWorker employee)
        {
            // Need to set our production worker instance
            productionWorker = employee;

            // Now use the data in the production worker instance to populate the form fields
            employeeIDLabel.Text = productionWorker.Id.ToString();
            employeeIDLabel.Enabled = false;
            employeeNameTextBox.Text = productionWorker.Name;
            employeeNameTextBox.Enabled = false;
            // Get the index of the element in the list
            var index = shiftListBox.Items.IndexOf(productionWorker.ShiftNumber.ToString());
            // Use the index to set the selected item in the listbox
            shiftListBox.SetSelected(index, true);
            shiftListBox.Enabled = false;
            hrsPerWeekTextBox.Text = productionWorker.HoursPerWeek.ToString();
            hrsPerWeekTextBox.Enabled = false;
            hrlyPayRateTextBox.Text = productionWorker.HourlyPayRate.ToString();
            hrlyPayRateTextBox.Enabled = false;

            // The last thing that needs to be done is to turn off the Add button
            addButton.Enabled = false;
        }


    }
}

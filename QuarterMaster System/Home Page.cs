using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterMaster_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            // Maximize only at runtime
            this.WindowState = FormWindowState.Maximized;

            if (GlobalVariables.elevatedPrivileges == true)
            {
                btnLogIn.Text = "Log Out";
            }
        }

        /// <summary>
        /// Handles the Equipment Search button click event.
        /// Hides the current form, opens the Equipment Search dialog, and restores the form after closing.
        /// </summary>
        private void btnEquipmentSearch_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Equipment_Search equipmentSearch = new Equipment_Search(); // Initialize the Equipment_Search form
            equipmentSearch.ShowDialog(); // Blocks until the new form is closed
            this.Show(); // Show this form again after the other one closes
        }

        ///<summary>
        /// Handles the Equipment List button click event.
        /// Hides the current form, opens the Equipment Lists dialog, and restores the form after closing.
        /// </summary>
        private void btnEquipmentList_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            EquipmentLists equipmentLists = new EquipmentLists(); //initialize the EquipmentLists form
            equipmentLists.ShowDialog(); // Blocks until the new form is closed
            this.Show(); // Show this form again after the other one closes
        }

        /// <summary>
        /// Handles the Calendar button click event.
        /// Hides the current form, opens the Calendar dialog, and restores the form after closing.
        /// </summary>
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Calendar calendar = new Calendar(); // Initialize the Calendar form
            calendar.ShowDialog(); // Blocks until the new form is closed
            this.Show(); // Show this form again after the other one closes\
            
        }
    }

    public static class GlobalVariables
    {
        public static bool elevatedPrivileges = true; // Static variable to track elevated privileges

        /// <summary>
        /// Gets the file path for the database file in the output directory.
        /// </summary>
        /// <returns>Full path to the QuarterMasterDB.mdf file.</returns>
        public static string GetDatabaseFilePath()
        {
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QuarterMasterDB.mdf"); // Full path to the database file always using the output directory

        }

        /// <summary>
        /// Gets the connection string for the local database.
        /// </summary>
        /// <returns>Connection string for the local database.</returns>
        public static string GetConnectionString()
        {
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={GetDatabaseFilePath()};Integrated Security=True"; // Connection string for the local database
        }

        public static Boolean isAddingNewItem = false; // Static variable to track if a new item is being added
    }
}

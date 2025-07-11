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

        private void btnEquipmentSearch_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Equipment_Search equipmentSearch = new Equipment_Search();
            equipmentSearch.ShowDialog(); // Blocks until the new form is closed
            this.Show(); // Show this form again after the other one closes
        }

        
    }

    public static class GlobalVariables
    {
        public static bool elevatedPrivileges = true; // Static variable to track elevated privileges

        public static string GetDatabaseFilePath()
        {
            // Always use the output directory
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QuarterMasterDB.mdf");
        }

        public static string GetConnectionString()
        {
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={GetDatabaseFilePath()};Integrated Security=True";
        }

        public static Boolean isAddingNewItem = false; // Static variable to track if a new item is being added
    }
}

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
    public partial class EquipmentLists : Form
    {
        public EquipmentLists()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximize the form at runtime
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
        }
    }
}

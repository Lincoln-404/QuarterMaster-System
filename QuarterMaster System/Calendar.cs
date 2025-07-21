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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();

            // Maximize only at runtime
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

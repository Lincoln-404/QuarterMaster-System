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
        private DateTime _currentDate = DateTime.Today;

        public Calendar()
        {
            InitializeComponent();

            // Maximize only at runtime
            this.WindowState = FormWindowState.Maximized;

            DisplayCurrentMonth();
        }

        private void DisplayCurrentMonth()
        {
            // Update the month/year label
            lblMonthYear.Text = _currentDate.ToString("MMMM yyyy");

            // Clear all label texts and reset color
            for (int Week = 1; Week <= 5; Week++)
            {
                for (int day = 0; day < 7; day++)
                {
                    char dayChar = (char)('A' + day); // A-G
                    string labelName = $"lblDay{Week}{dayChar}";
                    var label = tlpMonthPanel.Controls.Find(labelName, true).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = "";
                        label.ForeColor = SystemColors.ControlText;
                    }
                }
            }

            DateTime firstDay = new DateTime(_currentDate.Year, _currentDate.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month);

            // Calculate the column (0=Mon, 6=Sun) for the first day
            int startCol = ((int)firstDay.DayOfWeek + 6) % 7; // Adjust so Monday=0, Sunday=6

            // Previous month info
            DateTime prevMonth = _currentDate.AddMonths(-1);
            int daysInPrevMonth = DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);

            // Fill first week with previous month's days if needed
            int week = 1;
            for (int col = 0; col < startCol; col++)
            {
                char dayChar = (char)('A' + col);
                string labelName = $"lblDay{week}{dayChar}";
                var label = tlpMonthPanel.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    int prevMonthDay = daysInPrevMonth - (startCol - col - 1);
                    label.Text = prevMonthDay.ToString();
                    label.ForeColor = SystemColors.ControlDarkDark;
                }
            }

            // Fill current month days
            int curCol = startCol;
            week = 1;
            for (int day = 1; day <= daysInMonth; day++)
            {
                char dayChar = (char)('A' + curCol);
                string labelName = $"lblDay{week}{dayChar}";
                var label = tlpMonthPanel.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = day.ToString();
                    label.ForeColor = SystemColors.ControlText;
                }

                curCol++;
                if (curCol > 6)
                {
                    curCol = 0;
                    week++;
                }
            }

            // Fill last week with next month's days if needed
            if (curCol != 0 && week <= 5)
            {
                DateTime nextMonth = _currentDate.AddMonths(1);
                int nextMonthDay = 1;
                for (int col = curCol; col < 7; col++)
                {
                    char dayChar = (char)('A' + col);
                    string labelName = $"lblDay{week}{dayChar}";
                    var label = tlpMonthPanel.Controls.Find(labelName, true).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = nextMonthDay.ToString();
                        label.ForeColor = SystemColors.ControlDarkDark;
                        nextMonthDay++;
                    }
                }
            }
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(-1);
            DisplayCurrentMonth();
        }

        private void btnNextMonth_Click_1(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(1);
            DisplayCurrentMonth();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Calendar form and return to the previous form
        }
    }
}

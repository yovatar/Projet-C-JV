using Calendrier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendrier;

namespace Calendrier
{
    public partial class CalendarView : Form
    {

        CalendarController controller;

        int month, year;

        public CalendarView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays() {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            DateTime startofthemounth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d")) + 2;

            for (int i=1; i < daysoftheweek; i++){
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++) {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month++;
            DateTime startofthemounth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }
    }
}

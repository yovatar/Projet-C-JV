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

            DateTime startofthemounth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year,now.Month);
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d")) + 2;

            for (int i=1; i < daysoftheweek; i++){
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++) {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
            }








        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

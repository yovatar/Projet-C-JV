using Calendrier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class CalendarView : Form
    {

       

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

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDate.Text = monthname + " " + year;
            
            DateTime startofthemounth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d"));

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
            //ferme la fenetre pour revenir à l'acceuil
            this.Close();
        }

        //va permettre de passer au mois précédant
        private void BtnBack_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDate.Text = monthname + " " + year;
            DateTime startofthemounth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d"));

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

        //va permetre de passer au mois suivant 
        private void BtnNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDate.Text = monthname + " " + year;
            DateTime startofthemounth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d"));

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

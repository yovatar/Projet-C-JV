using Calendrier.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class Form1 : Form
    {
        public Form1()
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
            int daysoftheweek = Convert.ToInt32(startofthemounth.DayOfWeek.ToString("d")) + 1;

            for (int i=1; i < daysoftheweek; i++){
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);

            }
            for (int i = 1; i <= days; i++) {
                UserControlBlank ucdays = new UserControlDays();
                ucdays.days();
            }








        }

      
    }
}

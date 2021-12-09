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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            GameList window = new GameList();
            window.ShowDialog();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            CalendarView window = new CalendarView();
            window.ShowDialog();
        }
    }
}

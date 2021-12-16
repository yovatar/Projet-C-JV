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
        private CalendarController _controller;

        public Home()
        {
            InitializeComponent();
            _controller = new CalendarController();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            GameList window = new GameList();
            var games = _controller.GetGames();

            System.Diagnostics.Debug.WriteLine($"Les Games: {games}");

            // window.Games = games;

            window.ShowDialog();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            CalendarView window = new CalendarView();
            window.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }
    }
}

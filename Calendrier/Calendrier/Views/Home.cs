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
    public partial class frmHome : Form
    {
        private CalendarController _controller;

        public frmHome()
        {
            InitializeComponent();
            _controller = new CalendarController();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            // ouvre la liste des jeux 
            GameList window = new GameList();
            var games = _controller.GetGames();

            System.Diagnostics.Debug.WriteLine($"Les Games: {games}");

            // window.Games = games;

            window.ShowDialog();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            //affiche les events
            CalendarView window = new CalendarView();
            window.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            //empeche le redimensionnement 
        }
    }
}

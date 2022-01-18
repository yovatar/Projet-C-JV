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
    public partial class GameList : Form
    {
        public GameList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            
            CalendarController Controller = new CalendarController();
            List<Game> games = Controller.GetGames();
            foreach(Game game in games)
            {
                lstGameList.Items.Add(game.Name);
                lstGameList.Items.Add(game.ReleasGame);

                string editors = "";
                foreach (Editor editor in game.Editor)
                {
                    editors += editor.EditorName + " ";
                }
                lstGameList.Items.Add(editors);

                string devices = "";
                foreach (Device device in game.Device)
                {
                    devices += device.DeviceName + ", ";
                }
                lstGameList.Items.Add(devices);

                lstGameList.Items.Add("");
            }

            lstGameList.Left = Width / 2 - lstGameList.Width/2;
            lstGameList.Top = Height / 2 - lstGameList.Height/2;

        }

        private void lstGameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDevices_Click(object sender, EventArgs e)
        {

        }

        private void GameList_Resize(object sender, EventArgs e)
        {
            lstGameList.Left = Width / 2 - lstGameList.Width / 2;
            lstGameList.Top = Height / 2 - lstGameList.Height / 2;
        }
    }
}

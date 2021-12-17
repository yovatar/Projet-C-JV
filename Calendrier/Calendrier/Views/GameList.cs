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
                foreach(Editor editor in game.Editor)
                {
                    lstGameList.Items.Add(editor.EditorName);
                }
                foreach (Device device in game.Device)
                {
                    lstGameList.Items.Add(device.DeviceName);
                }
                lstGameList.Items.Add("\n");

            }


        }

        private void lstGameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDevices_Click(object sender, EventArgs e)
        {

        }
    }
}

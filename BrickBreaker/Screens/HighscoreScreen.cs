using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker.Screens
{
    public partial class HighscoreScreen : UserControl
    {
        SolidBrush hsBrush = new SolidBrush(Color.FromArgb(255, 0, 102));

        public HighscoreScreen()
        {
            InitializeComponent();
        }

        private void HighscoreScreen_Load(object sender, EventArgs e)
        {
            IList<GameSystemServices.Highscore> highscoreList = Form1.service.getHighscores();
            this.BackColor = Color.FromArgb(55, 63, 105);

            titleBox.Dock = DockStyle.Top;
            playerscoreLabel.Dock = DockStyle.Top;

        }

    }
}

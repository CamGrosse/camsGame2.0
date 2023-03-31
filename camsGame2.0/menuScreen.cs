using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camsGame2._0
{
    public partial class menuScreen : UserControl
    {
        SoundPlayer shotgun = new SoundPlayer(Properties.Resources.shotguns);
        public menuScreen()
        {
            InitializeComponent();
        }

        private void gameStartButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
            shotgun.Play();
        }

        private void gameExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

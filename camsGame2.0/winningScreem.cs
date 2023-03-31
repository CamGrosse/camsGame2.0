using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camsGame2._0
{
    public partial class winningScreem : UserControl
    {
        SoundPlayer happy = new SoundPlayer(Properties.Resources._5_Sec_Crowd_Cheer_Mike_Koenig_1562033255);
        public winningScreem()
        {
            InitializeComponent();
        }
        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            happy.Play();
            //TODO: show the length of the pattern
            imageBox.Image = Properties.Resources.happMan;

        }

      

        private void labeal_Click(object sender, EventArgs e)
        {

        }
    }
}

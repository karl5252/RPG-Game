using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace RPG_game
{
    public partial class Adventure : Form
    {
        private Player _player;

        public Adventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "Tis but yer home");
            

            _player = new Player(); //player class instantiation- object player
            //properties of object PLAYER
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 10;
            _player.ExperiencePoints = 0;
            _player.Level = 0;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.ExperiencePoints.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}

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
            Location test2 = new Location(2, "test", "test purpose",null,null, null);
            

            _player = new Player(10,10,10,0,0); //player class instantiation- object player
                                                //properties of object PLAYER

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

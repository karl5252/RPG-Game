using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_game
{
    public partial class Adventure : Form
    {
        public Adventure()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblGold.Text = "123";
            lblLevel.Text = "124";
            lblExperience.Text = "125";
            lblHitPoints.Text = "126";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyShootingGame
{
    public partial class Form1 : Form
    {
        MyLogicClass logic = new MyLogicClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MyShootingGame.Resource1.Load;
            SoundPlayer sp = new SoundPlayer(MyShootingGame.Resource1.LoadSound);
            sp.Play();
            Spin.Enabled = true;           
            logic.LoadingLogic();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MyShootingGame.Resource1.Spin;
            SoundPlayer sp = new SoundPlayer(MyShootingGame.Resource1.SpinSound);
            sp.Play();
            Spin.Enabled = true;
            logic.SpinningLogic();
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MyShootingGame.Resource1.Shoot;
            SoundPlayer sp = new SoundPlayer(MyShootingGame.Resource1.FireSound);
            sp.Play();
            Spin.Enabled = true;
            logic.ShootingLogic();
        }

        private void FireAway_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MyShootingGame.Resource1.ShootAway;
            SoundPlayer sp = new SoundPlayer(MyShootingGame.Resource1.FireSound);
            sp.Play();
            Spin.Enabled = true;
            logic.ShootingAway();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

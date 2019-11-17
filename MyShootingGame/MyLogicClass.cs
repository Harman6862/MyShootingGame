using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace MyShootingGame
{
    public class MyLogicClass
    {
        int MyBullet;
        int score = 0;

        public void LoadingLogic() 
        {
            MyBullet = 6;
        }

        public int SpinningLogic()
        {
            Random random = new Random();
            MyBullet = random.Next(1, 7); 
            return MyBullet;
        }

        int FireOnHead = 4; 
        int FireAwayAir = 2; 

        public int ShootingLogic()
        {
            if (MyBullet == 1)
            {
                
                MessageBox.Show("You Scored 0 points","Game Over!");
                Application.Exit();
            }
            else
            {
                FireOnHead--;
                MyBullet--;
                
                if (FireOnHead == 0 && FireAwayAir == 2)
                {
                    score = 100;
                    MessageBox.Show("You got " + score + " points", "Game Over!");
                    Application.Exit();
                }
                else if (FireOnHead == 0 && FireAwayAir == 1)
                {
                    score = 50;
                    MessageBox.Show("You got " + score + " points", "Game Over!");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            return FireOnHead;

        }

        public int ShootingAway()
        {
            if (MyBullet == 1 && FireAwayAir == 2)
            {
                
                score = 100;
                MessageBox.Show("Very good! You got " + score + " points");
                Application.Exit();

            }
            else if (MyBullet == 1 && FireAwayAir == 1)// one chance of each method remained
            {
                MessageBox.Show("You survive! You got " + score + " points");
                score = 5;
            }
            else
            {
                FireAwayAir--;
                MyBullet--;
                
                if (FireAwayAir == 0)// if there is no chance remain
                {
                    MessageBox.Show("No more Chances left, you scored " + score + " points do you want to play again?");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("One Last Try");
                }
            }

            return FireAwayAir;
        }

    }
}


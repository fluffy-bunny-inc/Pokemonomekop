using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MonsterBattle
{
    public partial class BattleForm : Form
    {
        Random randomGenerator;
        bool enemyDead;

        public BattleForm()
        {
            InitializeComponent();

            randomGenerator = new Random();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            
            if (!enemyDead)
            {
                enemyPictureBox.Tag = enemyPictureBox.Image;
                enemyPictureBox.Image = Properties.Resources.attack_lightning;
                
                attackButton.Enabled = false;
                attackTimer.Start();

                screenShakeTimer.Start();
            }
            else
            {
                MessageBox.Show("You can not strike Charizard whilst he is already down.");
            }
        }

        private void attackTimer_Tick(object sender, EventArgs e)
        {

            screenShakeTimer.Stop();
            attackTimer.Stop();
            attackButton.Enabled = true;

            enemyPictureBox.Image = (Image) enemyPictureBox.Tag;

            enemyHealthPictureBox.Width -= 20;
            Debug.WriteLine(enemyHealthPictureBox.Width);

            if (enemyHealthPictureBox.Width <= 0)
            {
                MessageBox.Show("Charizard has fainted!");
                enemyDead = true;
                enemyPictureBox.Image = null;
            }
        }

        private void screenShakeTimer_Tick(object sender, EventArgs e)
        {
            this.Top += randomGenerator.Next(-5, 6);
            this.Left += randomGenerator.Next(-5, 6);
        }

        private void BackButtonMethod()
        {
            MenuPannel.BringToFront();

            InventoryPannel.Hide();
            AttackMenuPannel.Hide();
        }

        private void invetoryBackButton_Click(object sender, EventArgs e)
        {
            BackButtonMethod();
        }

        private int OwnHp(int ownHp = 100)
        {
            if (ownHealthBar.Width != 90)
            {
                ownHp = enemyHealthPictureBox.Width - 10;
            }

            return ownHp;
        }

        private int EnemyHp(int enemyHp = 100)
        {
            if (enemyHealthPictureBox.Width != 90)
            {
                enemyHp = enemyHealthPictureBox.Width - 10;
            }

            return enemyHp;
        }

        private void hyperPotionButton_Click(object sender, EventArgs e)
        {

        }

        private void maxPotionButton_Click(object sender, EventArgs e)
        {

        }
    }
}

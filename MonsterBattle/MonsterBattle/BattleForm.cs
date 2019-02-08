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
        int attackDamage;
        int health;
        int enemyHealth;

        public BattleForm()
        {
            InitializeComponent();

            randomGenerator = new Random();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (!enemyDead)
            {
                Random random = new Random();
                int randomNumber = random.Next(15, 30);
                attackDamage = randomNumber;

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

            EnemyHealthBar();
            //enemyHealthPictureBox.Width -= attackDamage;

            if (enemyHealth <= 0)
            {
                MessageBox.Show("Charizard has fainted!");
                enemyDead = true;
                enemyPictureBox.Image = null;
            }
            attackDamage = 0;
        }

        private void screenShakeTimer_Tick(object sender, EventArgs e)
        {
            this.Top += randomGenerator.Next(-5, 6);
            this.Left += randomGenerator.Next(-5, 6);
        }

        private void attackOneButton_Click(object sender, EventArgs e)
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

        private void attackTwoButton_Click(object sender, EventArgs e)
        {

        }

        private void attackThreeButton_Click(object sender, EventArgs e)
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

        private void AttackMenubackButton_Click(object sender, EventArgs e)
        {
            //BackButtonMethod();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            health = 100;
            enemyHealth = 100;
        }

        private void EnemyHealthBar() {
            decimal sum = (enemyHealthPictureBox.Width / enemyHealth) * 100;
            enemyHealth = enemyHealth - attackDamage;
            enemyHealthPictureBox.Width -= enemyHealth; 
            Debug.WriteLine(enemyHealth + enemyHealthPictureBox.Width);
            //return EnemyHealthBar;
        }
    }
}

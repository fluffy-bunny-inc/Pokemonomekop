using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBattle
{
    public partial class AttackMenu : UserControl
    {
        public string[] attacks = new string[18] {
            "Lightning Strike","Bolder","Speed Attack",
            "Bulble gum","Flash","Light",
            "Circle","venon","hide and seek",
            "pee attack","go sleep","kontgat",
            "rapest","flying pigs","play minecraft",
            "go to nine gag","asshole","attack his mom"
        };

        public AttackMenu()
        {
            InitializeComponent();
        }

        private void AttackMenu_Load(object sender, EventArgs e)
        {
            if (pokemon == "Pikachu")
            {
                attackOneButton.Text = attacks[3].ToString();
                attackTwoButton.Text = attacks[10].ToString();
                attackThreeButton.Text = attacks[6].ToString();
            }
        }
    }
}

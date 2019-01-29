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
    public partial class PokemonSwitchMenu : UserControl
    {

        public string[] pokemons = new string[24] {
            "Bulbasaur","Charmander","Squirtle",
            "Pikachu","Eevee","Chikorita",
            "Cyndaquil","Totodile","Treeco",
            "Torchic","Mudkip","Turtwig",
            "Chimchar","Piplup","Snivy",
            "Tepig","Oshawott","Chespin",
            "Fennekin","Froakie","Rowlet",
            "Litten","Popplio","Arceus",

        };

        public PokemonSwitchMenu()
        {
            InitializeComponent();
        }
    }
}

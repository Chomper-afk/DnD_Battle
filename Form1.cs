using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DnD_Battle
{
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        int spell_selector = 0;

        Creature Test = new Creature("testanimal", new Spellcasting(), 4, 4, 4, 4, 4, 4, 5, 20, new Dice(0, 0, 0, 0, 2, 0, 0));

        private void Form1_Load(object sender, EventArgs e) {


            foreach (string file in Directory.GetFiles(Settings.Path)) {
                SpellLoader.LoadSpellsFromXml(file);
            }

            foreach (Spells s in Settings.SpellsWarlock) {
                output.Text += s.Name + ", spellslot = " + s.SpellSlot + ", times = " + s.Times + "\r\n";
            }

            enemy_name.Text = Test.Name;
            Player_Name.Text = Settings.User.Name;
            enemy_HP.Text = Test.HP_Check();
            Player_HP.Text = Settings.User.HP_Check();

        }

        private void roll_Click(object sender, EventArgs e) {
            Settings.SpellsWarlock[spell_selector].Attack(Settings.User, Test);

            enemy_HP.Text = Test.HP_Check();

            output.Text = Settings.Log;

            info(spell_selector);

            if (Test.CurrentHP == 0) {
                enemy_name.Text = "DEAD";
            }

        }

        private void complex_Click(object sender, EventArgs e) {
            if (Settings.isComplex) {
                Settings.isComplex = false;
            }
            else {
                Settings.isComplex = true;
            }
        }
        private void info(int temp_spell) {
            attack.Text = Settings.SpellsWarlock[temp_spell].ToString();
            if (!roll.Enabled) {
                roll.Enabled = true;
            }
            spell_selected.Text = Settings.User.SpellSlots.SpellSlots[Settings.SpellsWarlock[temp_spell].SpellSlot] + " Spell slots";
        }

        private void spell1_Click(object sender, EventArgs e) {
            spell_selected.Text = "Spell 1";
            spell_selector = 0;
            info(0);
        }
        private void spell2_Click(object sender, EventArgs e) {
            spell_selected.Text = "Spell 2";
            spell_selector = 1;
            info(1);

        }

        private void spell3_Click(object sender, EventArgs e) {
            spell_selected.Text = "Spell 3";
            spell_selector = 2;
            info(2);

        }

        private void spell4_Click(object sender, EventArgs e) {
            spell_selected.Text = "Spell 4";
            spell_selector = 3;
            info(3);

        }

        private void Next_Turn_Click(object sender, EventArgs e) {
            if ((Test.DEX_Modifier + Dice.Rolling(20, 1)) > Settings.User.AC) {
                int temp;
                temp = Test.Melee_attack.Roll(Settings.isComplex);
                Settings.User.Attack(temp);
                Settings.Log += "\r\n" + Test.Name + "attacks " + Settings.User.Name + " for " + temp + " dmg";
            }
            else {
                Settings.Log += "\r\n" + Test.Name + " misses " + Settings.User.Name;
            }
            Player_HP.Text = Settings.User.HP_Check();
            output.Text = Settings.Log;
            Settings.Actions = 1;
            Settings.B_Actions = 1;
        }

        private void ReSize(object sender, EventArgs e) {
            roll.Width = (int)((212.0/ 1516)*this.Width);
            roll.Height = (int)((88.0/652)* this.Height);
            roll.Location = new Point((int)((13.0 / 1516) * this.Width), (int)((264.0 / 652) * this.Height));
        }
    }
}

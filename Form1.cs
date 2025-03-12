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
using DnD_Battle.Spell_Stuff;
using DnD_Battle.Creatures;

namespace DnD_Battle {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        int spell_selector = 0;

        Creature Test = new Creature("testanimal", new Spellcasting(), 4, 4, 4, 4, 4, 4, 5, 20, 20, new Dice(0, 0, 0, 0, 2, 0, 0));

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
            if ((Test.DEX.Modifier + Dice.Rolling(20, 1)) > Settings.User.AC) {
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

        public void ReSize(int _width, int _height) {
            this.Width = _width;
            this.Height = _height;

            // Calculate scale ratios based on original form size
            float scaleX = this.Width / 1516f;  // Original width = 1516
            float scaleY = this.Height / 652f; // Original height = 652

            // Resize and reposition each control
            roll.Width = (int)(212 * scaleX);
            roll.Height = (int)(88 * scaleY);
            roll.Location = new Point((int)(13 * scaleX), (int)(264 * scaleY));

            output.Width = (int)(601 * scaleX);
            output.Height = (int)(398 * scaleY);
            output.Location = new Point((int)(508 * scaleX), (int)(100 * scaleY));

            complex.Width = (int)(76 * scaleX);
            complex.Height = (int)(84 * scaleY);
            complex.Location = new Point((int)(1243 * scaleX), (int)(554 * scaleY));

            attack.Width = (int)(487 * scaleX);
            attack.Height = (int)(278 * scaleY);
            attack.Location = new Point((int)(13 * scaleX), (int)(359 * scaleY));

            spell1.Width = (int)(59 * scaleX);
            spell1.Height = (int)(66 * scaleY);
            spell1.Location = new Point((int)(508 * scaleX), (int)(506 * scaleY));

            spell2.Width = (int)(59 * scaleX);
            spell2.Height = (int)(66 * scaleY);
            spell2.Location = new Point((int)(573 * scaleX), (int)(506 * scaleY));

            spell3.Width = (int)(59 * scaleX);
            spell3.Height = (int)(66 * scaleY);
            spell3.Location = new Point((int)(639 * scaleX), (int)(506 * scaleY));

            spell4.Width = (int)(59 * scaleX);
            spell4.Height = (int)(66 * scaleY);
            spell4.Location = new Point((int)(704 * scaleX), (int)(506 * scaleY));

            spell_selected.Width = (int)(67 * scaleX);
            spell_selected.Height = (int)(73 * scaleY);
            spell_selected.Location = new Point((int)(344 * scaleX), (int)(278 * scaleY));

            enemy_name.Width = (int)(220 * scaleX);
            enemy_name.Height = (int)(53 * scaleY);
            enemy_name.Location = new Point((int)(1132 * scaleX), (int)(55 * scaleY));

            enemy_HP.Width = (int)(95 * scaleX);
            enemy_HP.Height = (int)(53 * scaleY);
            enemy_HP.Location = new Point((int)(1384 * scaleX), (int)(55 * scaleY));

            Next_Turn.Width = (int)(177 * scaleX);
            Next_Turn.Height = (int)(84 * scaleY);
            Next_Turn.Location = new Point((int)(1326 * scaleX), (int)(554 * scaleY));

            Player_Name.Width = (int)(166 * scaleX);
            Player_Name.Height = (int)(53 * scaleY);
            Player_Name.Location = new Point((int)(13 * scaleX), (int)(55 * scaleY));

            Player_HP.Width = (int)(95 * scaleX);
            Player_HP.Height = (int)(53 * scaleY);
            Player_HP.Location = new Point((int)(187 * scaleX), (int)(55 * scaleY));

            Player_Info.Width = (int)(112 * scaleX);
            Player_Info.Height = (int)(34 * scaleY);
            Player_Info.Location = new Point((int)(52 * scaleX), (int)(152 * scaleY));

            Enemy_Info.Width = (int)(115 * scaleX);
            Enemy_Info.Height = (int)(39 * scaleY);
            Enemy_Info.Location = new Point((int)(1227 * scaleX), (int)(180 * scaleY));
        }

        private void Player_Info_Click(object sender, EventArgs e) {
            Info Information = new Info(Settings.User);
            Information.Show();
        }

        private void Enemy_Info_Click(object sender, EventArgs e) {
            Info Information = new Info(Test);
            Information.Show();

        }
    }
}

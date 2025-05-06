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
using DnD_Battle.Loaders;

namespace DnD_Battle {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            }

        Creature Test = new Creature("testanimal", new Spellcasting(), 4, 4, 4, 4, 4, 4, 5, 20, 20, new Dice(0, 0, 0, 0, 2, 0, 0));

        private void Form1_Load(object sender, EventArgs e) {

            ReSize(Width, Height);

            foreach(Spells S in Settings.User.Known_Spells) {
                LB_Spells.Items.Add(S);
                }

            enemy_name.Text = Test.Name;
            Player_Name.Text = Settings.User.Name;
            enemy_HP.Text = Test.HP_Check();
            Player_HP.Text = Settings.User.HP_Check();
            SS_Data_Refresh();

            }

        private void SS_Data_Refresh() {
            int i = 0;
            LB_SpellSlots.Items.Clear();
            foreach(int I in Settings.User.SpellSlots.SpellSlots) {
                if(i != 0) {
                    LB_SpellSlots.Items.Add(i + "|" + I);
                }
                i++;
            }
        }


        private void roll_Click(object sender, EventArgs e) {
            Spells temp = LB_Spells.SelectedItem as Spells;
            
            temp.Attack(Settings.User, Test);

            enemy_HP.Text = Test.HP_Check();

            output.Text = Settings.Log;

            SS_Data_Refresh();

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

            LB_Items.Width = (int)(487 * scaleX);
            LB_Items.Height = (int)(278 * scaleY);
            LB_Items.Location = new Point((int)(13 * scaleX), (int)(359 * scaleY));

            LB_Spells.Width = (int)(290 * scaleX);
            LB_Spells.Height = (int)(120 * scaleY);
            LB_Spells.Location = new Point((int)(510 * scaleX), (int)(520 * scaleY));

            LB_SS.Width = (int)(68 * scaleX);
            LB_SS.Height = (int)(79 * scaleY);
            LB_SS.Location = new Point((int)(432 * scaleX), (int)(271 * scaleY));

            LB_SpellSlots.Width = (int)(120 * scaleX);
            LB_SpellSlots.Height = (int)(200 * scaleY);
            LB_SpellSlots.Location = new Point((int)(280 * scaleX), (int)(150 * scaleY));
            
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

        private void LB_Spells_SelectedIndexChanged(object sender, EventArgs e) {
            Spells? temp;
            if (LB_Spells.SelectedItem != null) {
                roll.Enabled = true;
                temp = (Spells)LB_Spells.SelectedItem;
                }
            else {
                roll.Enabled = false;
                temp = null;
                }

            LB_SS.Items.Clear();
            if (temp != null) {
                if (temp.SpellSlot == 0) {
                    LB_SS.Items.Add(0);
                }
                else {
                    for (int i = temp.SpellSlot; i <= 10; i++) {
                        LB_SS.Items.Add(i.ToString());
                    }
                }
            LB_SS.SelectedIndex = 0;
            }

        }


    }
}

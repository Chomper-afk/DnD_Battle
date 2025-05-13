using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Battle.Creatures {
    public partial class Info : Form {
        private ACreature Subject;
        public Info(ACreature _subject) {
            InitializeComponent();
            Subject = _subject;
        }

        private void Info_Load(object sender, EventArgs e) {
            Data_Refresh();
            if (Subject == null) throw new Exception("Something seriusly went wrong");
        }

        private void Data_Refresh() {
            TB_Name.Text = Subject.Name + "\r\n" + Subject.HP_Check();
            LB_Stats_Write();
            LB_Effects_Write();
        }
        private void LB_Stats_Write() {
            LB_Stats.Items.Clear(); // Clear previous entries.

            var stats = new Dictionary<string, int>
            {
                { "STR", Subject.STR.Base },
                { "DEX", Subject.DEX.Base },
                { "CON", Subject.CON.Base },
                { "INT", Subject.INT.Base },
                { "WIS", Subject.WIS.Base },
                { "CHA", Subject.CHA.Base }
            };

            foreach (var stat in stats) {
                string formattedText = $"{stat.Key,-10} | {stat.Value,5}"; // Align columns
                LB_Stats.Items.Add(formattedText);
            }
        }
        private void LB_Effects_Write() {
            LB_Effects.Items.Clear();
            if (Subject.Effects != null) {
                foreach (Effect E in Subject.Effects) {
                    LB_Effects.Items.Add(E.Name);
                }
            }
        }

        private void LB_Effects_SelectedIndexChanged(object sender, EventArgs e) {
            if (LB_Effects.SelectedIndex != -1) {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                TB_Effect_Info.Text = Subject.Effects[LB_Effects.SelectedIndex].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }


    }
}

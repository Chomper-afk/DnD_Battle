using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Battle {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        Form1 form = new Form1() { TopLevel = false };

        private void MainForm_Load(object sender, EventArgs e) {
            Settings.Initialize();
            MainPanel.Controls.Add(form);
            form.ReSize(MainPanel.Width, MainPanel.Height);
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object? sender, FormClosedEventArgs e) {
            if (form.ExitCode == 0) {
                MessageBox.Show("you win");
                this.Close();
            }
            else if (form.ExitCode == 1) {
                MessageBox.Show("you lose");
                this.Close();
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            form.ReSize(MainPanel.Width, MainPanel.Height);

        }
    }
}

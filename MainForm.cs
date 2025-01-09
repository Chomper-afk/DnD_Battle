using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            MainPanel.Controls.Add(form);
            form.ReSize(MainPanel.Width, MainPanel.Height);
            form.Show();
            Console.WriteLine("");
        }


        private void MainForm_SizeChanged(object sender, EventArgs e) {
            form.ReSize(MainPanel.Width, MainPanel.Height);

        }
    }
}

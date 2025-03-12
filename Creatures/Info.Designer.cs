namespace DnD_Battle.Creatures {
    partial class Info {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TB_Name = new TextBox();
            LB_Stats = new ListBox();
            LB_Effects = new ListBox();
            TB_Effect_Info = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(12, 12);
            TB_Name.Multiline = true;
            TB_Name.Name = "TB_Name";
            TB_Name.ReadOnly = true;
            TB_Name.Size = new Size(509, 134);
            TB_Name.TabIndex = 0;
            // 
            // LB_Stats
            // 
            LB_Stats.FormattingEnabled = true;
            LB_Stats.ItemHeight = 25;
            LB_Stats.Location = new Point(12, 152);
            LB_Stats.MultiColumn = true;
            LB_Stats.Name = "LB_Stats";
            LB_Stats.Size = new Size(295, 154);
            LB_Stats.TabIndex = 1;
            // 
            // LB_Effects
            // 
            LB_Effects.FormattingEnabled = true;
            LB_Effects.ItemHeight = 25;
            LB_Effects.Location = new Point(19, 369);
            LB_Effects.MultiColumn = true;
            LB_Effects.Name = "LB_Effects";
            LB_Effects.Size = new Size(496, 204);
            LB_Effects.TabIndex = 2;
            LB_Effects.SelectedIndexChanged += LB_Effects_SelectedIndexChanged;
            // 
            // TB_Effect_Info
            // 
            TB_Effect_Info.ForeColor = Color.Black;
            TB_Effect_Info.Location = new Point(20, 596);
            TB_Effect_Info.Multiline = true;
            TB_Effect_Info.Name = "TB_Effect_Info";
            TB_Effect_Info.ReadOnly = true;
            TB_Effect_Info.Size = new Size(488, 369);
            TB_Effect_Info.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(373, 152);
            button1.Name = "button1";
            button1.Size = new Size(135, 106);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(373, 288);
            button2.Name = "button2";
            button2.Size = new Size(135, 75);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 995);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TB_Effect_Info);
            Controls.Add(LB_Effects);
            Controls.Add(LB_Stats);
            Controls.Add(TB_Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Info";
            Text = "Info";
            Load += Info_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Name;
        private ListBox LB_Stats;
        private ListBox LB_Effects;
        private TextBox TB_Effect_Info;
        private Button button1;
        private Button button2;
    }
}
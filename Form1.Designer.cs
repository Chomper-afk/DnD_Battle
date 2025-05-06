namespace DnD_Battle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            roll = new Button();
            output = new TextBox();
            complex = new Button();
            enemy_name = new TextBox();
            enemy_HP = new TextBox();
            Next_Turn = new Button();
            Player_Name = new TextBox();
            Player_HP = new TextBox();
            Player_Info = new Button();
            Enemy_Info = new Button();
            LB_SS = new ListBox();
            LB_SpellSlots = new ListBox();
            LB_Spells = new ListBox();
            LB_Items = new ListBox();
            SuspendLayout();
            // 
            // roll
            // 
            roll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            roll.Enabled = false;
            roll.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roll.Location = new Point(13, 263);
            roll.Name = "roll";
            roll.Size = new Size(215, 96);
            roll.TabIndex = 0;
            roll.Text = "attack";
            roll.UseVisualStyleBackColor = true;
            roll.Click += roll_Click;
            // 
            // output
            // 
            output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            output.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            output.Location = new Point(509, 100);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(605, 405);
            output.TabIndex = 1;
            // 
            // complex
            // 
            complex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            complex.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 238);
            complex.Location = new Point(1243, 553);
            complex.Name = "complex";
            complex.Size = new Size(80, 91);
            complex.TabIndex = 2;
            complex.Text = "toggle complex counting";
            complex.UseVisualStyleBackColor = true;
            complex.Click += complex_Click;
            // 
            // enemy_name
            // 
            enemy_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enemy_name.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemy_name.Location = new Point(1131, 55);
            enemy_name.Name = "enemy_name";
            enemy_name.Size = new Size(224, 53);
            enemy_name.TabIndex = 9;
            // 
            // enemy_HP
            // 
            enemy_HP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enemy_HP.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemy_HP.Location = new Point(1384, 55);
            enemy_HP.Name = "enemy_HP";
            enemy_HP.Size = new Size(99, 53);
            enemy_HP.TabIndex = 10;
            // 
            // Next_Turn
            // 
            Next_Turn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Next_Turn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Next_Turn.Location = new Point(1326, 553);
            Next_Turn.Name = "Next_Turn";
            Next_Turn.Size = new Size(181, 91);
            Next_Turn.TabIndex = 11;
            Next_Turn.Text = "Next Turn";
            Next_Turn.UseVisualStyleBackColor = true;
            Next_Turn.Click += Next_Turn_Click;
            // 
            // Player_Name
            // 
            Player_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Player_Name.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Player_Name.Location = new Point(13, 55);
            Player_Name.Name = "Player_Name";
            Player_Name.Size = new Size(169, 53);
            Player_Name.TabIndex = 12;
            // 
            // Player_HP
            // 
            Player_HP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Player_HP.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Player_HP.Location = new Point(187, 55);
            Player_HP.Name = "Player_HP";
            Player_HP.Size = new Size(99, 53);
            Player_HP.TabIndex = 13;
            // 
            // Player_Info
            // 
            Player_Info.Location = new Point(51, 152);
            Player_Info.Name = "Player_Info";
            Player_Info.Size = new Size(111, 33);
            Player_Info.TabIndex = 14;
            Player_Info.Text = "Player info";
            Player_Info.UseVisualStyleBackColor = true;
            Player_Info.Click += Player_Info_Click;
            // 
            // Enemy_Info
            // 
            Enemy_Info.Location = new Point(1227, 180);
            Enemy_Info.Name = "Enemy_Info";
            Enemy_Info.Size = new Size(114, 38);
            Enemy_Info.TabIndex = 15;
            Enemy_Info.Text = "Enemy Info";
            Enemy_Info.UseVisualStyleBackColor = true;
            Enemy_Info.Click += Enemy_Info_Click;
            // 
            // LB_SS
            // 
            LB_SS.FormattingEnabled = true;
            LB_SS.IntegralHeight = false;
            LB_SS.ItemHeight = 25;
            LB_SS.Location = new Point(432, 271);
            LB_SS.Name = "LB_SS";
            LB_SS.Size = new Size(68, 79);
            LB_SS.TabIndex = 18;
            // 
            // LB_SpellSlots
            // 
            LB_SpellSlots.FormattingEnabled = true;
            LB_SpellSlots.IntegralHeight = false;
            LB_SpellSlots.ItemHeight = 25;
            LB_SpellSlots.Location = new Point(280, 150);
            LB_SpellSlots.Name = "LB_SpellSlots";
            LB_SpellSlots.Size = new Size(120, 200);
            LB_SpellSlots.TabIndex = 19;
            // 
            // LB_Spells
            // 
            LB_Spells.FormattingEnabled = true;
            LB_Spells.IntegralHeight = false;
            LB_Spells.ItemHeight = 25;
            LB_Spells.Location = new Point(510, 520);
            LB_Spells.Name = "LB_Spells";
            LB_Spells.Size = new Size(290, 120);
            LB_Spells.TabIndex = 20;
            LB_Spells.SelectedIndexChanged += LB_Spells_SelectedIndexChanged;
            // 
            // LB_Items
            // 
            LB_Items.FormattingEnabled = true;
            LB_Items.ItemHeight = 25;
            LB_Items.Location = new Point(13, 365);
            LB_Items.Name = "LB_Items";
            LB_Items.Size = new Size(491, 279);
            LB_Items.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1520, 660);
            Controls.Add(LB_Items);
            Controls.Add(LB_Spells);
            Controls.Add(LB_SpellSlots);
            Controls.Add(LB_SS);
            Controls.Add(Enemy_Info);
            Controls.Add(Player_Info);
            Controls.Add(Player_HP);
            Controls.Add(Player_Name);
            Controls.Add(Next_Turn);
            Controls.Add(enemy_HP);
            Controls.Add(enemy_name);
            Controls.Add(complex);
            Controls.Add(output);
            Controls.Add(roll);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button complex;
        private System.Windows.Forms.TextBox enemy_name;
        private System.Windows.Forms.TextBox enemy_HP;
        private System.Windows.Forms.Button Next_Turn;
        private System.Windows.Forms.TextBox Player_Name;
        private System.Windows.Forms.TextBox Player_HP;
        private Button Player_Info;
        private Button Enemy_Info;
        private ListBox LB_SS;
        private ListBox LB_SpellSlots;
        private ListBox LB_Spells;
        private ListBox LB_Items;
    }
}


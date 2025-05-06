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
            attack = new TextBox();
            spell_selected = new TextBox();
            enemy_name = new TextBox();
            enemy_HP = new TextBox();
            Next_Turn = new Button();
            Player_Name = new TextBox();
            Player_HP = new TextBox();
            Player_Info = new Button();
            Enemy_Info = new Button();
            CB_Spells = new ComboBox();
            CB_SS = new ComboBox();
            SuspendLayout();
            // 
            // roll
            // 
            roll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            roll.Enabled = false;
            roll.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roll.Location = new Point(9, 158);
            roll.Margin = new Padding(2);
            roll.Name = "roll";
            roll.Size = new Size(148, 53);
            roll.TabIndex = 0;
            roll.Text = "attack";
            roll.UseVisualStyleBackColor = true;
            roll.Click += roll_Click;
            // 
            // output
            // 
            output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            output.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            output.Location = new Point(356, 60);
            output.Margin = new Padding(2);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(422, 240);
            output.TabIndex = 1;
            // 
            // complex
            // 
            complex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            complex.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 238);
            complex.Location = new Point(870, 332);
            complex.Margin = new Padding(2);
            complex.Name = "complex";
            complex.Size = new Size(53, 50);
            complex.TabIndex = 2;
            complex.Text = "toggle complex counting";
            complex.UseVisualStyleBackColor = true;
            complex.Click += complex_Click;
            // 
            // attack
            // 
            attack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            attack.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            attack.Location = new Point(9, 215);
            attack.Margin = new Padding(2);
            attack.Multiline = true;
            attack.Name = "attack";
            attack.ReadOnly = true;
            attack.Size = new Size(342, 168);
            attack.TabIndex = 3;
            // 
            // spell_selected
            // 
            spell_selected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spell_selected.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            spell_selected.Location = new Point(241, 167);
            spell_selected.Margin = new Padding(2);
            spell_selected.Multiline = true;
            spell_selected.Name = "spell_selected";
            spell_selected.Size = new Size(48, 45);
            spell_selected.TabIndex = 8;
            // 
            // enemy_name
            // 
            enemy_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enemy_name.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemy_name.Location = new Point(792, 33);
            enemy_name.Margin = new Padding(2);
            enemy_name.Name = "enemy_name";
            enemy_name.Size = new Size(155, 38);
            enemy_name.TabIndex = 9;
            // 
            // enemy_HP
            // 
            enemy_HP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enemy_HP.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemy_HP.Location = new Point(969, 33);
            enemy_HP.Margin = new Padding(2);
            enemy_HP.Name = "enemy_HP";
            enemy_HP.Size = new Size(68, 38);
            enemy_HP.TabIndex = 10;
            // 
            // Next_Turn
            // 
            Next_Turn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Next_Turn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Next_Turn.Location = new Point(928, 332);
            Next_Turn.Margin = new Padding(2);
            Next_Turn.Name = "Next_Turn";
            Next_Turn.Size = new Size(124, 50);
            Next_Turn.TabIndex = 11;
            Next_Turn.Text = "Next Turn";
            Next_Turn.UseVisualStyleBackColor = true;
            Next_Turn.Click += Next_Turn_Click;
            // 
            // Player_Name
            // 
            Player_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Player_Name.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Player_Name.Location = new Point(9, 33);
            Player_Name.Margin = new Padding(2);
            Player_Name.Name = "Player_Name";
            Player_Name.Size = new Size(117, 38);
            Player_Name.TabIndex = 12;
            // 
            // Player_HP
            // 
            Player_HP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Player_HP.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Player_HP.Location = new Point(131, 33);
            Player_HP.Margin = new Padding(2);
            Player_HP.Name = "Player_HP";
            Player_HP.Size = new Size(68, 38);
            Player_HP.TabIndex = 13;
            // 
            // Player_Info
            // 
            Player_Info.Location = new Point(36, 91);
            Player_Info.Margin = new Padding(2);
            Player_Info.Name = "Player_Info";
            Player_Info.Size = new Size(78, 20);
            Player_Info.TabIndex = 14;
            Player_Info.Text = "Player info";
            Player_Info.UseVisualStyleBackColor = true;
            Player_Info.Click += Player_Info_Click;
            // 
            // Enemy_Info
            // 
            Enemy_Info.Location = new Point(859, 108);
            Enemy_Info.Margin = new Padding(2);
            Enemy_Info.Name = "Enemy_Info";
            Enemy_Info.Size = new Size(80, 23);
            Enemy_Info.TabIndex = 15;
            Enemy_Info.Text = "Enemy Info";
            Enemy_Info.UseVisualStyleBackColor = true;
            Enemy_Info.Click += Enemy_Info_Click;
            // 
            // CB_Spells
            // 
            CB_Spells.FormattingEnabled = true;
            CB_Spells.Location = new Point(373, 317);
            CB_Spells.Name = "CB_Spells";
            CB_Spells.Size = new Size(154, 23);
            CB_Spells.TabIndex = 16;
            CB_Spells.SelectedIndexChanged += CB_Spells_SelectedIndexChanged;
            // 
            // CB_SS
            // 
            CB_SS.Font = new Font("Segoe UI", 18F);
            CB_SS.FormattingEnabled = true;
            CB_SS.ItemHeight = 32;
            CB_SS.Location = new Point(310, 167);
            CB_SS.Name = "CB_SS";
            CB_SS.Size = new Size(41, 40);
            CB_SS.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1061, 391);
            Controls.Add(CB_SS);
            Controls.Add(CB_Spells);
            Controls.Add(Enemy_Info);
            Controls.Add(Player_Info);
            Controls.Add(Player_HP);
            Controls.Add(Player_Name);
            Controls.Add(Next_Turn);
            Controls.Add(enemy_HP);
            Controls.Add(enemy_name);
            Controls.Add(spell_selected);
            Controls.Add(attack);
            Controls.Add(complex);
            Controls.Add(output);
            Controls.Add(roll);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private System.Windows.Forms.TextBox attack;
        private System.Windows.Forms.TextBox spell_selected;
        private System.Windows.Forms.TextBox enemy_name;
        private System.Windows.Forms.TextBox enemy_HP;
        private System.Windows.Forms.Button Next_Turn;
        private System.Windows.Forms.TextBox Player_Name;
        private System.Windows.Forms.TextBox Player_HP;
        private Button Player_Info;
        private Button Enemy_Info;
        private ComboBox CB_Spells;
        private ComboBox CB_SS;
        }
}


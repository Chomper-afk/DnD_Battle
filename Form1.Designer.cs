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
            spell1 = new Button();
            spell2 = new Button();
            spell3 = new Button();
            spell4 = new Button();
            spell_selected = new TextBox();
            enemy_name = new TextBox();
            enemy_HP = new TextBox();
            Next_Turn = new Button();
            Player_Name = new TextBox();
            Player_HP = new TextBox();
            SuspendLayout();
            // 
            // roll
            // 
            roll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roll.Enabled = false;
            roll.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roll.Location = new Point(13, 264);
            roll.Margin = new Padding(3, 4, 3, 4);
            roll.Name = "roll";
            roll.Size = new Size(212, 88);
            roll.TabIndex = 0;
            roll.Text = "attack";
            roll.UseVisualStyleBackColor = true;
            roll.Click += roll_Click;
            // 
            // output
            // 
            output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            output.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            output.Location = new Point(508, 100);
            output.Margin = new Padding(3, 4, 3, 4);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = ScrollBars.Vertical;
            output.Size = new Size(601, 398);
            output.TabIndex = 1;
            // 
            // complex
            // 
            complex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            complex.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 238);
            complex.Location = new Point(1243, 554);
            complex.Margin = new Padding(3, 4, 3, 4);
            complex.Name = "complex";
            complex.Size = new Size(76, 84);
            complex.TabIndex = 2;
            complex.Text = "toggle complex counting";
            complex.UseVisualStyleBackColor = true;
            complex.Click += complex_Click;
            // 
            // attack
            // 
            attack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            attack.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            attack.Location = new Point(13, 359);
            attack.Margin = new Padding(3, 4, 3, 4);
            attack.Multiline = true;
            attack.Name = "attack";
            attack.ReadOnly = true;
            attack.Size = new Size(487, 278);
            attack.TabIndex = 3;
            // 
            // spell1
            // 
            spell1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spell1.Location = new Point(508, 506);
            spell1.Margin = new Padding(3, 4, 3, 4);
            spell1.Name = "spell1";
            spell1.Size = new Size(59, 66);
            spell1.TabIndex = 4;
            spell1.Text = "1";
            spell1.UseVisualStyleBackColor = true;
            spell1.Click += spell1_Click;
            // 
            // spell2
            // 
            spell2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spell2.Location = new Point(573, 506);
            spell2.Margin = new Padding(3, 4, 3, 4);
            spell2.Name = "spell2";
            spell2.Size = new Size(59, 66);
            spell2.TabIndex = 5;
            spell2.Text = "2";
            spell2.UseVisualStyleBackColor = true;
            spell2.Click += spell2_Click;
            // 
            // spell3
            // 
            spell3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spell3.Location = new Point(639, 506);
            spell3.Margin = new Padding(3, 4, 3, 4);
            spell3.Name = "spell3";
            spell3.Size = new Size(59, 66);
            spell3.TabIndex = 6;
            spell3.Text = "3";
            spell3.UseVisualStyleBackColor = true;
            spell3.Click += spell3_Click;
            // 
            // spell4
            // 
            spell4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spell4.Location = new Point(704, 506);
            spell4.Margin = new Padding(3, 4, 3, 4);
            spell4.Name = "spell4";
            spell4.Size = new Size(59, 66);
            spell4.TabIndex = 7;
            spell4.Text = "4";
            spell4.UseVisualStyleBackColor = true;
            spell4.Click += spell4_Click;
            // 
            // spell_selected
            // 
            spell_selected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spell_selected.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            spell_selected.Location = new Point(344, 278);
            spell_selected.Margin = new Padding(3, 4, 3, 4);
            spell_selected.Multiline = true;
            spell_selected.Name = "spell_selected";
            spell_selected.Size = new Size(67, 73);
            spell_selected.TabIndex = 8;
            // 
            // enemy_name
            // 
            enemy_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enemy_name.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemy_name.Location = new Point(1132, 55);
            enemy_name.Margin = new Padding(3, 4, 3, 4);
            enemy_name.Name = "enemy_name";
            enemy_name.Size = new Size(220, 53);
            enemy_name.TabIndex = 9;
            // 
            // enemy_HP
            // 
            enemy_HP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enemy_HP.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            enemy_HP.Location = new Point(1384, 55);
            enemy_HP.Margin = new Padding(3, 4, 3, 4);
            enemy_HP.Name = "enemy_HP";
            enemy_HP.Size = new Size(95, 53);
            enemy_HP.TabIndex = 10;
            // 
            // Next_Turn
            // 
            Next_Turn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Next_Turn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Next_Turn.Location = new Point(1326, 554);
            Next_Turn.Margin = new Padding(3, 4, 3, 4);
            Next_Turn.Name = "Next_Turn";
            Next_Turn.Size = new Size(177, 84);
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
            Player_Name.Margin = new Padding(3, 4, 3, 4);
            Player_Name.Name = "Player_Name";
            Player_Name.Size = new Size(166, 53);
            Player_Name.TabIndex = 12;
            // 
            // Player_HP
            // 
            Player_HP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Player_HP.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Player_HP.Location = new Point(187, 55);
            Player_HP.Margin = new Padding(3, 4, 3, 4);
            Player_HP.Name = "Player_HP";
            Player_HP.Size = new Size(95, 53);
            Player_HP.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 652);
            Controls.Add(Player_HP);
            Controls.Add(Player_Name);
            Controls.Add(Next_Turn);
            Controls.Add(enemy_HP);
            Controls.Add(enemy_name);
            Controls.Add(spell_selected);
            Controls.Add(spell4);
            Controls.Add(spell3);
            Controls.Add(spell2);
            Controls.Add(spell1);
            Controls.Add(attack);
            Controls.Add(complex);
            Controls.Add(output);
            Controls.Add(roll);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button spell1;
        private System.Windows.Forms.Button spell2;
        private System.Windows.Forms.Button spell3;
        private System.Windows.Forms.Button spell4;
        private System.Windows.Forms.TextBox spell_selected;
        private System.Windows.Forms.TextBox enemy_name;
        private System.Windows.Forms.TextBox enemy_HP;
        private System.Windows.Forms.Button Next_Turn;
        private System.Windows.Forms.TextBox Player_Name;
        private System.Windows.Forms.TextBox Player_HP;
    }
}


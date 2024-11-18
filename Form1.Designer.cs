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
        private void InitializeComponent()
        {
            this.roll = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.complex = new System.Windows.Forms.Button();
            this.attack = new System.Windows.Forms.TextBox();
            this.spell1 = new System.Windows.Forms.Button();
            this.spell2 = new System.Windows.Forms.Button();
            this.spell3 = new System.Windows.Forms.Button();
            this.spell4 = new System.Windows.Forms.Button();
            this.spell_selected = new System.Windows.Forms.TextBox();
            this.enemy_name = new System.Windows.Forms.TextBox();
            this.enemy_HP = new System.Windows.Forms.TextBox();
            this.Next_Turn = new System.Windows.Forms.Button();
            this.Player_Name = new System.Windows.Forms.TextBox();
            this.Player_HP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // roll
            // 
            this.roll.Enabled = false;
            this.roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roll.Location = new System.Drawing.Point(12, 211);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(191, 70);
            this.roll.TabIndex = 0;
            this.roll.Text = "attack";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output.Location = new System.Drawing.Point(457, 80);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(541, 319);
            this.output.TabIndex = 1;
            // 
            // complex
            // 
            this.complex.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.complex.Location = new System.Drawing.Point(1119, 443);
            this.complex.Name = "complex";
            this.complex.Size = new System.Drawing.Size(68, 67);
            this.complex.TabIndex = 2;
            this.complex.Text = "toggle complex counting";
            this.complex.UseVisualStyleBackColor = true;
            this.complex.Click += new System.EventHandler(this.complex_Click);
            // 
            // attack
            // 
            this.attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attack.Location = new System.Drawing.Point(12, 287);
            this.attack.Multiline = true;
            this.attack.Name = "attack";
            this.attack.ReadOnly = true;
            this.attack.Size = new System.Drawing.Size(439, 223);
            this.attack.TabIndex = 3;
            // 
            // spell1
            // 
            this.spell1.Location = new System.Drawing.Point(457, 405);
            this.spell1.Name = "spell1";
            this.spell1.Size = new System.Drawing.Size(53, 53);
            this.spell1.TabIndex = 4;
            this.spell1.Text = "1";
            this.spell1.UseVisualStyleBackColor = true;
            this.spell1.Click += new System.EventHandler(this.spell1_Click);
            // 
            // spell2
            // 
            this.spell2.Location = new System.Drawing.Point(516, 405);
            this.spell2.Name = "spell2";
            this.spell2.Size = new System.Drawing.Size(53, 53);
            this.spell2.TabIndex = 5;
            this.spell2.Text = "2";
            this.spell2.UseVisualStyleBackColor = true;
            this.spell2.Click += new System.EventHandler(this.spell2_Click);
            // 
            // spell3
            // 
            this.spell3.Location = new System.Drawing.Point(575, 405);
            this.spell3.Name = "spell3";
            this.spell3.Size = new System.Drawing.Size(53, 53);
            this.spell3.TabIndex = 6;
            this.spell3.Text = "3";
            this.spell3.UseVisualStyleBackColor = true;
            this.spell3.Click += new System.EventHandler(this.spell3_Click);
            // 
            // spell4
            // 
            this.spell4.Location = new System.Drawing.Point(634, 405);
            this.spell4.Name = "spell4";
            this.spell4.Size = new System.Drawing.Size(53, 53);
            this.spell4.TabIndex = 7;
            this.spell4.Text = "4";
            this.spell4.UseVisualStyleBackColor = true;
            this.spell4.Click += new System.EventHandler(this.spell4_Click);
            // 
            // spell_selected
            // 
            this.spell_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spell_selected.Location = new System.Drawing.Point(310, 222);
            this.spell_selected.Multiline = true;
            this.spell_selected.Name = "spell_selected";
            this.spell_selected.Size = new System.Drawing.Size(61, 59);
            this.spell_selected.TabIndex = 8;
            // 
            // enemy_name
            // 
            this.enemy_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy_name.Location = new System.Drawing.Point(1019, 44);
            this.enemy_name.Name = "enemy_name";
            this.enemy_name.Size = new System.Drawing.Size(198, 53);
            this.enemy_name.TabIndex = 9;
            // 
            // enemy_HP
            // 
            this.enemy_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy_HP.Location = new System.Drawing.Point(1246, 44);
            this.enemy_HP.Name = "enemy_HP";
            this.enemy_HP.Size = new System.Drawing.Size(86, 53);
            this.enemy_HP.TabIndex = 10;
            // 
            // Next_Turn
            // 
            this.Next_Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Next_Turn.Location = new System.Drawing.Point(1193, 443);
            this.Next_Turn.Name = "Next_Turn";
            this.Next_Turn.Size = new System.Drawing.Size(159, 67);
            this.Next_Turn.TabIndex = 11;
            this.Next_Turn.Text = "Next Turn";
            this.Next_Turn.UseVisualStyleBackColor = true;
            this.Next_Turn.Click += new System.EventHandler(this.Next_Turn_Click);
            // 
            // Player_Name
            // 
            this.Player_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player_Name.Location = new System.Drawing.Point(12, 44);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(150, 53);
            this.Player_Name.TabIndex = 12;
            // 
            // Player_HP
            // 
            this.Player_HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player_HP.Location = new System.Drawing.Point(168, 44);
            this.Player_HP.Name = "Player_HP";
            this.Player_HP.Size = new System.Drawing.Size(86, 53);
            this.Player_HP.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 522);
            this.Controls.Add(this.Player_HP);
            this.Controls.Add(this.Player_Name);
            this.Controls.Add(this.Next_Turn);
            this.Controls.Add(this.enemy_HP);
            this.Controls.Add(this.enemy_name);
            this.Controls.Add(this.spell_selected);
            this.Controls.Add(this.spell4);
            this.Controls.Add(this.spell3);
            this.Controls.Add(this.spell2);
            this.Controls.Add(this.spell1);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.complex);
            this.Controls.Add(this.output);
            this.Controls.Add(this.roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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


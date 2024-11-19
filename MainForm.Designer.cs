namespace DnD_Battle {
    partial class MainForm {
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
            Main_Panel = new Panel();
            Log = new TextBox();
            SuspendLayout();
            // 
            // Main_Panel
            // 
            Main_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main_Panel.AutoSize = true;
            Main_Panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Main_Panel.BorderStyle = BorderStyle.FixedSingle;
            Main_Panel.Location = new Point(0, 0);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(2, 2);
            Main_Panel.TabIndex = 0;
            // 
            // Log
            // 
            Log.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Log.Location = new Point(390, 322);
            Log.Multiline = true;
            Log.Name = "Log";
            Log.ScrollBars = ScrollBars.Both;
            Log.Size = new Size(386, 89);
            Log.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 450);
            Controls.Add(Log);
            Controls.Add(Main_Panel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Main_Panel;
        private TextBox Log;
    }
}
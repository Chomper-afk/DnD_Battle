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
            Log = new TextBox();
            MainPanel = new Panel();
            SuspendLayout();
            // 
            // Log
            // 
            Log.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Log.Location = new Point(824, 503);
            Log.Multiline = true;
            Log.Name = "Log";
            Log.ScrollBars = ScrollBars.Both;
            Log.Size = new Size(386, 89);
            Log.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1209, 631);
            MainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 631);
            Controls.Add(MainPanel);
            Controls.Add(Log);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Log;
        private Panel MainPanel;
    }
}
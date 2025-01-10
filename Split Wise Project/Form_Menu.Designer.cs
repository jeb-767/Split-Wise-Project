namespace Split_Wise_Project
{
    partial class Form_Menu
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
            But_Groups = new PictureBox();
            But_Friends = new PictureBox();
            But_Hist = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)But_Groups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_Friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_Hist).BeginInit();
            SuspendLayout();
            // 
            // But_Groups
            // 
            But_Groups.Image = Properties.Resources.But_Groups;
            But_Groups.Location = new Point(12, 371);
            But_Groups.Name = "But_Groups";
            But_Groups.Size = new Size(110, 28);
            But_Groups.SizeMode = PictureBoxSizeMode.Zoom;
            But_Groups.TabIndex = 0;
            But_Groups.TabStop = false;
            // 
            // But_Friends
            // 
            But_Friends.Image = Properties.Resources.But_Friends;
            But_Friends.Location = new Point(128, 371);
            But_Friends.Name = "But_Friends";
            But_Friends.Size = new Size(104, 28);
            But_Friends.SizeMode = PictureBoxSizeMode.Zoom;
            But_Friends.TabIndex = 1;
            But_Friends.TabStop = false;
            // 
            // But_Hist
            // 
            But_Hist.Image = Properties.Resources.But_Hist;
            But_Hist.Location = new Point(238, 371);
            But_Hist.Name = "But_Hist";
            But_Hist.Size = new Size(110, 28);
            But_Hist.SizeMode = PictureBoxSizeMode.Zoom;
            But_Hist.TabIndex = 2;
            But_Hist.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 353);
            panel1.TabIndex = 3;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(panel1);
            Controls.Add(But_Hist);
            Controls.Add(But_Friends);
            Controls.Add(But_Groups);
            Name = "Form_Menu";
            Text = "Form_Menu";
            ((System.ComponentModel.ISupportInitialize)But_Groups).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_Friends).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_Hist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox But_Groups;
        private PictureBox But_Friends;
        private PictureBox But_Hist;
        private Panel panel1;
    }
}
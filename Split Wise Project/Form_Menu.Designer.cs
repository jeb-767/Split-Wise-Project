﻿namespace Split_Wise_Project
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
            Panel_Principal = new Panel();
            ((System.ComponentModel.ISupportInitialize)But_Groups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_Friends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_Hist).BeginInit();
            SuspendLayout();
            // 
            // But_Groups
            // 
            But_Groups.BackColor = Color.Transparent;
            But_Groups.Image = Properties.Resources.But_Groups;
            But_Groups.Location = new Point(12, 371);
            But_Groups.Name = "But_Groups";
            But_Groups.Size = new Size(110, 28);
            But_Groups.SizeMode = PictureBoxSizeMode.Zoom;
            But_Groups.TabIndex = 0;
            But_Groups.TabStop = false;
            But_Groups.Click += But_Groups_Click;
            But_Groups.MouseEnter += But_Groups_MouseEnter;
            But_Groups.MouseLeave += But_Groups_MouseLeave;
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
            But_Friends.Click += But_Friends_Click;
            But_Friends.MouseEnter += But_Friends_MouseEnter;
            But_Friends.MouseLeave += But_Friends_MouseLeave;
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
            But_Hist.Click += But_Hist_Click;
            But_Hist.MouseEnter += But_Hist_MouseEnter;
            But_Hist.MouseLeave += But_Hist_MouseLeave;
            // 
            // Panel_Principal
            // 
            Panel_Principal.Location = new Point(12, 12);
            Panel_Principal.Name = "Panel_Principal";
            Panel_Principal.Size = new Size(336, 353);
            Panel_Principal.TabIndex = 3;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(Panel_Principal);
            Controls.Add(But_Hist);
            Controls.Add(But_Friends);
            Controls.Add(But_Groups);
            Name = "Form_Menu";
            ((System.ComponentModel.ISupportInitialize)But_Groups).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_Friends).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_Hist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox But_Groups;
        private PictureBox But_Friends;
        private PictureBox But_Hist;
        private Panel Panel_Principal;
    }
}
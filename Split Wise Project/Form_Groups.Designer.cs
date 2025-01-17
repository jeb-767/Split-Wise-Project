namespace Split_Wise_Project
{
    partial class Form_Groups
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
            But_New_Group = new PictureBox();
            List_View_Groups = new ListView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)But_New_Group).BeginInit();
            SuspendLayout();
            // 
            // But_New_Group
            // 
            But_New_Group.Image = Properties.Resources.But_New_Group1;
            But_New_Group.Location = new Point(255, 265);
            But_New_Group.Name = "But_New_Group";
            But_New_Group.Size = new Size(65, 50);
            But_New_Group.SizeMode = PictureBoxSizeMode.Zoom;
            But_New_Group.TabIndex = 0;
            But_New_Group.TabStop = false;
            But_New_Group.Click += But_New_Group_Click;
            // 
            // List_View_Groups
            // 
            List_View_Groups.BackColor = SystemColors.MenuBar;
            List_View_Groups.BorderStyle = BorderStyle.None;
            List_View_Groups.Location = new Point(12, 12);
            List_View_Groups.Name = "List_View_Groups";
            List_View_Groups.Size = new Size(296, 247);
            List_View_Groups.TabIndex = 1;
            List_View_Groups.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(27, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 313);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // Form_Groups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(panel1);
            Controls.Add(List_View_Groups);
            Controls.Add(But_New_Group);
            Name = "Form_Groups";
            Text = "Form_Groups";
            ((System.ComponentModel.ISupportInitialize)But_New_Group).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox But_New_Group;
        private ListView List_View_Groups;
        private Panel panel1;
    }
}
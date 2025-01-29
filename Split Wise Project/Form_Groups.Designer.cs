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
            List_View_Groups = new ListView();
            PB_OpenListView = new PictureBox();
            But_New_Group = new PictureBox();
            PanelGroups = new Panel();
            ((System.ComponentModel.ISupportInitialize)PB_OpenListView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_New_Group).BeginInit();
            PanelGroups.SuspendLayout();
            SuspendLayout();
            // 
            // List_View_Groups
            // 
            List_View_Groups.BackColor = SystemColors.Control;
            List_View_Groups.BorderStyle = BorderStyle.None;
            List_View_Groups.Location = new Point(0, 0);
            List_View_Groups.Name = "List_View_Groups";
            List_View_Groups.Size = new Size(322, 137);
            List_View_Groups.TabIndex = 1;
            List_View_Groups.UseCompatibleStateImageBehavior = false;
            // 
            // PB_OpenListView
            // 
            PB_OpenListView.Image = Properties.Resources.But_Groups;
            PB_OpenListView.Location = new Point(0, 277);
            PB_OpenListView.Name = "PB_OpenListView";
            PB_OpenListView.Size = new Size(57, 22);
            PB_OpenListView.SizeMode = PictureBoxSizeMode.Zoom;
            PB_OpenListView.TabIndex = 0;
            PB_OpenListView.TabStop = false;
            PB_OpenListView.Click += PB_OpenListView_Click;
            // 
            // But_New_Group
            // 
            But_New_Group.Image = Properties.Resources.But_New_Group;
            But_New_Group.Location = new Point(243, 249);
            But_New_Group.Name = "But_New_Group";
            But_New_Group.Size = new Size(65, 50);
            But_New_Group.SizeMode = PictureBoxSizeMode.Zoom;
            But_New_Group.TabIndex = 0;
            But_New_Group.TabStop = false;
            But_New_Group.Click += But_New_Group_Click;
            But_New_Group.MouseEnter += But_New_Group_MouseEnter;
            But_New_Group.MouseLeave += But_New_Group_MouseLeave;
            // 
            // PanelGroups
            // 
            PanelGroups.BackColor = SystemColors.Control;
            PanelGroups.Controls.Add(But_New_Group);
            PanelGroups.Controls.Add(PB_OpenListView);
            PanelGroups.Controls.Add(List_View_Groups);
            PanelGroups.Location = new Point(0, 3);
            PanelGroups.Name = "PanelGroups";
            PanelGroups.Size = new Size(319, 299);
            PanelGroups.TabIndex = 3;
            // 
            // Form_Groups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(PanelGroups);
            Name = "Form_Groups";
            ((System.ComponentModel.ISupportInitialize)PB_OpenListView).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_New_Group).EndInit();
            PanelGroups.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ListView List_View_Groups;
        private PictureBox PB_OpenListView;
        private PictureBox But_New_Group;
        private Panel PanelGroups;
    }
}
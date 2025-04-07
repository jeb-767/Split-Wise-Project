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
            PB_OpenListView = new PictureBox();
            But_New_Group = new PictureBox();
            PanelGroups = new Panel();
            dataGridView1 = new DataGridView();
            PB_DeleteFriend = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PB_OpenListView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_New_Group).BeginInit();
            PanelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_DeleteFriend).BeginInit();
            SuspendLayout();
            // 
            // PB_OpenListView
            // 
            PB_OpenListView.Image = Properties.Resources.But_Groups;
            PB_OpenListView.Location = new Point(0, 290);
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
            But_New_Group.Location = new Point(251, 262);
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
            PanelGroups.Controls.Add(dataGridView1);
            PanelGroups.Location = new Point(0, 3);
            PanelGroups.Name = "PanelGroups";
            PanelGroups.Size = new Size(319, 246);
            PanelGroups.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 243);
            dataGridView1.TabIndex = 1;
            // 
            // PB_DeleteFriend
            // 
            PB_DeleteFriend.Image = Properties.Resources.But_Delete_Group;
            PB_DeleteFriend.Location = new Point(3, 252);
            PB_DeleteFriend.Name = "PB_DeleteFriend";
            PB_DeleteFriend.Size = new Size(54, 32);
            PB_DeleteFriend.SizeMode = PictureBoxSizeMode.Zoom;
            PB_DeleteFriend.TabIndex = 4;
            PB_DeleteFriend.TabStop = false;
            PB_DeleteFriend.Click += PB_Delete_Group_Click;
            // 
            // Form_Groups
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(PB_DeleteFriend);
            Controls.Add(PB_OpenListView);
            Controls.Add(But_New_Group);
            Controls.Add(PanelGroups);
            Name = "Form_Groups";
            ((System.ComponentModel.ISupportInitialize)PB_OpenListView).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_New_Group).EndInit();
            PanelGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_DeleteFriend).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox PB_OpenListView;
        private PictureBox But_New_Group;
        private Panel PanelGroups;
        private DataGridView dataGridView1;
        private PictureBox PB_DeleteFriend;
    }
}
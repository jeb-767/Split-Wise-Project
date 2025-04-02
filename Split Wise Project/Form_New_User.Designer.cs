namespace Split_Wise_Project
{
    partial class Form_New_User
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
            TB_Friends_Information = new TextBox();
            TB_Friends_Phone = new TextBox();
            TB_Friends_Email = new TextBox();
            TB_Friends_Description = new TextBox();
            button2 = new Button();
            button1 = new Button();
            TB_Friends_Surname = new TextBox();
            pictureBox1 = new PictureBox();
            TB_Friends_Name = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TB_Friends_Information
            // 
            TB_Friends_Information.BackColor = SystemColors.MenuBar;
            TB_Friends_Information.Location = new Point(12, 192);
            TB_Friends_Information.Name = "TB_Friends_Information";
            TB_Friends_Information.Size = new Size(296, 23);
            TB_Friends_Information.TabIndex = 24;
            TB_Friends_Information.Text = "Más Información";
            // 
            // TB_Friends_Phone
            // 
            TB_Friends_Phone.BackColor = SystemColors.MenuBar;
            TB_Friends_Phone.Location = new Point(12, 163);
            TB_Friends_Phone.Name = "TB_Friends_Phone";
            TB_Friends_Phone.Size = new Size(296, 23);
            TB_Friends_Phone.TabIndex = 23;
            TB_Friends_Phone.Text = "Telefono";
            // 
            // TB_Friends_Email
            // 
            TB_Friends_Email.BackColor = SystemColors.MenuBar;
            TB_Friends_Email.Location = new Point(12, 134);
            TB_Friends_Email.Name = "TB_Friends_Email";
            TB_Friends_Email.Size = new Size(296, 23);
            TB_Friends_Email.TabIndex = 22;
            TB_Friends_Email.Text = "Correo";
            // 
            // TB_Friends_Description
            // 
            TB_Friends_Description.BackColor = SystemColors.MenuBar;
            TB_Friends_Description.Location = new Point(12, 105);
            TB_Friends_Description.Name = "TB_Friends_Description";
            TB_Friends_Description.Size = new Size(296, 23);
            TB_Friends_Description.TabIndex = 21;
            TB_Friends_Description.Text = "Descripción";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button2.Location = new Point(189, 278);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 20;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button1.Location = new Point(12, 278);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 19;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // TB_Friends_Surname
            // 
            TB_Friends_Surname.BackColor = SystemColors.MenuBar;
            TB_Friends_Surname.Location = new Point(118, 76);
            TB_Friends_Surname.Name = "TB_Friends_Surname";
            TB_Friends_Surname.Size = new Size(190, 23);
            TB_Friends_Surname.TabIndex = 18;
            TB_Friends_Surname.Text = "Apellidos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.But_New_Photo;
            pictureBox1.Location = new Point(12, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // TB_Friends_Name
            // 
            TB_Friends_Name.BackColor = SystemColors.MenuBar;
            TB_Friends_Name.Location = new Point(118, 47);
            TB_Friends_Name.Name = "TB_Friends_Name";
            TB_Friends_Name.Size = new Size(190, 23);
            TB_Friends_Name.TabIndex = 16;
            TB_Friends_Name.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 22);
            textBox1.TabIndex = 15;
            textBox1.Text = "Crear Nuevo Contacto";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form_New_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(TB_Friends_Information);
            Controls.Add(TB_Friends_Phone);
            Controls.Add(TB_Friends_Email);
            Controls.Add(TB_Friends_Description);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TB_Friends_Surname);
            Controls.Add(pictureBox1);
            Controls.Add(TB_Friends_Name);
            Controls.Add(textBox1);
            Name = "Form_New_User";
            Text = "Form_New_User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Friends_Information;
        private TextBox TB_Friends_Phone;
        private TextBox TB_Friends_Email;
        private TextBox TB_Friends_Description;
        private Button button2;
        private Button button1;
        private TextBox TB_Friends_Surname;
        private PictureBox pictureBox1;
        private TextBox TB_Friends_Name;
        private TextBox textBox1;
    }
}
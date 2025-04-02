namespace Split_Wise_Project
{
    partial class Form_NewFriend
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            TB_Friends_Email = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = "Añadir Amigo\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button1.Location = new Point(12, 64);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += But_Friends_Cancel_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button2.Location = new Point(189, 64);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 10;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += But_Friends_Create_Click;
            // 
            // TB_Friends_Email
            // 
            TB_Friends_Email.BackColor = SystemColors.MenuBar;
            TB_Friends_Email.Location = new Point(12, 35);
            TB_Friends_Email.Name = "TB_Friends_Email";
            TB_Friends_Email.Size = new Size(296, 23);
            TB_Friends_Email.TabIndex = 12;
            TB_Friends_Email.Text = "Correo";
            // 
            // Form_NewFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 102);
            Controls.Add(TB_Friends_Email);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form_NewFriend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox TB_Friends_Email;
    }
}
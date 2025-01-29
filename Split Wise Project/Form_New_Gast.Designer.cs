namespace Split_Wise_Project
{
    partial class Form_New_Gast
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            But_Gast_Cancel = new Button();
            But_Add_Gast = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Nuevo Gasto";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(12, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Descripción";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(12, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(13, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Gasto Total";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.Location = new Point(191, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Gasto Tuyo";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Menu;
            textBox6.Location = new Point(191, 157);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "Gasto A Pagar";
            // 
            // But_Gast_Cancel
            // 
            But_Gast_Cancel.BackColor = SystemColors.Menu;
            But_Gast_Cancel.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            But_Gast_Cancel.Location = new Point(12, 228);
            But_Gast_Cancel.Name = "But_Gast_Cancel";
            But_Gast_Cancel.Size = new Size(119, 29);
            But_Gast_Cancel.TabIndex = 20;
            But_Gast_Cancel.Text = "Cancelar";
            But_Gast_Cancel.UseVisualStyleBackColor = false;
            But_Gast_Cancel.Click += But_Gast_Cancel_Click;
            // 
            // But_Add_Gast
            // 
            But_Add_Gast.BackColor = SystemColors.Menu;
            But_Add_Gast.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            But_Add_Gast.Location = new Point(172, 228);
            But_Add_Gast.Name = "But_Add_Gast";
            But_Add_Gast.Size = new Size(119, 29);
            But_Add_Gast.TabIndex = 21;
            But_Add_Gast.Text = "Añadir";
            But_Add_Gast.UseVisualStyleBackColor = false;
            But_Add_Gast.Click += But_Add_Gast_Click;
            // 
            // Form_New_Gast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 269);
            Controls.Add(But_Add_Gast);
            Controls.Add(But_Gast_Cancel);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form_New_Gast";
            Text = "Form_New_Gast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button But_Gast_Cancel;
        private Button But_Add_Gast;
    }
}
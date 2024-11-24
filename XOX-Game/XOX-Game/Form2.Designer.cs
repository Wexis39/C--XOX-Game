namespace XOX_Game
{
    partial class Form2
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
            label1 = new Label();
            panel1 = new Panel();
            lblWon = new Label();
            brnRestart = new Button();
            btnQuit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkViolet;
            label1.Font = new Font("Cascadia Code", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 96);
            label1.TabIndex = 0;
            label1.Text = "Game Over";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 96);
            panel1.TabIndex = 1;
            // 
            // lblWon
            // 
            lblWon.AutoSize = true;
            lblWon.BackColor = Color.Purple;
            lblWon.Font = new Font("Cascadia Code", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWon.ForeColor = Color.White;
            lblWon.Location = new Point(170, 104);
            lblWon.Name = "lblWon";
            lblWon.Size = new Size(212, 96);
            lblWon.TabIndex = 0;
            lblWon.Text = " Won";
            // 
            // brnRestart
            // 
            brnRestart.BackColor = Color.MediumOrchid;
            brnRestart.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnRestart.ForeColor = Color.White;
            brnRestart.Location = new Point(85, 228);
            brnRestart.Name = "brnRestart";
            brnRestart.Size = new Size(168, 69);
            brnRestart.TabIndex = 2;
            brnRestart.Text = "RESTART";
            brnRestart.UseVisualStyleBackColor = false;
            brnRestart.Click += brnRestart_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.MediumOrchid;
            btnQuit.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(344, 228);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(168, 69);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(595, 315);
            Controls.Add(btnQuit);
            Controls.Add(brnRestart);
            Controls.Add(lblWon);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblWon;
        private Button brnRestart;
        private Button btnQuit;
    }
}
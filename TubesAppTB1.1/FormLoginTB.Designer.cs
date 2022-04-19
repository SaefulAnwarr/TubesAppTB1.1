namespace TubesAppTB1._1
{
    partial class FormLoginTB
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
            this.buttLoginTB = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelJudulApp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttLoginTB
            // 
            this.buttLoginTB.Location = new System.Drawing.Point(360, 180);
            this.buttLoginTB.Name = "buttLoginTB";
            this.buttLoginTB.Size = new System.Drawing.Size(117, 45);
            this.buttLoginTB.TabIndex = 0;
            this.buttLoginTB.Text = "Login";
            this.buttLoginTB.UseVisualStyleBackColor = true;
            this.buttLoginTB.Click += new System.EventHandler(this.buttLoginTB_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(188, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(69, 91);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(69, 136);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelJudulApp
            // 
            this.labelJudulApp.AutoSize = true;
            this.labelJudulApp.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudulApp.Location = new System.Drawing.Point(64, 30);
            this.labelJudulApp.Name = "labelJudulApp";
            this.labelJudulApp.Size = new System.Drawing.Size(265, 35);
            this.labelJudulApp.TabIndex = 5;
            this.labelJudulApp.Text = "Aplikasi Tambal Ban";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TubesAppTB1._1.Properties.Resources.tire_5666200_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(204, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLoginTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(552, 253);
            this.Controls.Add(this.labelJudulApp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.buttLoginTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLoginTB";
            this.Text = "Aplikasi Tambal Ban";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttLoginTB;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelJudulApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
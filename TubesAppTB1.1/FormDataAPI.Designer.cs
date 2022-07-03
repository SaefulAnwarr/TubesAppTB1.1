namespace TubesAppTB1._1
{
    partial class FormDataAPI
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
            this.labelJudulApp = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnGerai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudulApp
            // 
            this.labelJudulApp.AutoSize = true;
            this.labelJudulApp.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudulApp.Location = new System.Drawing.Point(12, 19);
            this.labelJudulApp.Name = "labelJudulApp";
            this.labelJudulApp.Size = new System.Drawing.Size(265, 35);
            this.labelJudulApp.TabIndex = 6;
            this.labelJudulApp.Text = "Aplikasi Tambal Ban";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(18, 67);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(185, 46);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "Get Data User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnGerai
            // 
            this.btnGerai.Location = new System.Drawing.Point(209, 67);
            this.btnGerai.Name = "btnGerai";
            this.btnGerai.Size = new System.Drawing.Size(185, 46);
            this.btnGerai.TabIndex = 8;
            this.btnGerai.Text = "Get Data Gerai";
            this.btnGerai.UseVisualStyleBackColor = true;
            this.btnGerai.Click += new System.EventHandler(this.btnGerai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(478, 279);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormDataAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGerai);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.labelJudulApp);
            this.Name = "FormDataAPI";
            this.Text = "Data Tambal Ban App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudulApp;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnGerai;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
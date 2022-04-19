namespace TubesAppTB1._1
{
    partial class FormPilihGerai
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.butPesanGerai = new System.Windows.Forms.Button();
            this.geraiA = new System.Windows.Forms.RadioButton();
            this.geraiB = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(427, 204);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5641F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.4359F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.butPesanGerai, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.geraiA, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.geraiB, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.07692F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 201);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pilih Gerai";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butPesanGerai
            // 
            this.butPesanGerai.Location = new System.Drawing.Point(39, 117);
            this.butPesanGerai.Name = "butPesanGerai";
            this.butPesanGerai.Size = new System.Drawing.Size(75, 23);
            this.butPesanGerai.TabIndex = 1;
            this.butPesanGerai.Text = "Pesan";
            this.butPesanGerai.UseVisualStyleBackColor = true;
            this.butPesanGerai.Click += new System.EventHandler(this.butPesanGerai_Click);
            // 
            // geraiA
            // 
            this.geraiA.Appearance = System.Windows.Forms.Appearance.Button;
            this.geraiA.Location = new System.Drawing.Point(39, 56);
            this.geraiA.Name = "geraiA";
            this.geraiA.Size = new System.Drawing.Size(117, 23);
            this.geraiA.TabIndex = 0;
            this.geraiA.TabStop = true;
            this.geraiA.Text = "Gerai A";
            this.geraiA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.geraiA.UseVisualStyleBackColor = true;
            // 
            // geraiB
            // 
            this.geraiB.Appearance = System.Windows.Forms.Appearance.Button;
            this.geraiB.Location = new System.Drawing.Point(39, 86);
            this.geraiB.Name = "geraiB";
            this.geraiB.Size = new System.Drawing.Size(117, 23);
            this.geraiB.TabIndex = 0;
            this.geraiB.TabStop = true;
            this.geraiB.Text = "Gerai B";
            this.geraiB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.geraiB.UseVisualStyleBackColor = true;
            // 
            // FormPilihGerai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 235);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "FormPilihGerai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPilihGerai";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butPesanGerai;
        private System.Windows.Forms.RadioButton geraiA;
        private System.Windows.Forms.RadioButton geraiB;
    }
}
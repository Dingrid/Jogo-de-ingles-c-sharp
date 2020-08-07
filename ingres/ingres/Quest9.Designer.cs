namespace WindowsFormsApplication1
{
    partial class Quest9
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLegitimate = new System.Windows.Forms.Button();
            this.btnIllegal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.Navy;
            this.btnStudents.Location = new System.Drawing.Point(97, 278);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(75, 23);
            this.btnStudents.TabIndex = 18;
            this.btnStudents.Text = "students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnLegitimate
            // 
            this.btnLegitimate.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnLegitimate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLegitimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLegitimate.ForeColor = System.Drawing.Color.Navy;
            this.btnLegitimate.Location = new System.Drawing.Point(97, 191);
            this.btnLegitimate.Name = "btnLegitimate";
            this.btnLegitimate.Size = new System.Drawing.Size(75, 23);
            this.btnLegitimate.TabIndex = 17;
            this.btnLegitimate.Text = "legitimate";
            this.btnLegitimate.UseVisualStyleBackColor = true;
            this.btnLegitimate.Click += new System.EventHandler(this.btnLegitimate_Click);
            // 
            // btnIllegal
            // 
            this.btnIllegal.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnIllegal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIllegal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIllegal.ForeColor = System.Drawing.Color.Navy;
            this.btnIllegal.Location = new System.Drawing.Point(97, 120);
            this.btnIllegal.Name = "btnIllegal";
            this.btnIllegal.Size = new System.Drawing.Size(75, 23);
            this.btnIllegal.TabIndex = 16;
            this.btnIllegal.Text = "illegal";
            this.btnIllegal.UseVisualStyleBackColor = true;
            this.btnIllegal.Click += new System.EventHandler(this.btnIllegal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "A DoS attack is any attack that aims to ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONHECIMENTOS GERAIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-1, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "deny ___ users the use of the target system.";
            // 
            // Quest9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnLegitimate);
            this.Controls.Add(this.btnIllegal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quest9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnLegitimate;
        private System.Windows.Forms.Button btnIllegal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
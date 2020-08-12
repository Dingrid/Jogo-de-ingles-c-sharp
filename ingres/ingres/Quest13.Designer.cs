namespace WindowsFormsApplication1
{
    partial class Quest13
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
            this.btnMachucar = new System.Windows.Forms.Button();
            this.btnPisar = new System.Windows.Forms.Button();
            this.btnEscorregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMachucar
            // 
            this.btnMachucar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnMachucar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMachucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachucar.ForeColor = System.Drawing.Color.Navy;
            this.btnMachucar.Location = new System.Drawing.Point(80, 212);
            this.btnMachucar.Name = "btnMachucar";
            this.btnMachucar.Size = new System.Drawing.Size(90, 29);
            this.btnMachucar.TabIndex = 36;
            this.btnMachucar.Text = "Jogar bola.";
            this.btnMachucar.UseVisualStyleBackColor = true;
            this.btnMachucar.Click += new System.EventHandler(this.btnMachucar_Click);
            // 
            // btnPisar
            // 
            this.btnPisar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnPisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPisar.ForeColor = System.Drawing.Color.Navy;
            this.btnPisar.Location = new System.Drawing.Point(80, 154);
            this.btnPisar.Name = "btnPisar";
            this.btnPisar.Size = new System.Drawing.Size(90, 35);
            this.btnPisar.TabIndex = 35;
            this.btnPisar.Text = "Pisar na bola.";
            this.btnPisar.UseVisualStyleBackColor = true;
            this.btnPisar.Click += new System.EventHandler(this.btnPisar_Click);
            // 
            // btnEscorregar
            // 
            this.btnEscorregar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnEscorregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscorregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscorregar.ForeColor = System.Drawing.Color.Navy;
            this.btnEscorregar.Location = new System.Drawing.Point(80, 93);
            this.btnEscorregar.Name = "btnEscorregar";
            this.btnEscorregar.Size = new System.Drawing.Size(90, 41);
            this.btnEscorregar.TabIndex = 34;
            this.btnEscorregar.Text = "Escorregar na bola.";
            this.btnEscorregar.UseVisualStyleBackColor = true;
            this.btnEscorregar.Click += new System.EventHandler(this.btnEscorregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(85, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Drop the ball";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "EXPRESSÕES";
            // 
            // Quest13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kawaii_pastel_wallpaper_1014729;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.btnMachucar);
            this.Controls.Add(this.btnPisar);
            this.Controls.Add(this.btnEscorregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quest13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMachucar;
        private System.Windows.Forms.Button btnPisar;
        private System.Windows.Forms.Button btnEscorregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
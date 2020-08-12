namespace WindowsFormsApplication1
{
    partial class Quest14
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
            this.btnGrato = new System.Windows.Forms.Button();
            this.btnMerecer = new System.Windows.Forms.Button();
            this.btnValor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrato
            // 
            this.btnGrato.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnGrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrato.ForeColor = System.Drawing.Color.Navy;
            this.btnGrato.Location = new System.Drawing.Point(83, 223);
            this.btnGrato.Name = "btnGrato";
            this.btnGrato.Size = new System.Drawing.Size(90, 29);
            this.btnGrato.TabIndex = 41;
            this.btnGrato.Text = "Seja grato.";
            this.btnGrato.UseVisualStyleBackColor = true;
            this.btnGrato.Click += new System.EventHandler(this.btnGrato_Click);
            // 
            // btnMerecer
            // 
            this.btnMerecer.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnMerecer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMerecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerecer.ForeColor = System.Drawing.Color.Navy;
            this.btnMerecer.Location = new System.Drawing.Point(83, 165);
            this.btnMerecer.Name = "btnMerecer";
            this.btnMerecer.Size = new System.Drawing.Size(90, 35);
            this.btnMerecer.TabIndex = 40;
            this.btnMerecer.Text = "Faça por merecer.";
            this.btnMerecer.UseVisualStyleBackColor = true;
            this.btnMerecer.Click += new System.EventHandler(this.btnMerecer_Click);
            // 
            // btnValor
            // 
            this.btnValor.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValor.ForeColor = System.Drawing.Color.Navy;
            this.btnValor.Location = new System.Drawing.Point(83, 104);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(90, 41);
            this.btnValor.TabIndex = 39;
            this.btnValor.Text = "Não dar valor.";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Take for granted";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "EXPRESSÕES";
            // 
            // Quest14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.rainbow_pastel_background_tumblr_300x200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.btnGrato);
            this.Controls.Add(this.btnMerecer);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quest14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrato;
        private System.Windows.Forms.Button btnMerecer;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace WindowsFormsApplication1
{
    partial class Quest11
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
            this.btnQuero = new System.Windows.Forms.Button();
            this.btnPedaco = new System.Windows.Forms.Button();
            this.btnMoleza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuero
            // 
            this.btnQuero.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnQuero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuero.ForeColor = System.Drawing.Color.Navy;
            this.btnQuero.Location = new System.Drawing.Point(88, 203);
            this.btnQuero.Name = "btnQuero";
            this.btnQuero.Size = new System.Drawing.Size(75, 47);
            this.btnQuero.TabIndex = 30;
            this.btnQuero.Text = "Quero um pedaço de bolo.";
            this.btnQuero.UseVisualStyleBackColor = true;
            this.btnQuero.Click += new System.EventHandler(this.btnWell_Click);
            // 
            // btnPedaco
            // 
            this.btnPedaco.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnPedaco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedaco.ForeColor = System.Drawing.Color.Navy;
            this.btnPedaco.Location = new System.Drawing.Point(88, 139);
            this.btnPedaco.Name = "btnPedaco";
            this.btnPedaco.Size = new System.Drawing.Size(75, 40);
            this.btnPedaco.TabIndex = 29;
            this.btnPedaco.Text = "Pedaço de bolo.";
            this.btnPedaco.UseVisualStyleBackColor = true;
            this.btnPedaco.Click += new System.EventHandler(this.btnKnow_Click);
            // 
            // btnMoleza
            // 
            this.btnMoleza.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnMoleza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoleza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoleza.ForeColor = System.Drawing.Color.Navy;
            this.btnMoleza.Location = new System.Drawing.Point(88, 88);
            this.btnMoleza.Name = "btnMoleza";
            this.btnMoleza.Size = new System.Drawing.Size(75, 23);
            this.btnMoleza.TabIndex = 28;
            this.btnMoleza.Text = "Moleza!";
            this.btnMoleza.UseVisualStyleBackColor = true;
            this.btnMoleza.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Piece of cake.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(70, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "EXPRESSÕES";
            // 
            // Quest11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.btnQuero);
            this.Controls.Add(this.btnPedaco);
            this.Controls.Add(this.btnMoleza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quest11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuero;
        private System.Windows.Forms.Button btnPedaco;
        private System.Windows.Forms.Button btnMoleza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
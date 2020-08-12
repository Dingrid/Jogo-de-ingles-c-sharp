namespace WindowsFormsApplication1
{
    partial class Quest15
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
            this.btnCama = new System.Windows.Forms.Button();
            this.btnBaderna = new System.Windows.Forms.Button();
            this.btnBater = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCama
            // 
            this.btnCama.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnCama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCama.ForeColor = System.Drawing.Color.Navy;
            this.btnCama.Location = new System.Drawing.Point(83, 214);
            this.btnCama.Name = "btnCama";
            this.btnCama.Size = new System.Drawing.Size(90, 48);
            this.btnCama.TabIndex = 46;
            this.btnCama.Text = "Ir para a cama.";
            this.btnCama.UseVisualStyleBackColor = true;
            this.btnCama.Click += new System.EventHandler(this.btnCama_Click);
            // 
            // btnBaderna
            // 
            this.btnBaderna.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnBaderna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaderna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaderna.ForeColor = System.Drawing.Color.Navy;
            this.btnBaderna.Location = new System.Drawing.Point(83, 165);
            this.btnBaderna.Name = "btnBaderna";
            this.btnBaderna.Size = new System.Drawing.Size(90, 35);
            this.btnBaderna.TabIndex = 45;
            this.btnBaderna.Text = "Badernar.";
            this.btnBaderna.UseVisualStyleBackColor = true;
            this.btnBaderna.Click += new System.EventHandler(this.btnBaderna_Click);
            // 
            // btnBater
            // 
            this.btnBater.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnBater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBater.ForeColor = System.Drawing.Color.Navy;
            this.btnBater.Location = new System.Drawing.Point(83, 104);
            this.btnBater.Name = "btnBater";
            this.btnBater.Size = new System.Drawing.Size(90, 41);
            this.btnBater.TabIndex = 44;
            this.btnBater.Text = "Bater no saco.";
            this.btnBater.UseVisualStyleBackColor = true;
            this.btnBater.Click += new System.EventHandler(this.btnBater_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hit the sack";
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
            this.label1.TabIndex = 42;
            this.label1.Text = "EXPRESSÕES";
            // 
            // Quest15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.NCkWq4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 283);
            this.Controls.Add(this.btnCama);
            this.Controls.Add(this.btnBaderna);
            this.Controls.Add(this.btnBater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quest15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCama;
        private System.Windows.Forms.Button btnBaderna;
        private System.Windows.Forms.Button btnBater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
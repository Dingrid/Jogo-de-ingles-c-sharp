namespace WindowsFormsApplication1
{
    partial class Quest7
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
            this.btnBake = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBake
            // 
            this.btnBake.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnBake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBake.ForeColor = System.Drawing.Color.Navy;
            this.btnBake.Location = new System.Drawing.Point(102, 272);
            this.btnBake.Name = "btnBake";
            this.btnBake.Size = new System.Drawing.Size(75, 23);
            this.btnBake.TabIndex = 13;
            this.btnBake.Text = "bake";
            this.btnBake.UseVisualStyleBackColor = true;
            this.btnBake.Click += new System.EventHandler(this.btnBake_Click);
            // 
            // btnMake
            // 
            this.btnMake.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnMake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMake.ForeColor = System.Drawing.Color.Navy;
            this.btnMake.Location = new System.Drawing.Point(102, 183);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 12;
            this.btnMake.Text = "make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._144559;
            this.btnDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDo.ForeColor = System.Drawing.Color.Navy;
            this.btnDo.Location = new System.Drawing.Point(102, 101);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 11;
            this.btnDo.Text = "do";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Intrusion is generally what hackers __.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONHECIMENTOS GERAIS";
            // 
            // Quest7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.btnBake);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quest7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBake;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
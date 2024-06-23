namespace FilmotecaNovo
{
    partial class Filmoteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmoteca));
            this.btPipoca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCinema = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPipoca
            // 
            this.btPipoca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btPipoca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btPipoca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btPipoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPipoca.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPipoca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btPipoca.Location = new System.Drawing.Point(241, 380);
            this.btPipoca.Name = "btPipoca";
            this.btPipoca.Size = new System.Drawing.Size(167, 69);
            this.btPipoca.TabIndex = 1;
            this.btPipoca.Text = "PREPARAR A PIPOCA";
            this.btPipoca.UseVisualStyleBackColor = false;
            this.btPipoca.Click += new System.EventHandler(this.btPipoca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btCinema
            // 
            this.btCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btCinema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btCinema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCinema.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCinema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            this.btCinema.Location = new System.Drawing.Point(573, 380);
            this.btCinema.Name = "btCinema";
            this.btCinema.Size = new System.Drawing.Size(167, 69);
            this.btCinema.TabIndex = 4;
            this.btCinema.Text = "SALA DE CINEMA";
            this.btCinema.UseVisualStyleBackColor = false;
            this.btCinema.Click += new System.EventHandler(this.btCinema_Click);
            // 
            // Filmoteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 645);
            this.Controls.Add(this.btCinema);
            this.Controls.Add(this.btPipoca);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Filmoteca";
            this.Text = "Filmoteca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btPipoca;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btCinema;
    }
}


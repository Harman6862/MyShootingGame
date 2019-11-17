namespace MyShootingGame
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.FireAway = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 449);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(683, 34);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 1;
            this.Load.Text = "LOAD";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(683, 79);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(75, 23);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "SPIN";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Fire
            // 
            this.Fire.Location = new System.Drawing.Point(683, 130);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(75, 23);
            this.Fire.TabIndex = 3;
            this.Fire.Text = "FIRE";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // FireAway
            // 
            this.FireAway.Location = new System.Drawing.Point(683, 182);
            this.FireAway.Name = "FireAway";
            this.FireAway.Size = new System.Drawing.Size(75, 23);
            this.FireAway.TabIndex = 4;
            this.FireAway.Text = "FIREAWAY";
            this.FireAway.UseVisualStyleBackColor = true;
            this.FireAway.Click += new System.EventHandler(this.FireAway_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(683, 342);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(75, 77);
            this.PlayAgain.TabIndex = 5;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.FireAway);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button FireAway;
        private System.Windows.Forms.Button PlayAgain;
    }
}


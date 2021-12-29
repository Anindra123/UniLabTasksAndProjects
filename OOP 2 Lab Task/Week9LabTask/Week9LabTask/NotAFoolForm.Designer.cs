
namespace Week9LabTask
{
    partial class NotAFoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotAFoolForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.closeAppBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(172, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations, You\'re not a Fool !!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.White;
            this.goBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.Blue;
            this.goBackBtn.Location = new System.Drawing.Point(195, 369);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(114, 47);
            this.goBackBtn.TabIndex = 3;
            this.goBackBtn.TabStop = false;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.BackColor = System.Drawing.Color.White;
            this.closeAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.closeAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAppBtn.ForeColor = System.Drawing.Color.Blue;
            this.closeAppBtn.Location = new System.Drawing.Point(468, 369);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(162, 47);
            this.closeAppBtn.TabIndex = 4;
            this.closeAppBtn.TabStop = false;
            this.closeAppBtn.Text = "Close Application";
            this.closeAppBtn.UseVisualStyleBackColor = false;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // NotAFoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "NotAFoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I am not a fool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NotAFoolForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Button closeAppBtn;
    }
}
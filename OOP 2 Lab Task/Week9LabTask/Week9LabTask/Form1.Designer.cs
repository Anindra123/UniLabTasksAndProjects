
namespace Week9LabTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.yesFoolBtn = new System.Windows.Forms.Button();
            this.NotAFoolBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(236, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you a fool ?";
            // 
            // yesFoolBtn
            // 
            this.yesFoolBtn.BackColor = System.Drawing.Color.White;
            this.yesFoolBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.yesFoolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yesFoolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.yesFoolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesFoolBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesFoolBtn.ForeColor = System.Drawing.Color.Lime;
            this.yesFoolBtn.Location = new System.Drawing.Point(160, 293);
            this.yesFoolBtn.Name = "yesFoolBtn";
            this.yesFoolBtn.Size = new System.Drawing.Size(118, 47);
            this.yesFoolBtn.TabIndex = 1;
            this.yesFoolBtn.TabStop = false;
            this.yesFoolBtn.Text = "YES";
            this.yesFoolBtn.UseVisualStyleBackColor = false;
            this.yesFoolBtn.Click += new System.EventHandler(this.yesFoolBtn_Click);
            // 
            // NotAFoolBtn
            // 
            this.NotAFoolBtn.BackColor = System.Drawing.Color.White;
            this.NotAFoolBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.NotAFoolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NotAFoolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NotAFoolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotAFoolBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotAFoolBtn.ForeColor = System.Drawing.Color.Red;
            this.NotAFoolBtn.Location = new System.Drawing.Point(523, 293);
            this.NotAFoolBtn.Name = "NotAFoolBtn";
            this.NotAFoolBtn.Size = new System.Drawing.Size(118, 47);
            this.NotAFoolBtn.TabIndex = 2;
            this.NotAFoolBtn.TabStop = false;
            this.NotAFoolBtn.Text = "NO";
            this.NotAFoolBtn.UseVisualStyleBackColor = false;
            this.NotAFoolBtn.MouseEnter += new System.EventHandler(this.NotAFoolBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotAFoolBtn);
            this.Controls.Add(this.yesFoolBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fool Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesFoolBtn;
        private System.Windows.Forms.Button NotAFoolBtn;
    }
}


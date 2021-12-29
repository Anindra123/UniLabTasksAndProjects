
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cm_1 = new System.Windows.Forms.PictureBox();
            this.cm_2 = new System.Windows.Forms.PictureBox();
            this.cm_3 = new System.Windows.Forms.PictureBox();
            this.crew_mate_1 = new System.Windows.Forms.Button();
            this.crew_mate_2 = new System.Windows.Forms.Button();
            this.crew_mate_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.susPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cm_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cm_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cm_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cm_1
            // 
            this.cm_1.Image = ((System.Drawing.Image)(resources.GetObject("cm_1.Image")));
            this.cm_1.Location = new System.Drawing.Point(105, 117);
            this.cm_1.Name = "cm_1";
            this.cm_1.Size = new System.Drawing.Size(133, 177);
            this.cm_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cm_1.TabIndex = 0;
            this.cm_1.TabStop = false;
            // 
            // cm_2
            // 
            this.cm_2.Image = ((System.Drawing.Image)(resources.GetObject("cm_2.Image")));
            this.cm_2.Location = new System.Drawing.Point(339, 117);
            this.cm_2.Name = "cm_2";
            this.cm_2.Size = new System.Drawing.Size(133, 177);
            this.cm_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cm_2.TabIndex = 1;
            this.cm_2.TabStop = false;
            // 
            // cm_3
            // 
            this.cm_3.Image = ((System.Drawing.Image)(resources.GetObject("cm_3.Image")));
            this.cm_3.Location = new System.Drawing.Point(585, 117);
            this.cm_3.Name = "cm_3";
            this.cm_3.Size = new System.Drawing.Size(133, 177);
            this.cm_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cm_3.TabIndex = 2;
            this.cm_3.TabStop = false;
            // 
            // crew_mate_1
            // 
            this.crew_mate_1.Location = new System.Drawing.Point(105, 327);
            this.crew_mate_1.Name = "crew_mate_1";
            this.crew_mate_1.Size = new System.Drawing.Size(133, 49);
            this.crew_mate_1.TabIndex = 3;
            this.crew_mate_1.Text = "Crew Mate 1";
            this.crew_mate_1.UseVisualStyleBackColor = true;
            this.crew_mate_1.Click += new System.EventHandler(this.crew_mate_1_Click);
            // 
            // crew_mate_2
            // 
            this.crew_mate_2.Location = new System.Drawing.Point(339, 327);
            this.crew_mate_2.Name = "crew_mate_2";
            this.crew_mate_2.Size = new System.Drawing.Size(133, 49);
            this.crew_mate_2.TabIndex = 4;
            this.crew_mate_2.Text = "Crew Mate 2";
            this.crew_mate_2.UseVisualStyleBackColor = true;
            this.crew_mate_2.Click += new System.EventHandler(this.crew_mate_2_Click);
            // 
            // crew_mate_3
            // 
            this.crew_mate_3.Location = new System.Drawing.Point(585, 327);
            this.crew_mate_3.Name = "crew_mate_3";
            this.crew_mate_3.Size = new System.Drawing.Size(133, 49);
            this.crew_mate_3.TabIndex = 5;
            this.crew_mate_3.Text = "Crew Mate 3";
            this.crew_mate_3.UseVisualStyleBackColor = true;
            this.crew_mate_3.Click += new System.EventHandler(this.crew_mate_3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(232, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Who is the imposta ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sus points :";
            // 
            // susPoints
            // 
            this.susPoints.AutoSize = true;
            this.susPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.susPoints.Location = new System.Drawing.Point(439, 414);
            this.susPoints.Name = "susPoints";
            this.susPoints.Size = new System.Drawing.Size(23, 25);
            this.susPoints.TabIndex = 9;
            this.susPoints.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.susPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crew_mate_3);
            this.Controls.Add(this.crew_mate_2);
            this.Controls.Add(this.crew_mate_1);
            this.Controls.Add(this.cm_3);
            this.Controls.Add(this.cm_2);
            this.Controls.Add(this.cm_1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Imposta";
            ((System.ComponentModel.ISupportInitialize)(this.cm_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cm_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cm_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cm_1;
        private System.Windows.Forms.PictureBox cm_2;
        private System.Windows.Forms.PictureBox cm_3;
        private System.Windows.Forms.Button crew_mate_1;
        private System.Windows.Forms.Button crew_mate_2;
        private System.Windows.Forms.Button crew_mate_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label susPoints;
    }
}


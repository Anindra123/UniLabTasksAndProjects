
namespace WinFormUI
{
    partial class NewGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.firstPlayerName = new System.Windows.Forms.TextBox();
            this.secondPlayerName = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.8F);
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter player 1 name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.8F);
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter player 2 name :";
            // 
            // firstPlayerName
            // 
            this.firstPlayerName.Location = new System.Drawing.Point(233, 89);
            this.firstPlayerName.Name = "firstPlayerName";
            this.firstPlayerName.Size = new System.Drawing.Size(255, 22);
            this.firstPlayerName.TabIndex = 2;
            // 
            // secondPlayerName
            // 
            this.secondPlayerName.Location = new System.Drawing.Point(233, 134);
            this.secondPlayerName.Name = "secondPlayerName";
            this.secondPlayerName.Size = new System.Drawing.Size(255, 22);
            this.secondPlayerName.TabIndex = 3;
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(188, 291);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(128, 54);
            this.StartGame.TabIndex = 4;
            this.StartGame.Text = "Play";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(174, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 1 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(267, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(267, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "O";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(174, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Player 2 : ";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.secondPlayerName);
            this.Controls.Add(this.firstPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstPlayerName;
        private System.Windows.Forms.TextBox secondPlayerName;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

namespace Week10LabTask
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // passwordMTextBox
            // 
            this.passwordMTextBox.Location = new System.Drawing.Point(174, 153);
            this.passwordMTextBox.Name = "passwordMTextBox";
            this.passwordMTextBox.PasswordChar = '*';
            this.passwordMTextBox.Size = new System.Drawing.Size(342, 22);
            this.passwordMTextBox.TabIndex = 2;
            this.passwordMTextBox.Leave += new System.EventHandler(this.passwordMTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(174, 106);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(342, 22);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(174, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(342, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(131, 211);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 60);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(376, 211);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 60);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // emailError
            // 
            this.emailError.ContainerControl = this;
            // 
            // passwordError
            // 
            this.passwordError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 298);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordMTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox passwordMTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider emailError;
        private System.Windows.Forms.ErrorProvider passwordError;
    }
}


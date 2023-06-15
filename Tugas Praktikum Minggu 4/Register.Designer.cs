namespace Tugas_Praktikum_Minggu_4
{
    partial class Register
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblSPassword = new System.Windows.Forms.Label();
            this.lblSUsername = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.tbCPassword = new System.Windows.Forms.TextBox();
            this.lblSConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(338, 209);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(218, 22);
            this.tbPassword.TabIndex = 9;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(338, 162);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(218, 22);
            this.tbUsername.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(338, 302);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(168, 70);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Submit";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblSPassword
            // 
            this.lblSPassword.AutoSize = true;
            this.lblSPassword.Location = new System.Drawing.Point(245, 212);
            this.lblSPassword.Name = "lblSPassword";
            this.lblSPassword.Size = new System.Drawing.Size(77, 17);
            this.lblSPassword.TabIndex = 6;
            this.lblSPassword.Text = "Password :";
            // 
            // lblSUsername
            // 
            this.lblSUsername.AutoSize = true;
            this.lblSUsername.Location = new System.Drawing.Point(245, 165);
            this.lblSUsername.Name = "lblSUsername";
            this.lblSUsername.Size = new System.Drawing.Size(81, 17);
            this.lblSUsername.TabIndex = 7;
            this.lblSUsername.Text = "Username :";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(280, 78);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(277, 55);
            this.lblJudul.TabIndex = 5;
            this.lblJudul.Text = "REGISTER";
            // 
            // tbCPassword
            // 
            this.tbCPassword.Location = new System.Drawing.Point(338, 253);
            this.tbCPassword.Name = "tbCPassword";
            this.tbCPassword.Size = new System.Drawing.Size(218, 22);
            this.tbCPassword.TabIndex = 12;
            // 
            // lblSConfirmPassword
            // 
            this.lblSConfirmPassword.AutoSize = true;
            this.lblSConfirmPassword.Location = new System.Drawing.Point(193, 256);
            this.lblSConfirmPassword.Name = "lblSConfirmPassword";
            this.lblSConfirmPassword.Size = new System.Drawing.Size(129, 17);
            this.lblSConfirmPassword.TabIndex = 11;
            this.lblSConfirmPassword.Text = "Confirm Password :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCPassword);
            this.Controls.Add(this.lblSConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblSPassword);
            this.Controls.Add(this.lblSUsername);
            this.Controls.Add(this.lblJudul);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblSPassword;
        private System.Windows.Forms.Label lblSUsername;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox tbCPassword;
        private System.Windows.Forms.Label lblSConfirmPassword;
    }
}
namespace Tugas_Praktikum_Minggu_4
{
    partial class History
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSKode = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lbKode = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(173, 55);
            this.lblJudul.TabIndex = 5;
            this.lblJudul.Text = "History";
            // 
            // lblSKode
            // 
            this.lblSKode.AutoSize = true;
            this.lblSKode.Location = new System.Drawing.Point(19, 92);
            this.lblSKode.Name = "lblSKode";
            this.lblSKode.Size = new System.Drawing.Size(49, 17);
            this.lblSKode.TabIndex = 9;
            this.lblSKode.Text = "Kode :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(143, 399);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 32);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(16, 399);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(121, 32);
            this.lblSTotal.TabIndex = 11;
            this.lblSTotal.Text = "TOTAL :";
            // 
            // lbKode
            // 
            this.lbKode.FormattingEnabled = true;
            this.lbKode.ItemHeight = 16;
            this.lbKode.Location = new System.Drawing.Point(74, 92);
            this.lbKode.Name = "lbKode";
            this.lbKode.Size = new System.Drawing.Size(149, 180);
            this.lbKode.TabIndex = 12;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(74, 291);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(149, 40);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbKode);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.lblSKode);
            this.Controls.Add(this.lblJudul);
            this.Name = "History";
            this.Text = "History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.History_FormClosing);
            this.Load += new System.EventHandler(this.History_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.History_Paint);
            this.Move += new System.EventHandler(this.History_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSKode;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.ListBox lbKode;
        private System.Windows.Forms.Button btnShow;
    }
}
namespace Tugas_Praktikum_Minggu_4
{
    partial class Beli_Stock
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
            this.lblNPizza = new System.Windows.Forms.Label();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.lblJPizza = new System.Windows.Forms.Label();
            this.nudPizza = new System.Windows.Forms.NumericUpDown();
            this.nudMeat = new System.Windows.Forms.NumericUpDown();
            this.lblJMeat = new System.Windows.Forms.Label();
            this.cbMeat = new System.Windows.Forms.ComboBox();
            this.lblNMeat = new System.Windows.Forms.Label();
            this.nudTopping = new System.Windows.Forms.NumericUpDown();
            this.lblJTopping = new System.Windows.Forms.Label();
            this.cbTopping = new System.Windows.Forms.ComboBox();
            this.lblNTopping = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopping)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(267, 45);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(246, 55);
            this.lblJudul.TabIndex = 2;
            this.lblJudul.Text = "Beli Stock";
            // 
            // lblNPizza
            // 
            this.lblNPizza.AutoSize = true;
            this.lblNPizza.Location = new System.Drawing.Point(175, 139);
            this.lblNPizza.Name = "lblNPizza";
            this.lblNPizza.Size = new System.Drawing.Size(86, 17);
            this.lblNPizza.TabIndex = 5;
            this.lblNPizza.Text = "Base Pizza :";
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Items.AddRange(new object[] {
            "Plain Pizza - Rp. 30.000",
            "Black Pizza - Rp. 40.000"});
            this.cbPizza.Location = new System.Drawing.Point(277, 136);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(236, 24);
            this.cbPizza.TabIndex = 6;
            // 
            // lblJPizza
            // 
            this.lblJPizza.AutoSize = true;
            this.lblJPizza.Location = new System.Drawing.Point(175, 180);
            this.lblJPizza.Name = "lblJPizza";
            this.lblJPizza.Size = new System.Drawing.Size(61, 17);
            this.lblJPizza.TabIndex = 7;
            this.lblJPizza.Text = "Jumlah :";
            // 
            // nudPizza
            // 
            this.nudPizza.Location = new System.Drawing.Point(277, 178);
            this.nudPizza.Name = "nudPizza";
            this.nudPizza.Size = new System.Drawing.Size(236, 22);
            this.nudPizza.TabIndex = 8;
            // 
            // nudMeat
            // 
            this.nudMeat.Location = new System.Drawing.Point(277, 267);
            this.nudMeat.Name = "nudMeat";
            this.nudMeat.Size = new System.Drawing.Size(236, 22);
            this.nudMeat.TabIndex = 12;
            // 
            // lblJMeat
            // 
            this.lblJMeat.AutoSize = true;
            this.lblJMeat.Location = new System.Drawing.Point(175, 269);
            this.lblJMeat.Name = "lblJMeat";
            this.lblJMeat.Size = new System.Drawing.Size(61, 17);
            this.lblJMeat.TabIndex = 11;
            this.lblJMeat.Text = "Jumlah :";
            // 
            // cbMeat
            // 
            this.cbMeat.FormattingEnabled = true;
            this.cbMeat.Items.AddRange(new object[] {
            "Beef - Rp. 25.000",
            "Chicken - Rp. 15.000",
            "Shrimp - Rp. 20.000"});
            this.cbMeat.Location = new System.Drawing.Point(277, 225);
            this.cbMeat.Name = "cbMeat";
            this.cbMeat.Size = new System.Drawing.Size(236, 24);
            this.cbMeat.TabIndex = 10;
            // 
            // lblNMeat
            // 
            this.lblNMeat.AutoSize = true;
            this.lblNMeat.Location = new System.Drawing.Point(175, 228);
            this.lblNMeat.Name = "lblNMeat";
            this.lblNMeat.Size = new System.Drawing.Size(47, 17);
            this.lblNMeat.TabIndex = 9;
            this.lblNMeat.Text = "Meat :";
            // 
            // nudTopping
            // 
            this.nudTopping.Location = new System.Drawing.Point(277, 352);
            this.nudTopping.Name = "nudTopping";
            this.nudTopping.Size = new System.Drawing.Size(236, 22);
            this.nudTopping.TabIndex = 16;
            // 
            // lblJTopping
            // 
            this.lblJTopping.AutoSize = true;
            this.lblJTopping.Location = new System.Drawing.Point(175, 354);
            this.lblJTopping.Name = "lblJTopping";
            this.lblJTopping.Size = new System.Drawing.Size(61, 17);
            this.lblJTopping.TabIndex = 15;
            this.lblJTopping.Text = "Jumlah :";
            // 
            // cbTopping
            // 
            this.cbTopping.FormattingEnabled = true;
            this.cbTopping.Items.AddRange(new object[] {
            "Pepper - Rp. 5.000",
            "Mushroom - Rp. 7.500",
            "Tomatoes - Rp. 12.500",
            "Pineapple - Rp. 10.000"});
            this.cbTopping.Location = new System.Drawing.Point(277, 310);
            this.cbTopping.Name = "cbTopping";
            this.cbTopping.Size = new System.Drawing.Size(236, 24);
            this.cbTopping.TabIndex = 14;
            // 
            // lblNTopping
            // 
            this.lblNTopping.AutoSize = true;
            this.lblNTopping.Location = new System.Drawing.Point(175, 313);
            this.lblNTopping.Name = "lblNTopping";
            this.lblNTopping.Size = new System.Drawing.Size(86, 17);
            this.lblNTopping.TabIndex = 13;
            this.lblNTopping.Text = "Base Pizza :";
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(277, 392);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(114, 59);
            this.btnBuy.TabIndex = 17;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Beli_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 463);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.nudTopping);
            this.Controls.Add(this.lblJTopping);
            this.Controls.Add(this.cbTopping);
            this.Controls.Add(this.lblNTopping);
            this.Controls.Add(this.nudMeat);
            this.Controls.Add(this.lblJMeat);
            this.Controls.Add(this.cbMeat);
            this.Controls.Add(this.lblNMeat);
            this.Controls.Add(this.nudPizza);
            this.Controls.Add(this.lblJPizza);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.lblNPizza);
            this.Controls.Add(this.lblJudul);
            this.Name = "Beli_Stock";
            this.Text = "Beli_Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Beli_Stock_FormClosing);
            this.Move += new System.EventHandler(this.Beli_Stock_Move);
            ((System.ComponentModel.ISupportInitialize)(this.nudPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNPizza;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.Label lblJPizza;
        private System.Windows.Forms.NumericUpDown nudPizza;
        private System.Windows.Forms.NumericUpDown nudMeat;
        private System.Windows.Forms.Label lblJMeat;
        private System.Windows.Forms.ComboBox cbMeat;
        private System.Windows.Forms.Label lblNMeat;
        private System.Windows.Forms.NumericUpDown nudTopping;
        private System.Windows.Forms.Label lblJTopping;
        private System.Windows.Forms.ComboBox cbTopping;
        private System.Windows.Forms.Label lblNTopping;
        private System.Windows.Forms.Button btnBuy;
    }
}
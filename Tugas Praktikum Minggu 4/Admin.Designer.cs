namespace Tugas_Praktikum_Minggu_4
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beliStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSMoney = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beliStokToolStripMenuItem,
            this.lihatStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // beliStokToolStripMenuItem
            // 
            this.beliStokToolStripMenuItem.Name = "beliStokToolStripMenuItem";
            this.beliStokToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.beliStokToolStripMenuItem.Text = "Beli Stock";
            this.beliStokToolStripMenuItem.Click += new System.EventHandler(this.beliStokToolStripMenuItem_Click);
            // 
            // lihatStockToolStripMenuItem
            // 
            this.lihatStockToolStripMenuItem.Name = "lihatStockToolStripMenuItem";
            this.lihatStockToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.lihatStockToolStripMenuItem.Text = "Lihat Stock";
            this.lihatStockToolStripMenuItem.Click += new System.EventHandler(this.lihatStockToolStripMenuItem_Click);
            // 
            // lblSMoney
            // 
            this.lblSMoney.AutoSize = true;
            this.lblSMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblSMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMoney.Location = new System.Drawing.Point(13, 44);
            this.lblSMoney.Name = "lblSMoney";
            this.lblSMoney.Size = new System.Drawing.Size(97, 29);
            this.lblSMoney.TabIndex = 1;
            this.lblSMoney.Text = "Money :";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(130, 44);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(116, 29);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "1.000.000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblSMoney);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beliStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatStockToolStripMenuItem;
        public System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.Label lblSMoney;
        private System.Windows.Forms.Timer timer1;
    }
}
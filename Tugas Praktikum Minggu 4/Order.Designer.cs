namespace Tugas_Praktikum_Minggu_4
{
    partial class Order
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
            this.lblKode = new System.Windows.Forms.Label();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.lblMeat = new System.Windows.Forms.Label();
            this.cbMeat = new System.Windows.Forms.ComboBox();
            this.lblTopping = new System.Windows.Forms.Label();
            this.chbPepper = new System.Windows.Forms.CheckBox();
            this.chbMushroom = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbPineapple = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(277, 55);
            this.lblJudul.TabIndex = 4;
            this.lblJudul.Text = "Order Pizza";
            // 
            // lblSKode
            // 
            this.lblSKode.AutoSize = true;
            this.lblSKode.Location = new System.Drawing.Point(19, 92);
            this.lblSKode.Name = "lblSKode";
            this.lblSKode.Size = new System.Drawing.Size(49, 17);
            this.lblSKode.TabIndex = 8;
            this.lblSKode.Text = "Kode :";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(120, 92);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(71, 17);
            this.lblKode.TabIndex = 8;
            this.lblKode.Text = "PIZZA001";
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Items.AddRange(new object[] {
            "Base Pizza",
            "Meat",
            "Topping"});
            this.cbPizza.Location = new System.Drawing.Point(123, 122);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(236, 24);
            this.cbPizza.TabIndex = 10;
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(19, 125);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(86, 17);
            this.lblPizza.TabIndex = 9;
            this.lblPizza.Text = "Base Pizza :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(19, 165);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 17);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size :";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(123, 165);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(63, 21);
            this.rbSmall.TabIndex = 11;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(123, 198);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(78, 21);
            this.rbMedium.TabIndex = 11;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(123, 233);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(66, 21);
            this.rbLarge.TabIndex = 11;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // lblMeat
            // 
            this.lblMeat.AutoSize = true;
            this.lblMeat.Location = new System.Drawing.Point(19, 274);
            this.lblMeat.Name = "lblMeat";
            this.lblMeat.Size = new System.Drawing.Size(47, 17);
            this.lblMeat.TabIndex = 9;
            this.lblMeat.Text = "Meat :";
            // 
            // cbMeat
            // 
            this.cbMeat.FormattingEnabled = true;
            this.cbMeat.Items.AddRange(new object[] {
            "Base Pizza",
            "Meat",
            "Topping"});
            this.cbMeat.Location = new System.Drawing.Point(123, 271);
            this.cbMeat.Name = "cbMeat";
            this.cbMeat.Size = new System.Drawing.Size(236, 24);
            this.cbMeat.TabIndex = 10;
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Location = new System.Drawing.Point(19, 314);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(68, 17);
            this.lblTopping.TabIndex = 9;
            this.lblTopping.Text = "Topping :";
            // 
            // chbPepper
            // 
            this.chbPepper.AutoSize = true;
            this.chbPepper.Location = new System.Drawing.Point(123, 313);
            this.chbPepper.Name = "chbPepper";
            this.chbPepper.Size = new System.Drawing.Size(85, 21);
            this.chbPepper.TabIndex = 12;
            this.chbPepper.Text = "Pepper -";
            this.chbPepper.UseVisualStyleBackColor = true;
            this.chbPepper.CheckedChanged += new System.EventHandler(this.chbPepper_CheckedChanged);
            // 
            // chbMushroom
            // 
            this.chbMushroom.AutoSize = true;
            this.chbMushroom.Location = new System.Drawing.Point(123, 343);
            this.chbMushroom.Name = "chbMushroom";
            this.chbMushroom.Size = new System.Drawing.Size(105, 21);
            this.chbMushroom.TabIndex = 12;
            this.chbMushroom.Text = "Mushroom -";
            this.chbMushroom.UseVisualStyleBackColor = true;
            this.chbMushroom.CheckedChanged += new System.EventHandler(this.chbMushroom_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Location = new System.Drawing.Point(123, 373);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(102, 21);
            this.chbTomatoes.TabIndex = 12;
            this.chbTomatoes.Text = "Tomatoes -";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbPineapple
            // 
            this.chbPineapple.AutoSize = true;
            this.chbPineapple.Location = new System.Drawing.Point(123, 403);
            this.chbPineapple.Name = "chbPineapple";
            this.chbPineapple.Size = new System.Drawing.Size(102, 21);
            this.chbPineapple.TabIndex = 12;
            this.chbPineapple.Text = "Pineapple -";
            this.chbPineapple.UseVisualStyleBackColor = true;
            this.chbPineapple.CheckedChanged += new System.EventHandler(this.chbPineapple_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(123, 451);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(131, 55);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(19, 550);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(121, 32);
            this.lblSTotal.TabIndex = 9;
            this.lblSTotal.Text = "TOTAL :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(146, 550);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 32);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chbPineapple);
            this.Controls.Add(this.chbTomatoes);
            this.Controls.Add(this.chbMushroom);
            this.Controls.Add(this.chbPepper);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.cbMeat);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.lblMeat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.lblSKode);
            this.Controls.Add(this.lblJudul);
            this.Name = "Order";
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.Load += new System.EventHandler(this.Order_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Order_Paint);
            this.Move += new System.EventHandler(this.Order_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSKode;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.ComboBox cbMeat;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.CheckBox chbPepper;
        private System.Windows.Forms.CheckBox chbMushroom;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbPineapple;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}
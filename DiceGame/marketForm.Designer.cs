namespace DiceGame
{
    partial class marketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marketForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.lblWeapons = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstbxWeapons = new System.Windows.Forms.ListBox();
            this.tabArmory = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabWeapons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWeapons);
            this.tabControl1.Controls.Add(this.tabArmory);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabWeapons
            // 
            this.tabWeapons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabWeapons.BackgroundImage")));
            this.tabWeapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabWeapons.Controls.Add(this.lblWeapons);
            this.tabWeapons.Controls.Add(this.lblGold);
            this.tabWeapons.Controls.Add(this.lblSpecial);
            this.tabWeapons.Controls.Add(this.lblPrice);
            this.tabWeapons.Controls.Add(this.lblDamage);
            this.tabWeapons.Controls.Add(this.btnExit1);
            this.tabWeapons.Controls.Add(this.btnSell);
            this.tabWeapons.Controls.Add(this.btnBuy);
            this.tabWeapons.Controls.Add(this.lstbxWeapons);
            this.tabWeapons.Location = new System.Drawing.Point(4, 22);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(556, 432);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons";
            this.tabWeapons.UseVisualStyleBackColor = true;
            this.tabWeapons.Click += new System.EventHandler(this.tabWeapons_Click);
            // 
            // lblWeapons
            // 
            this.lblWeapons.AutoSize = true;
            this.lblWeapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapons.ForeColor = System.Drawing.SystemColors.Info;
            this.lblWeapons.Location = new System.Drawing.Point(202, 3);
            this.lblWeapons.Name = "lblWeapons";
            this.lblWeapons.Size = new System.Drawing.Size(170, 39);
            this.lblWeapons.TabIndex = 8;
            this.lblWeapons.Text = "Weapons";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.ForeColor = System.Drawing.SystemColors.Info;
            this.lblGold.Location = new System.Drawing.Point(353, 356);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(122, 25);
            this.lblGold.TabIndex = 7;
            this.lblGold.Text = "You Have:";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSpecial.Location = new System.Drawing.Point(41, 171);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(97, 25);
            this.lblSpecial.TabIndex = 6;
            this.lblSpecial.Text = "Special:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrice.Location = new System.Drawing.Point(41, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDamage.Location = new System.Drawing.Point(41, 82);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(105, 25);
            this.lblDamage.TabIndex = 4;
            this.lblDamage.Text = "Damage:";
            // 
            // btnExit1
            // 
            this.btnExit1.Location = new System.Drawing.Point(475, 402);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(75, 23);
            this.btnExit1.TabIndex = 3;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Linen;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(209, 324);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(82, 43);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Linen;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuy.Location = new System.Drawing.Point(45, 324);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(82, 43);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // lstbxWeapons
            // 
            this.lstbxWeapons.BackColor = System.Drawing.Color.Linen;
            this.lstbxWeapons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxWeapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxWeapons.FormattingEnabled = true;
            this.lstbxWeapons.ItemHeight = 20;
            this.lstbxWeapons.Items.AddRange(new object[] {
            "Sword",
            "Shortsword",
            "Club",
            "Staff",
            "Dagger",
            "Buckler",
            "Shield",
            "Kite Shield",
            "Bracers of Swiftness"});
            this.lstbxWeapons.Location = new System.Drawing.Point(348, 64);
            this.lstbxWeapons.Name = "lstbxWeapons";
            this.lstbxWeapons.Size = new System.Drawing.Size(202, 280);
            this.lstbxWeapons.TabIndex = 0;
            // 
            // tabArmory
            // 
            this.tabArmory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabArmory.BackgroundImage")));
            this.tabArmory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabArmory.Location = new System.Drawing.Point(4, 22);
            this.tabArmory.Name = "tabArmory";
            this.tabArmory.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmory.Size = new System.Drawing.Size(556, 432);
            this.tabArmory.TabIndex = 1;
            this.tabArmory.Text = "Armory";
            this.tabArmory.UseVisualStyleBackColor = true;
            // 
            // marketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "marketForm";
            this.Text = "marketForm";
            this.Load += new System.EventHandler(this.marketForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabWeapons.ResumeLayout(false);
            this.tabWeapons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.TabPage tabArmory;
        private System.Windows.Forms.Label lblWeapons;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lstbxWeapons;
    }
}
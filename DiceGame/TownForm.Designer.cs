namespace DiceGame
{
    partial class TownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TownForm));
            this.lblMarket = new System.Windows.Forms.Label();
            this.pnlFight = new System.Windows.Forms.Panel();
            this.lblFight = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.pnlMarket = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVerdict = new System.Windows.Forms.Label();
            this.pnlFight.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlMarket.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarket
            // 
            this.lblMarket.AutoSize = true;
            this.lblMarket.BackColor = System.Drawing.Color.Transparent;
            this.lblMarket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMarket.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarket.ForeColor = System.Drawing.Color.White;
            this.lblMarket.Location = new System.Drawing.Point(1, 78);
            this.lblMarket.Name = "lblMarket";
            this.lblMarket.Size = new System.Drawing.Size(179, 57);
            this.lblMarket.TabIndex = 0;
            this.lblMarket.Text = "Market";
            // 
            // pnlFight
            // 
            this.pnlFight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFight.BackgroundImage")));
            this.pnlFight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFight.Controls.Add(this.lblFight);
            this.pnlFight.Location = new System.Drawing.Point(394, 230);
            this.pnlFight.Name = "pnlFight";
            this.pnlFight.Size = new System.Drawing.Size(182, 202);
            this.pnlFight.TabIndex = 5;
            this.pnlFight.Click += new System.EventHandler(this.pnlFight_Click);
            this.pnlFight.MouseLeave += new System.EventHandler(this.pnlFight_MouseLeave);
            this.pnlFight.MouseHover += new System.EventHandler(this.pnFight_MouseHover);
            // 
            // lblFight
            // 
            this.lblFight.AutoSize = true;
            this.lblFight.BackColor = System.Drawing.Color.Transparent;
            this.lblFight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFight.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFight.ForeColor = System.Drawing.Color.White;
            this.lblFight.Location = new System.Drawing.Point(23, 78);
            this.lblFight.Name = "lblFight";
            this.lblFight.Size = new System.Drawing.Size(136, 57);
            this.lblFight.TabIndex = 2;
            this.lblFight.Text = "Fight";
            // 
            // pnlStats
            // 
            this.pnlStats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStats.BackgroundImage")));
            this.pnlStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.Add(this.lblStats);
            this.pnlStats.Location = new System.Drawing.Point(203, 230);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(185, 202);
            this.pnlStats.TabIndex = 6;
            this.pnlStats.Click += new System.EventHandler(this.pnlStats_Click);
            this.pnlStats.MouseLeave += new System.EventHandler(this.pnlStats_MouseLeave);
            this.pnlStats.MouseHover += new System.EventHandler(this.pnlStats_MouseHover);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStats.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.Color.White;
            this.lblStats.Location = new System.Drawing.Point(30, 78);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(129, 57);
            this.lblStats.TabIndex = 1;
            this.lblStats.Text = "Stats";
            // 
            // pnlMarket
            // 
            this.pnlMarket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMarket.BackgroundImage")));
            this.pnlMarket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMarket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarket.Controls.Add(this.lblMarket);
            this.pnlMarket.Location = new System.Drawing.Point(12, 230);
            this.pnlMarket.Name = "pnlMarket";
            this.pnlMarket.Size = new System.Drawing.Size(185, 202);
            this.pnlMarket.TabIndex = 4;
            this.pnlMarket.Click += new System.EventHandler(this.pnlMarket_Click);
            this.pnlMarket.MouseLeave += new System.EventHandler(this.pnlMarket_MouseLeave);
            this.pnlMarket.MouseHover += new System.EventHandler(this.pnlMarket_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblVerdict);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 212);
            this.panel1.TabIndex = 3;
            // 
            // lblVerdict
            // 
            this.lblVerdict.BackColor = System.Drawing.Color.Transparent;
            this.lblVerdict.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVerdict.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerdict.ForeColor = System.Drawing.Color.White;
            this.lblVerdict.Location = new System.Drawing.Point(197, 0);
            this.lblVerdict.Name = "lblVerdict";
            this.lblVerdict.Size = new System.Drawing.Size(179, 57);
            this.lblVerdict.TabIndex = 1;
            this.lblVerdict.Text = "-";
            this.lblVerdict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(588, 444);
            this.Controls.Add(this.pnlFight);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlMarket);
            this.Controls.Add(this.panel1);
            this.Name = "TownForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Town";
            this.pnlFight.ResumeLayout(false);
            this.pnlFight.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlMarket.ResumeLayout(false);
            this.pnlMarket.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarket;
        private System.Windows.Forms.Panel pnlFight;
        private System.Windows.Forms.Label lblFight;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Panel pnlMarket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVerdict;
    }
}
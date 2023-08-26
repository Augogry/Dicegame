namespace DiceGame
{
    partial class DiceGameLaunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceGameLaunch));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOneP = new System.Windows.Forms.Button();
            this.btnTwoP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Dice Game!";
            // 
            // btnOneP
            // 
            this.btnOneP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOneP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOneP.Location = new System.Drawing.Point(123, 121);
            this.btnOneP.Name = "btnOneP";
            this.btnOneP.Size = new System.Drawing.Size(162, 62);
            this.btnOneP.TabIndex = 3;
            this.btnOneP.Text = "One Player";
            this.btnOneP.UseVisualStyleBackColor = true;
            this.btnOneP.Click += new System.EventHandler(this.btnOneP_Click);
            // 
            // btnTwoP
            // 
            this.btnTwoP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTwoP.Location = new System.Drawing.Point(123, 218);
            this.btnTwoP.Name = "btnTwoP";
            this.btnTwoP.Size = new System.Drawing.Size(162, 62);
            this.btnTwoP.TabIndex = 5;
            this.btnTwoP.Text = "Two Players";
            this.btnTwoP.UseVisualStyleBackColor = true;
            this.btnTwoP.Click += new System.EventHandler(this.btnTwoP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Simulacrum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiceGameLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTwoP);
            this.Controls.Add(this.btnOneP);
            this.Controls.Add(this.label1);
            this.Name = "DiceGameLaunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.DiceGameLaunch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOneP;
        private System.Windows.Forms.Button btnTwoP;
        private System.Windows.Forms.Button button1;
    }
}
namespace DiceGame
{
    partial class inputNameForm
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
            this.txtbxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtbxPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.cmbxDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxItems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is Your Name?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(128, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1:";
            // 
            // txtbxPlayer1
            // 
            this.txtbxPlayer1.Location = new System.Drawing.Point(216, 119);
            this.txtbxPlayer1.Name = "txtbxPlayer1";
            this.txtbxPlayer1.Size = new System.Drawing.Size(146, 20);
            this.txtbxPlayer1.TabIndex = 2;
            // 
            // txtbxPlayer2
            // 
            this.txtbxPlayer2.Location = new System.Drawing.Point(216, 155);
            this.txtbxPlayer2.Name = "txtbxPlayer2";
            this.txtbxPlayer2.Size = new System.Drawing.Size(146, 20);
            this.txtbxPlayer2.TabIndex = 4;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer2.Location = new System.Drawing.Point(128, 151);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(82, 24);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // btnLaunch
            // 
            this.btnLaunch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLaunch.Location = new System.Drawing.Point(192, 251);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(115, 39);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // cmbxDifficulty
            // 
            this.cmbxDifficulty.FormattingEnabled = true;
            this.cmbxDifficulty.Items.AddRange(new object[] {
            "Beginner",
            "Easy",
            "Medium",
            "Advanced",
            "Difficult"});
            this.cmbxDifficulty.Location = new System.Drawing.Point(216, 154);
            this.cmbxDifficulty.Name = "cmbxDifficulty";
            this.cmbxDifficulty.Size = new System.Drawing.Size(146, 21);
            this.cmbxDifficulty.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(64, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Starter Weapon:";
            // 
            // cmbxItems
            // 
            this.cmbxItems.FormattingEnabled = true;
            this.cmbxItems.Items.AddRange(new object[] {
            "Dagger",
            "Shortsword",
            "Staff",
            "Club"});
            this.cmbxItems.Location = new System.Drawing.Point(272, 196);
            this.cmbxItems.Name = "cmbxItems";
            this.cmbxItems.Size = new System.Drawing.Size(146, 21);
            this.cmbxItems.TabIndex = 8;
            // 
            // inputNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 302);
            this.Controls.Add(this.cmbxItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxDifficulty);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.txtbxPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtbxPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "inputNameForm";
            this.Text = "What is Your Name?";
            this.Load += new System.EventHandler(this.inputNameForm_Load);
            this.Enter += new System.EventHandler(this.btnLaunch_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxPlayer1;
        private System.Windows.Forms.TextBox txtbxPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox cmbxDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxItems;
    }
}
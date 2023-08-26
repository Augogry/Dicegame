namespace DiceGame
{
    partial class SparForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxCharacter = new System.Windows.Forms.PictureBox();
            this.lblp1Roll = new System.Windows.Forms.Label();
            this.cRoll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxEnemy = new System.Windows.Forms.PictureBox();
            this.lblp2Roll = new System.Windows.Forms.Label();
            this.eRoll = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblHit = new System.Windows.Forms.Label();
            this.tmrAction = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCharacter)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBoxCharacter);
            this.panel1.Controls.Add(this.lblp1Roll);
            this.panel1.Controls.Add(this.cRoll);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 280);
            this.panel1.TabIndex = 0;
            // 
            // picBoxCharacter
            // 
            this.picBoxCharacter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxCharacter.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCharacter.Image")));
            this.picBoxCharacter.Location = new System.Drawing.Point(39, 37);
            this.picBoxCharacter.Name = "picBoxCharacter";
            this.picBoxCharacter.Size = new System.Drawing.Size(200, 169);
            this.picBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCharacter.TabIndex = 7;
            this.picBoxCharacter.TabStop = false;
            // 
            // lblp1Roll
            // 
            this.lblp1Roll.AutoSize = true;
            this.lblp1Roll.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1Roll.Location = new System.Drawing.Point(34, 231);
            this.lblp1Roll.Name = "lblp1Roll";
            this.lblp1Roll.Size = new System.Drawing.Size(89, 26);
            this.lblp1Roll.TabIndex = 6;
            this.lblp1Roll.Text = " Rolled:";
            this.lblp1Roll.Visible = false;
            // 
            // cRoll
            // 
            this.cRoll.BackColor = System.Drawing.Color.White;
            this.cRoll.Enabled = false;
            this.cRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cRoll.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cRoll.Location = new System.Drawing.Point(148, 224);
            this.cRoll.Name = "cRoll";
            this.cRoll.Size = new System.Drawing.Size(48, 45);
            this.cRoll.TabIndex = 5;
            this.cRoll.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picBoxEnemy);
            this.panel2.Controls.Add(this.lblp2Roll);
            this.panel2.Controls.Add(this.eRoll);
            this.panel2.Location = new System.Drawing.Point(298, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 280);
            this.panel2.TabIndex = 1;
            // 
            // picBoxEnemy
            // 
            this.picBoxEnemy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxEnemy.Location = new System.Drawing.Point(39, 37);
            this.picBoxEnemy.Name = "picBoxEnemy";
            this.picBoxEnemy.Size = new System.Drawing.Size(200, 169);
            this.picBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEnemy.TabIndex = 8;
            this.picBoxEnemy.TabStop = false;
            // 
            // lblp2Roll
            // 
            this.lblp2Roll.AutoSize = true;
            this.lblp2Roll.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2Roll.Location = new System.Drawing.Point(34, 231);
            this.lblp2Roll.Name = "lblp2Roll";
            this.lblp2Roll.Size = new System.Drawing.Size(89, 26);
            this.lblp2Roll.TabIndex = 7;
            this.lblp2Roll.Text = " Rolled:";
            this.lblp2Roll.Visible = false;
            // 
            // eRoll
            // 
            this.eRoll.BackColor = System.Drawing.Color.White;
            this.eRoll.Enabled = false;
            this.eRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eRoll.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eRoll.Location = new System.Drawing.Point(156, 224);
            this.eRoll.Name = "eRoll";
            this.eRoll.Size = new System.Drawing.Size(48, 45);
            this.eRoll.TabIndex = 6;
            this.eRoll.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(245, 344);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 38);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblHit
            // 
            this.lblHit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.Location = new System.Drawing.Point(65, 310);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(461, 23);
            this.lblHit.TabIndex = 3;
            this.lblHit.Text = "-";
            this.lblHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrAction
            // 
            this.tmrAction.Enabled = true;
            this.tmrAction.Interval = 32;
            this.tmrAction.Tick += new System.EventHandler(this.tmrAction_Tick);
            // 
            // SparForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 394);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SparForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spar";
            this.Load += new System.EventHandler(this.SparForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCharacter)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblp1Roll;
        private System.Windows.Forms.Button cRoll;
        private System.Windows.Forms.Button eRoll;
        private System.Windows.Forms.Label lblp2Roll;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.PictureBox picBoxCharacter;
        private System.Windows.Forms.PictureBox picBoxEnemy;
        private System.Windows.Forms.Timer tmrAction;
    }
}
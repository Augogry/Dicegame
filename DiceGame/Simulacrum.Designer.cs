namespace DiceGame
{
    partial class Simulacrum
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxMaxPoints = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxArrangement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxFaces = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxValues = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxEMaxPoints = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxEFaces = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbtnCustom = new System.Windows.Forms.RadioButton();
            this.rdbtnRandom = new System.Windows.Forms.RadioButton();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.txtbxNumFights = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkbxArranged = new System.Windows.Forms.CheckBox();
            this.chkbxSteps = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkbxShowSteps = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(341, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 48);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(446, 344);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = " Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(277, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 331);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enemy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MaxPoints:";
            // 
            // txtbxMaxPoints
            // 
            this.txtbxMaxPoints.Location = new System.Drawing.Point(124, 96);
            this.txtbxMaxPoints.Name = "txtbxMaxPoints";
            this.txtbxMaxPoints.Size = new System.Drawing.Size(50, 20);
            this.txtbxMaxPoints.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrangement:";
            // 
            // cmbxArrangement
            // 
            this.cmbxArrangement.FormattingEnabled = true;
            this.cmbxArrangement.Items.AddRange(new object[] {
            "Random",
            "Even",
            "Halves",
            "Median+"});
            this.cmbxArrangement.Location = new System.Drawing.Point(124, 141);
            this.cmbxArrangement.Name = "cmbxArrangement";
            this.cmbxArrangement.Size = new System.Drawing.Size(100, 21);
            this.cmbxArrangement.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Schedule:";
            // 
            // cmbxFaces
            // 
            this.cmbxFaces.FormattingEnabled = true;
            this.cmbxFaces.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cmbxFaces.Location = new System.Drawing.Point(184, 188);
            this.cmbxFaces.Name = "cmbxFaces";
            this.cmbxFaces.Size = new System.Drawing.Size(40, 21);
            this.cmbxFaces.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Faces -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Values -";
            // 
            // txtbxValues
            // 
            this.txtbxValues.Location = new System.Drawing.Point(184, 220);
            this.txtbxValues.Name = "txtbxValues";
            this.txtbxValues.Size = new System.Drawing.Size(66, 20);
            this.txtbxValues.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxEMaxPoints);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtbxEFaces);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rdbtnCustom);
            this.groupBox1.Controls.Add(this.rdbtnRandom);
            this.groupBox1.Location = new System.Drawing.Point(305, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 169);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enemy Arrangement";
            // 
            // txtbxEMaxPoints
            // 
            this.txtbxEMaxPoints.Location = new System.Drawing.Point(119, 118);
            this.txtbxEMaxPoints.Name = "txtbxEMaxPoints";
            this.txtbxEMaxPoints.Size = new System.Drawing.Size(50, 20);
            this.txtbxEMaxPoints.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "MaxPoints:";
            // 
            // txtbxEFaces
            // 
            this.txtbxEFaces.Location = new System.Drawing.Point(90, 48);
            this.txtbxEFaces.Name = "txtbxEFaces";
            this.txtbxEFaces.Size = new System.Drawing.Size(79, 20);
            this.txtbxEFaces.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Faces:";
            // 
            // rdbtnCustom
            // 
            this.rdbtnCustom.AutoSize = true;
            this.rdbtnCustom.Location = new System.Drawing.Point(6, 19);
            this.rdbtnCustom.Name = "rdbtnCustom";
            this.rdbtnCustom.Size = new System.Drawing.Size(60, 17);
            this.rdbtnCustom.TabIndex = 1;
            this.rdbtnCustom.TabStop = true;
            this.rdbtnCustom.Text = "Custom";
            this.rdbtnCustom.UseVisualStyleBackColor = true;
            this.rdbtnCustom.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbtnRandom
            // 
            this.rdbtnRandom.AutoSize = true;
            this.rdbtnRandom.Location = new System.Drawing.Point(6, 86);
            this.rdbtnRandom.Name = "rdbtnRandom";
            this.rdbtnRandom.Size = new System.Drawing.Size(65, 17);
            this.rdbtnRandom.TabIndex = 0;
            this.rdbtnRandom.TabStop = true;
            this.rdbtnRandom.Text = "Random";
            this.rdbtnRandom.UseVisualStyleBackColor = true;
            this.rdbtnRandom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtbxNumFights
            // 
            this.txtbxNumFights.Location = new System.Drawing.Point(188, 357);
            this.txtbxNumFights.Name = "txtbxNumFights";
            this.txtbxNumFights.Size = new System.Drawing.Size(90, 20);
            this.txtbxNumFights.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Number of Fights:";
            // 
            // chkbxArranged
            // 
            this.chkbxArranged.AutoSize = true;
            this.chkbxArranged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxArranged.Location = new System.Drawing.Point(112, 258);
            this.chkbxArranged.Name = "chkbxArranged";
            this.chkbxArranged.Size = new System.Drawing.Size(112, 24);
            this.chkbxArranged.TabIndex = 17;
            this.chkbxArranged.Text = "Pre-arrange";
            this.chkbxArranged.UseVisualStyleBackColor = true;
            // 
            // chkbxSteps
            // 
            this.chkbxSteps.AutoSize = true;
            this.chkbxSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSteps.Location = new System.Drawing.Point(111, 288);
            this.chkbxSteps.Name = "chkbxSteps";
            this.chkbxSteps.Size = new System.Drawing.Size(122, 24);
            this.chkbxSteps.TabIndex = 18;
            this.chkbxSteps.Text = "Step By Step";
            this.chkbxSteps.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 19;
            // 
            // chkbxShowSteps
            // 
            this.chkbxShowSteps.AutoSize = true;
            this.chkbxShowSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxShowSteps.Location = new System.Drawing.Point(111, 318);
            this.chkbxShowSteps.Name = "chkbxShowSteps";
            this.chkbxShowSteps.Size = new System.Drawing.Size(114, 24);
            this.chkbxShowSteps.TabIndex = 20;
            this.chkbxShowSteps.Text = "Show Steps";
            this.chkbxShowSteps.UseVisualStyleBackColor = true;
            // 
            // Simulacrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 404);
            this.Controls.Add(this.chkbxShowSteps);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkbxSteps);
            this.Controls.Add(this.chkbxArranged);
            this.Controls.Add(this.txtbxNumFights);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbxValues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxFaces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxArrangement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxMaxPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnReset);
            this.Name = "Simulacrum";
            this.Text = "Simulacrum";
            this.Load += new System.EventHandler(this.Simulacrum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxMaxPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxArrangement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxFaces;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxValues;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxEFaces;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnCustom;
        private System.Windows.Forms.RadioButton rdbtnRandom;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox txtbxEMaxPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxNumFights;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkbxArranged;
        private System.Windows.Forms.CheckBox chkbxSteps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkbxShowSteps;
    }
}
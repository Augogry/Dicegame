namespace DiceGame
{
    partial class OnePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnePlayer));
            this.CharacterPanel = new System.Windows.Forms.Panel();
            this.lblCharHealth = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblCharName = new System.Windows.Forms.Label();
            this.progBarChar = new System.Windows.Forms.ProgressBar();
            this.picBoxCharacter = new System.Windows.Forms.PictureBox();
            this.lblCharTotal = new System.Windows.Forms.Label();
            this.CharacterDicePanel = new System.Windows.Forms.Panel();
            this.cFace6 = new System.Windows.Forms.Button();
            this.cFace5 = new System.Windows.Forms.Button();
            this.cFace4 = new System.Windows.Forms.Button();
            this.cFace3 = new System.Windows.Forms.Button();
            this.cFace1 = new System.Windows.Forms.Button();
            this.cFace2 = new System.Windows.Forms.Button();
            this.EnemyPanel = new System.Windows.Forms.Panel();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.progBarEnemy = new System.Windows.Forms.ProgressBar();
            this.picBoxEnemy = new System.Windows.Forms.PictureBox();
            this.EnemyDicePanel = new System.Windows.Forms.Panel();
            this.eFace6 = new System.Windows.Forms.Button();
            this.eFace5 = new System.Windows.Forms.Button();
            this.eFace4 = new System.Windows.Forms.Button();
            this.eFace3 = new System.Windows.Forms.Button();
            this.eFace1 = new System.Windows.Forms.Button();
            this.eFace2 = new System.Windows.Forms.Button();
            this.lblEnemyTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cSchedule3 = new System.Windows.Forms.Button();
            this.cSchedule1 = new System.Windows.Forms.Button();
            this.cSchedule2 = new System.Windows.Forms.Button();
            this.btnFaces = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.eSchedule3 = new System.Windows.Forms.Button();
            this.eSchedule1 = new System.Windows.Forms.Button();
            this.eSchedule2 = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.toolTipSpecial = new System.Windows.Forms.ToolTip(this.components);
            this.CharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCharacter)).BeginInit();
            this.CharacterDicePanel.SuspendLayout();
            this.EnemyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnemy)).BeginInit();
            this.EnemyDicePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterPanel
            // 
            this.CharacterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterPanel.Controls.Add(this.lblCharHealth);
            this.CharacterPanel.Controls.Add(this.lblCountdown);
            this.CharacterPanel.Controls.Add(this.btnSpecial);
            this.CharacterPanel.Controls.Add(this.lblCharName);
            this.CharacterPanel.Controls.Add(this.progBarChar);
            this.CharacterPanel.Controls.Add(this.picBoxCharacter);
            this.CharacterPanel.Location = new System.Drawing.Point(0, 83);
            this.CharacterPanel.Name = "CharacterPanel";
            this.CharacterPanel.Size = new System.Drawing.Size(402, 292);
            this.CharacterPanel.TabIndex = 0;
            // 
            // lblCharHealth
            // 
            this.lblCharHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblCharHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharHealth.Location = new System.Drawing.Point(101, 217);
            this.lblCharHealth.Name = "lblCharHealth";
            this.lblCharHealth.Size = new System.Drawing.Size(200, 23);
            this.lblCharHealth.TabIndex = 5;
            this.lblCharHealth.Text = "Current/Max";
            this.lblCharHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountdown
            // 
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(12, 107);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(75, 26);
            this.lblCountdown.TabIndex = 4;
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpecial
            // 
            this.btnSpecial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpecial.BackgroundImage")));
            this.btnSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecial.ForeColor = System.Drawing.Color.Black;
            this.btnSpecial.Location = new System.Drawing.Point(12, 42);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(75, 64);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharName.Location = new System.Drawing.Point(152, 14);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(106, 25);
            this.lblCharName.TabIndex = 2;
            this.lblCharName.Text = "Character";
            // 
            // progBarChar
            // 
            this.progBarChar.Location = new System.Drawing.Point(101, 241);
            this.progBarChar.Name = "progBarChar";
            this.progBarChar.Size = new System.Drawing.Size(200, 28);
            this.progBarChar.TabIndex = 1;
            // 
            // picBoxCharacter
            // 
            this.picBoxCharacter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxCharacter.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCharacter.Image")));
            this.picBoxCharacter.Location = new System.Drawing.Point(101, 42);
            this.picBoxCharacter.Name = "picBoxCharacter";
            this.picBoxCharacter.Size = new System.Drawing.Size(200, 169);
            this.picBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCharacter.TabIndex = 0;
            this.picBoxCharacter.TabStop = false;
            // 
            // lblCharTotal
            // 
            this.lblCharTotal.AutoSize = true;
            this.lblCharTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharTotal.Location = new System.Drawing.Point(358, 52);
            this.lblCharTotal.Name = "lblCharTotal";
            this.lblCharTotal.Size = new System.Drawing.Size(44, 20);
            this.lblCharTotal.TabIndex = 12;
            this.lblCharTotal.Text = "Total";
            // 
            // CharacterDicePanel
            // 
            this.CharacterDicePanel.Controls.Add(this.cFace6);
            this.CharacterDicePanel.Controls.Add(this.lblCharTotal);
            this.CharacterDicePanel.Controls.Add(this.cFace5);
            this.CharacterDicePanel.Controls.Add(this.cFace4);
            this.CharacterDicePanel.Controls.Add(this.cFace3);
            this.CharacterDicePanel.Controls.Add(this.cFace1);
            this.CharacterDicePanel.Controls.Add(this.cFace2);
            this.CharacterDicePanel.Location = new System.Drawing.Point(0, 5);
            this.CharacterDicePanel.Name = "CharacterDicePanel";
            this.CharacterDicePanel.Size = new System.Drawing.Size(402, 72);
            this.CharacterDicePanel.TabIndex = 2;
            // 
            // cFace6
            // 
            this.cFace6.BackColor = System.Drawing.Color.White;
            this.cFace6.Enabled = false;
            this.cFace6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cFace6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFace6.Location = new System.Drawing.Point(298, 17);
            this.cFace6.Name = "cFace6";
            this.cFace6.Size = new System.Drawing.Size(41, 38);
            this.cFace6.TabIndex = 8;
            this.cFace6.UseVisualStyleBackColor = false;
            // 
            // cFace5
            // 
            this.cFace5.BackColor = System.Drawing.Color.White;
            this.cFace5.Enabled = false;
            this.cFace5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cFace5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFace5.Location = new System.Drawing.Point(251, 17);
            this.cFace5.Name = "cFace5";
            this.cFace5.Size = new System.Drawing.Size(41, 38);
            this.cFace5.TabIndex = 7;
            this.cFace5.UseVisualStyleBackColor = false;
            // 
            // cFace4
            // 
            this.cFace4.BackColor = System.Drawing.Color.White;
            this.cFace4.Enabled = false;
            this.cFace4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cFace4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFace4.Location = new System.Drawing.Point(204, 17);
            this.cFace4.Name = "cFace4";
            this.cFace4.Size = new System.Drawing.Size(41, 38);
            this.cFace4.TabIndex = 6;
            this.cFace4.UseVisualStyleBackColor = false;
            // 
            // cFace3
            // 
            this.cFace3.BackColor = System.Drawing.Color.White;
            this.cFace3.Enabled = false;
            this.cFace3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cFace3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFace3.Location = new System.Drawing.Point(157, 17);
            this.cFace3.Name = "cFace3";
            this.cFace3.Size = new System.Drawing.Size(41, 38);
            this.cFace3.TabIndex = 5;
            this.cFace3.UseVisualStyleBackColor = false;
            // 
            // cFace1
            // 
            this.cFace1.BackColor = System.Drawing.Color.White;
            this.cFace1.Enabled = false;
            this.cFace1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cFace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFace1.Location = new System.Drawing.Point(63, 17);
            this.cFace1.Name = "cFace1";
            this.cFace1.Size = new System.Drawing.Size(41, 38);
            this.cFace1.TabIndex = 3;
            this.cFace1.UseVisualStyleBackColor = false;
            // 
            // cFace2
            // 
            this.cFace2.BackColor = System.Drawing.Color.White;
            this.cFace2.Enabled = false;
            this.cFace2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cFace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFace2.Location = new System.Drawing.Point(110, 17);
            this.cFace2.Name = "cFace2";
            this.cFace2.Size = new System.Drawing.Size(41, 38);
            this.cFace2.TabIndex = 4;
            this.cFace2.UseVisualStyleBackColor = false;
            // 
            // EnemyPanel
            // 
            this.EnemyPanel.Controls.Add(this.lblEnemyHealth);
            this.EnemyPanel.Controls.Add(this.lblEnemyName);
            this.EnemyPanel.Controls.Add(this.progBarEnemy);
            this.EnemyPanel.Controls.Add(this.picBoxEnemy);
            this.EnemyPanel.Location = new System.Drawing.Point(408, 83);
            this.EnemyPanel.Name = "EnemyPanel";
            this.EnemyPanel.Size = new System.Drawing.Size(402, 292);
            this.EnemyPanel.TabIndex = 3;
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.Location = new System.Drawing.Point(105, 217);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(200, 23);
            this.lblEnemyHealth.TabIndex = 6;
            this.lblEnemyHealth.Text = "Current/Max";
            this.lblEnemyHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.Location = new System.Drawing.Point(167, 14);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(78, 25);
            this.lblEnemyName.TabIndex = 3;
            this.lblEnemyName.Text = "Enemy";
            // 
            // progBarEnemy
            // 
            this.progBarEnemy.Location = new System.Drawing.Point(105, 241);
            this.progBarEnemy.Name = "progBarEnemy";
            this.progBarEnemy.Size = new System.Drawing.Size(200, 28);
            this.progBarEnemy.TabIndex = 2;
            // 
            // picBoxEnemy
            // 
            this.picBoxEnemy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxEnemy.Location = new System.Drawing.Point(105, 42);
            this.picBoxEnemy.Name = "picBoxEnemy";
            this.picBoxEnemy.Size = new System.Drawing.Size(200, 169);
            this.picBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEnemy.TabIndex = 1;
            this.picBoxEnemy.TabStop = false;
            // 
            // EnemyDicePanel
            // 
            this.EnemyDicePanel.Controls.Add(this.eFace6);
            this.EnemyDicePanel.Controls.Add(this.eFace5);
            this.EnemyDicePanel.Controls.Add(this.eFace4);
            this.EnemyDicePanel.Controls.Add(this.eFace3);
            this.EnemyDicePanel.Controls.Add(this.eFace1);
            this.EnemyDicePanel.Controls.Add(this.eFace2);
            this.EnemyDicePanel.Controls.Add(this.lblEnemyTotal);
            this.EnemyDicePanel.Location = new System.Drawing.Point(408, 5);
            this.EnemyDicePanel.Name = "EnemyDicePanel";
            this.EnemyDicePanel.Size = new System.Drawing.Size(402, 72);
            this.EnemyDicePanel.TabIndex = 4;
            // 
            // eFace6
            // 
            this.eFace6.BackColor = System.Drawing.Color.White;
            this.eFace6.Enabled = false;
            this.eFace6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eFace6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFace6.Location = new System.Drawing.Point(298, 17);
            this.eFace6.Name = "eFace6";
            this.eFace6.Size = new System.Drawing.Size(41, 38);
            this.eFace6.TabIndex = 24;
            this.eFace6.UseVisualStyleBackColor = false;
            // 
            // eFace5
            // 
            this.eFace5.BackColor = System.Drawing.Color.White;
            this.eFace5.Enabled = false;
            this.eFace5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eFace5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFace5.Location = new System.Drawing.Point(251, 17);
            this.eFace5.Name = "eFace5";
            this.eFace5.Size = new System.Drawing.Size(41, 38);
            this.eFace5.TabIndex = 23;
            this.eFace5.UseVisualStyleBackColor = false;
            // 
            // eFace4
            // 
            this.eFace4.BackColor = System.Drawing.Color.White;
            this.eFace4.Enabled = false;
            this.eFace4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eFace4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFace4.Location = new System.Drawing.Point(204, 17);
            this.eFace4.Name = "eFace4";
            this.eFace4.Size = new System.Drawing.Size(41, 38);
            this.eFace4.TabIndex = 22;
            this.eFace4.UseVisualStyleBackColor = false;
            // 
            // eFace3
            // 
            this.eFace3.BackColor = System.Drawing.Color.White;
            this.eFace3.Enabled = false;
            this.eFace3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eFace3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFace3.Location = new System.Drawing.Point(157, 17);
            this.eFace3.Name = "eFace3";
            this.eFace3.Size = new System.Drawing.Size(41, 38);
            this.eFace3.TabIndex = 21;
            this.eFace3.UseVisualStyleBackColor = false;
            // 
            // eFace1
            // 
            this.eFace1.BackColor = System.Drawing.Color.White;
            this.eFace1.Enabled = false;
            this.eFace1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eFace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFace1.Location = new System.Drawing.Point(63, 17);
            this.eFace1.Name = "eFace1";
            this.eFace1.Size = new System.Drawing.Size(41, 38);
            this.eFace1.TabIndex = 19;
            this.eFace1.UseVisualStyleBackColor = false;
            // 
            // eFace2
            // 
            this.eFace2.BackColor = System.Drawing.Color.White;
            this.eFace2.Enabled = false;
            this.eFace2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eFace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFace2.Location = new System.Drawing.Point(110, 17);
            this.eFace2.Name = "eFace2";
            this.eFace2.Size = new System.Drawing.Size(41, 38);
            this.eFace2.TabIndex = 20;
            this.eFace2.UseVisualStyleBackColor = false;
            // 
            // lblEnemyTotal
            // 
            this.lblEnemyTotal.AutoSize = true;
            this.lblEnemyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyTotal.Location = new System.Drawing.Point(0, 52);
            this.lblEnemyTotal.Name = "lblEnemyTotal";
            this.lblEnemyTotal.Size = new System.Drawing.Size(44, 20);
            this.lblEnemyTotal.TabIndex = 18;
            this.lblEnemyTotal.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cSchedule3);
            this.panel1.Controls.Add(this.cSchedule1);
            this.panel1.Controls.Add(this.cSchedule2);
            this.panel1.Controls.Add(this.btnFaces);
            this.panel1.Controls.Add(this.btnRoll);
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 72);
            this.panel1.TabIndex = 5;
            // 
            // cSchedule3
            // 
            this.cSchedule3.BackColor = System.Drawing.Color.White;
            this.cSchedule3.Enabled = false;
            this.cSchedule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cSchedule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSchedule3.Location = new System.Drawing.Point(228, 17);
            this.cSchedule3.Name = "cSchedule3";
            this.cSchedule3.Size = new System.Drawing.Size(41, 38);
            this.cSchedule3.TabIndex = 19;
            this.cSchedule3.UseVisualStyleBackColor = false;
            // 
            // cSchedule1
            // 
            this.cSchedule1.BackColor = System.Drawing.Color.White;
            this.cSchedule1.Enabled = false;
            this.cSchedule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cSchedule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSchedule1.Location = new System.Drawing.Point(134, 17);
            this.cSchedule1.Name = "cSchedule1";
            this.cSchedule1.Size = new System.Drawing.Size(41, 38);
            this.cSchedule1.TabIndex = 17;
            this.cSchedule1.UseVisualStyleBackColor = false;
            // 
            // cSchedule2
            // 
            this.cSchedule2.BackColor = System.Drawing.Color.White;
            this.cSchedule2.Enabled = false;
            this.cSchedule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cSchedule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSchedule2.Location = new System.Drawing.Point(181, 17);
            this.cSchedule2.Name = "cSchedule2";
            this.cSchedule2.Size = new System.Drawing.Size(41, 38);
            this.cSchedule2.TabIndex = 18;
            this.cSchedule2.UseVisualStyleBackColor = false;
            // 
            // btnFaces
            // 
            this.btnFaces.Location = new System.Drawing.Point(12, 28);
            this.btnFaces.Name = "btnFaces";
            this.btnFaces.Size = new System.Drawing.Size(75, 41);
            this.btnFaces.TabIndex = 16;
            this.btnFaces.Text = "Change Faces";
            this.btnFaces.UseVisualStyleBackColor = true;
            this.btnFaces.Click += new System.EventHandler(this.btnFaces_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(313, 40);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(85, 29);
            this.btnRoll.TabIndex = 15;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKill);
            this.panel2.Controls.Add(this.btnSkip);
            this.panel2.Controls.Add(this.eSchedule3);
            this.panel2.Controls.Add(this.eSchedule1);
            this.panel2.Controls.Add(this.eSchedule2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(408, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 72);
            this.panel2.TabIndex = 6;
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(275, 9);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(116, 25);
            this.btnKill.TabIndex = 24;
            this.btnKill.Text = "Kill Game";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(275, 40);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(116, 25);
            this.btnSkip.TabIndex = 23;
            this.btnSkip.Text = "Skip Fight";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // eSchedule3
            // 
            this.eSchedule3.BackColor = System.Drawing.Color.White;
            this.eSchedule3.Enabled = false;
            this.eSchedule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eSchedule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eSchedule3.Location = new System.Drawing.Point(228, 17);
            this.eSchedule3.Name = "eSchedule3";
            this.eSchedule3.Size = new System.Drawing.Size(41, 38);
            this.eSchedule3.TabIndex = 22;
            this.eSchedule3.UseVisualStyleBackColor = false;
            // 
            // eSchedule1
            // 
            this.eSchedule1.BackColor = System.Drawing.Color.White;
            this.eSchedule1.Enabled = false;
            this.eSchedule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eSchedule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eSchedule1.Location = new System.Drawing.Point(134, 17);
            this.eSchedule1.Name = "eSchedule1";
            this.eSchedule1.Size = new System.Drawing.Size(41, 38);
            this.eSchedule1.TabIndex = 20;
            this.eSchedule1.UseVisualStyleBackColor = false;
            // 
            // eSchedule2
            // 
            this.eSchedule2.BackColor = System.Drawing.Color.White;
            this.eSchedule2.Enabled = false;
            this.eSchedule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eSchedule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eSchedule2.Location = new System.Drawing.Point(181, 17);
            this.eSchedule2.Name = "eSchedule2";
            this.eSchedule2.Size = new System.Drawing.Size(41, 38);
            this.eSchedule2.TabIndex = 21;
            this.eSchedule2.UseVisualStyleBackColor = false;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Black;
            this.panel21.Location = new System.Drawing.Point(404, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1, 450);
            this.panel21.TabIndex = 7;
            // 
            // OnePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 455);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EnemyDicePanel);
            this.Controls.Add(this.EnemyPanel);
            this.Controls.Add(this.CharacterDicePanel);
            this.Controls.Add(this.CharacterPanel);
            this.Name = "OnePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnePlayer_FormClosing);
            this.Load += new System.EventHandler(this.DiceGame_Load);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCharacter)).EndInit();
            this.CharacterDicePanel.ResumeLayout(false);
            this.CharacterDicePanel.PerformLayout();
            this.EnemyPanel.ResumeLayout(false);
            this.EnemyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnemy)).EndInit();
            this.EnemyDicePanel.ResumeLayout(false);
            this.EnemyDicePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CharacterPanel;
        private System.Windows.Forms.Panel CharacterDicePanel;
        private System.Windows.Forms.Panel EnemyPanel;
        private System.Windows.Forms.Panel EnemyDicePanel;
        private System.Windows.Forms.Label lblCharTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEnemyTotal;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.ProgressBar progBarChar;
        private System.Windows.Forms.PictureBox picBoxCharacter;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.ProgressBar progBarEnemy;
        private System.Windows.Forms.PictureBox picBoxEnemy;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnFaces;
        private System.Windows.Forms.Button cFace6;
        private System.Windows.Forms.Button cFace5;
        private System.Windows.Forms.Button cFace4;
        private System.Windows.Forms.Button cFace3;
        private System.Windows.Forms.Button cFace1;
        private System.Windows.Forms.Button cFace2;
        private System.Windows.Forms.Button eFace6;
        private System.Windows.Forms.Button eFace5;
        private System.Windows.Forms.Button eFace4;
        private System.Windows.Forms.Button eFace3;
        private System.Windows.Forms.Button eFace1;
        private System.Windows.Forms.Button eFace2;
        private System.Windows.Forms.Button cSchedule3;
        private System.Windows.Forms.Button cSchedule1;
        private System.Windows.Forms.Button cSchedule2;
        private System.Windows.Forms.Button eSchedule3;
        private System.Windows.Forms.Button eSchedule1;
        private System.Windows.Forms.Button eSchedule2;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.ToolTip toolTipSpecial;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Label lblCharHealth;
        private System.Windows.Forms.Label lblEnemyHealth;
    }
}


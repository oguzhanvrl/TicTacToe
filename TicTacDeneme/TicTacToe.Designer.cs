namespace TicTacDeneme
{
    partial class PvP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeBar = new CircularProgressBar.CircularProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timerBar = new CircularProgressBar.CircularProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();
            this.btnScoreReset = new System.Windows.Forms.Button();
            this.btnGameReset = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblScoreO = new System.Windows.Forms.Label();
            this.lblScoreTie = new System.Windows.Forms.Label();
            this.lblScoreX = new System.Windows.Forms.Label();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeBar
            // 
            this.timeBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.timeBar.AnimationSpeed = 500;
            this.timeBar.BackColor = System.Drawing.Color.Transparent;
            this.timeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.timeBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timeBar.InnerMargin = 2;
            this.timeBar.InnerWidth = -1;
            this.timeBar.Location = new System.Drawing.Point(166, 61);
            this.timeBar.MarqueeAnimationSpeed = 2000;
            this.timeBar.Maximum = 20;
            this.timeBar.Name = "timeBar";
            this.timeBar.OuterColor = System.Drawing.Color.RoyalBlue;
            this.timeBar.OuterMargin = -25;
            this.timeBar.OuterWidth = 26;
            this.timeBar.ProgressColor = System.Drawing.Color.Crimson;
            this.timeBar.ProgressWidth = 25;
            this.timeBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.timeBar.Size = new System.Drawing.Size(320, 320);
            this.timeBar.StartAngle = 90;
            this.timeBar.Step = 100;
            this.timeBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timeBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.timeBar.SubscriptText = "";
            this.timeBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timeBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.timeBar.SuperscriptText = "";
            this.timeBar.TabIndex = 0;
            this.timeBar.Text = "X";
            this.timeBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.timeBar.Value = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timerBar
            // 
            this.timerBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.timerBar.AnimationSpeed = 500;
            this.timerBar.BackColor = System.Drawing.Color.Transparent;
            this.timerBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.timerBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timerBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timerBar.InnerMargin = 2;
            this.timerBar.InnerWidth = -1;
            this.timerBar.Location = new System.Drawing.Point(3, 3);
            this.timerBar.MarqueeAnimationSpeed = 2000;
            this.timerBar.Maximum = 20;
            this.timerBar.Name = "timerBar";
            this.timerBar.OuterColor = System.Drawing.Color.Red;
            this.timerBar.OuterMargin = -25;
            this.timerBar.OuterWidth = 26;
            this.timerBar.ProgressColor = System.Drawing.Color.Blue;
            this.timerBar.ProgressWidth = 25;
            this.timerBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.timerBar.Size = new System.Drawing.Size(150, 150);
            this.timerBar.StartAngle = 270;
            this.timerBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timerBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.timerBar.SubscriptText = "";
            this.timerBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timerBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.timerBar.SuperscriptText = "";
            this.timerBar.TabIndex = 0;
            this.timerBar.Text = "X";
            this.timerBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.timerBar.Value = 10;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.btnScoreReset);
            this.GamePanel.Controls.Add(this.btnGameReset);
            this.GamePanel.Controls.Add(this.btnMenu);
            this.GamePanel.Controls.Add(this.lblScoreO);
            this.GamePanel.Controls.Add(this.lblScoreTie);
            this.GamePanel.Controls.Add(this.lblScoreX);
            this.GamePanel.Controls.Add(this.timerBar);
            this.GamePanel.Location = new System.Drawing.Point(12, 12);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(662, 380);
            this.GamePanel.TabIndex = 1;
            // 
            // btnScoreReset
            // 
            this.btnScoreReset.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreReset.Location = new System.Drawing.Point(281, 90);
            this.btnScoreReset.Name = "btnScoreReset";
            this.btnScoreReset.Size = new System.Drawing.Size(155, 63);
            this.btnScoreReset.TabIndex = 6;
            this.btnScoreReset.Text = "Skoru Sıfırla";
            this.btnScoreReset.UseVisualStyleBackColor = true;
            this.btnScoreReset.Click += new System.EventHandler(this.btnScoreReset_Click);
            // 
            // btnGameReset
            // 
            this.btnGameReset.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameReset.Location = new System.Drawing.Point(281, 10);
            this.btnGameReset.Name = "btnGameReset";
            this.btnGameReset.Size = new System.Drawing.Size(155, 63);
            this.btnGameReset.TabIndex = 5;
            this.btnGameReset.Text = "Oyunu Sıfırla";
            this.btnGameReset.UseVisualStyleBackColor = true;
            this.btnGameReset.Click += new System.EventHandler(this.btnGameReset_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(281, 170);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(155, 63);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Ana Menü";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblScoreO
            // 
            this.lblScoreO.AutoSize = true;
            this.lblScoreO.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreO.ForeColor = System.Drawing.Color.Blue;
            this.lblScoreO.Location = new System.Drawing.Point(169, 48);
            this.lblScoreO.Name = "lblScoreO";
            this.lblScoreO.Size = new System.Drawing.Size(79, 33);
            this.lblScoreO.TabIndex = 3;
            this.lblScoreO.Text = "O : 0";
            // 
            // lblScoreTie
            // 
            this.lblScoreTie.AutoSize = true;
            this.lblScoreTie.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTie.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblScoreTie.Location = new System.Drawing.Point(169, 88);
            this.lblScoreTie.Name = "lblScoreTie";
            this.lblScoreTie.Size = new System.Drawing.Size(96, 33);
            this.lblScoreTie.TabIndex = 2;
            this.lblScoreTie.Text = "Tie : 0";
            // 
            // lblScoreX
            // 
            this.lblScoreX.AutoSize = true;
            this.lblScoreX.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreX.ForeColor = System.Drawing.Color.Red;
            this.lblScoreX.Location = new System.Drawing.Point(169, 8);
            this.lblScoreX.Name = "lblScoreX";
            this.lblScoreX.Size = new System.Drawing.Size(74, 33);
            this.lblScoreX.TabIndex = 1;
            this.lblScoreX.Text = "X : 0";
            // 
            // PvP
            // 
            this.ClientSize = new System.Drawing.Size(755, 489);
            this.Controls.Add(this.GamePanel);
            this.Name = "PvP";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.PvP_Load);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar timeBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private CircularProgressBar.CircularProgressBar timerBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label lblScoreO;
        private System.Windows.Forms.Label lblScoreTie;
        private System.Windows.Forms.Label lblScoreX;
        private System.Windows.Forms.Button btnScoreReset;
        private System.Windows.Forms.Button btnGameReset;
        private System.Windows.Forms.Button btnMenu;
    }
}


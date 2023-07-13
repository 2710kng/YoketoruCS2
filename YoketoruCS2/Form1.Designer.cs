namespace YoketoruCS2
{
    partial class labelCopyright
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            buttonTitle = new Button();
            labelTitle = new Label();
            labelHighScore = new Label();
            labelGameover = new Label();
            labelClear = new Label();
            tempPlayer = new Label();
            tempItem = new Label();
            tempObstacle = new Label();
            labelScore = new Label();
            labelTimer = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // buttonStart
            // 
            buttonStart.AllowDrop = true;
            buttonStart.Location = new Point(298, 225);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(178, 63);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Visible = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(298, 332);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(178, 54);
            buttonTitle.TabIndex = 1;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(355, 123);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(56, 15);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "よけとるCS";
            labelTitle.Visible = false;
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Location = new Point(361, 9);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(31, 15);
            labelHighScore.TabIndex = 3;
            labelHighScore.Text = "0000";
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Location = new Point(345, 154);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(75, 15);
            labelGameover.TabIndex = 4;
            labelGameover.Text = "GAME  OVER";
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Location = new Point(340, 169);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(80, 15);
            labelClear.TabIndex = 5;
            labelClear.Text = "GAME  CLEAR";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Location = new Point(12, 123);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(38, 15);
            tempPlayer.TabIndex = 6;
            tempPlayer.Text = "label1";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Location = new Point(12, 225);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(38, 15);
            tempItem.TabIndex = 7;
            tempItem.Text = "label1";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Location = new Point(12, 71);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(38, 15);
            tempObstacle.TabIndex = 8;
            tempObstacle.Text = "label1";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(361, 42);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(37, 15);
            labelScore.TabIndex = 9;
            labelScore.Text = "00000";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(715, 400);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(31, 15);
            labelTimer.TabIndex = 10;
            labelTimer.Text = "0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label1";
            // 
            // labelCopyright
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTimer);
            Controls.Add(labelScore);
            Controls.Add(tempObstacle);
            Controls.Add(tempItem);
            Controls.Add(tempPlayer);
            Controls.Add(labelClear);
            Controls.Add(labelGameover);
            Controls.Add(labelHighScore);
            Controls.Add(labelTitle);
            Controls.Add(buttonTitle);
            Controls.Add(buttonStart);
            Name = "labelCopyright";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button buttonStart;
        private Button buttonTitle;
        private Label labelTitle;
        private Label labelHighScore;
        private Label labelGameover;
        private Label labelClear;
        private Label tempPlayer;
        private Label tempItem;
        private Label tempObstacle;
        private Label labelScore;
        private Label labelTimer;
        private Label label1;
        private Label label2;
    }
}
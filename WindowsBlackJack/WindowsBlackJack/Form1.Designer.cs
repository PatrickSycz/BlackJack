namespace WindowsBlackJack
{
    partial class MainForm
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
            this.GameBoardPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PassButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DealerShowingLabel = new System.Windows.Forms.Label();
            this.ShowingLabelText = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBoardPanel
            // 
            this.GameBoardPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.GameBoardPanel.Controls.Add(this.ScoreLabel);
            this.GameBoardPanel.Controls.Add(this.ScoreText);
            this.GameBoardPanel.Controls.Add(this.ShowingLabelText);
            this.GameBoardPanel.Controls.Add(this.DealerShowingLabel);
            this.GameBoardPanel.Controls.Add(this.StartButton);
            this.GameBoardPanel.Controls.Add(this.pictureBox1);
            this.GameBoardPanel.Controls.Add(this.PassButton);
            this.GameBoardPanel.Controls.Add(this.HitButton);
            this.GameBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.GameBoardPanel.Name = "GameBoardPanel";
            this.GameBoardPanel.Size = new System.Drawing.Size(784, 564);
            this.GameBoardPanel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(317, 455);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(144, 46);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 445);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // PassButton
            // 
            this.PassButton.BackColor = System.Drawing.SystemColors.Control;
            this.PassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassButton.Location = new System.Drawing.Point(439, 455);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(144, 46);
            this.PassButton.TabIndex = 1;
            this.PassButton.Text = "Pass";
            this.PassButton.UseVisualStyleBackColor = false;
            this.PassButton.Visible = false;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.BackColor = System.Drawing.SystemColors.Control;
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitButton.Location = new System.Drawing.Point(237, 455);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(144, 46);
            this.HitButton.TabIndex = 0;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = false;
            this.HitButton.Visible = false;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DealerShowingLabel
            // 
            this.DealerShowingLabel.AutoSize = true;
            this.DealerShowingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerShowingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DealerShowingLabel.Location = new System.Drawing.Point(589, 9);
            this.DealerShowingLabel.Name = "DealerShowingLabel";
            this.DealerShowingLabel.Size = new System.Drawing.Size(82, 20);
            this.DealerShowingLabel.TabIndex = 4;
            this.DealerShowingLabel.Text = "Showing:";
            // 
            // ShowingLabelText
            // 
            this.ShowingLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowingLabelText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowingLabelText.Location = new System.Drawing.Point(677, 9);
            this.ShowingLabelText.Name = "ShowingLabelText";
            this.ShowingLabelText.Size = new System.Drawing.Size(70, 20);
            this.ShowingLabelText.TabIndex = 5;
            this.ShowingLabelText.Text = "0";
            this.ShowingLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScoreText
            // 
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreText.Location = new System.Drawing.Point(677, 357);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(70, 20);
            this.ScoreText.TabIndex = 6;
            this.ScoreText.Text = "0";
            this.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreLabel.Location = new System.Drawing.Point(589, 357);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(61, 20);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "Score:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.GameBoardPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Jack";
            this.TopMost = true;
            this.GameBoardPanel.ResumeLayout(false);
            this.GameBoardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameBoardPanel;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label ShowingLabelText;
        private System.Windows.Forms.Label DealerShowingLabel;
    }
}


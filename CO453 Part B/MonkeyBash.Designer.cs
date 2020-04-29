namespace CO453_Part_B
{
    partial class MonkeyBash
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbltestcoord = new System.Windows.Forms.Label();
            this.lbldebug = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.bull1 = new System.Windows.Forms.PictureBox();
            this.bull3 = new System.Windows.Forms.PictureBox();
            this.bull2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bull1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bull3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bull2)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Location = new System.Drawing.Point(250, 418);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 41);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startTimer);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(413, 418);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(117, 41);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopTimer);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeButton.Location = new System.Drawing.Point(568, 418);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(117, 41);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeForm);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1500;
            this.animationTimer.Tick += new System.EventHandler(this.moveMonkey);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::CO453_Part_B.Properties.Resources.bullseye;
            this.imagePictureBox.Location = new System.Drawing.Point(113, 82);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(100, 100);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 3;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            this.imagePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseDown);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(580, 16);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 37);
            this.messageLabel.TabIndex = 4;
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(12, 426);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(289, 37);
            this.hitsLabel.TabIndex = 5;
            this.hitsLabel.Text = "Hits = 0 Misses = 0";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.bull2);
            this.gamePanel.Controls.Add(this.bull3);
            this.gamePanel.Controls.Add(this.bull1);
            this.gamePanel.Controls.Add(this.imagePictureBox);
            this.gamePanel.Controls.Add(this.messageLabel);
            this.gamePanel.Location = new System.Drawing.Point(17, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(683, 391);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Click += new System.EventHandler(this.gamePanel_Click);
            this.gamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyBash_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.moveBull1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1100;
            this.timer2.Tick += new System.EventHandler(this.moveBull2);
            // 
            // timer3
            // 
            this.timer3.Interval = 1300;
            this.timer3.Tick += new System.EventHandler(this.moveBull3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Results";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(739, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 8;
            // 
            // lbltestcoord
            // 
            this.lbltestcoord.Location = new System.Drawing.Point(0, 0);
            this.lbltestcoord.Name = "lbltestcoord";
            this.lbltestcoord.Size = new System.Drawing.Size(100, 23);
            this.lbltestcoord.TabIndex = 1;
            // 
            // lbldebug
            // 
            this.lbldebug.Location = new System.Drawing.Point(0, 0);
            this.lbldebug.Name = "lbldebug";
            this.lbldebug.Size = new System.Drawing.Size(100, 23);
            this.lbldebug.TabIndex = 0;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(745, 228);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 37);
            this.lblResults.TabIndex = 9;
            // 
            // bull1
            // 
            this.bull1.Image = global::CO453_Part_B.Properties.Resources.bullseye;
            this.bull1.Location = new System.Drawing.Point(287, 144);
            this.bull1.Name = "bull1";
            this.bull1.Size = new System.Drawing.Size(100, 100);
            this.bull1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bull1.TabIndex = 5;
            this.bull1.TabStop = false;
            this.bull1.Click += new System.EventHandler(this.imagePictureBox_Click);
            this.bull1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseDown);
            // 
            // bull3
            // 
            this.bull3.Image = global::CO453_Part_B.Properties.Resources.bullseye;
            this.bull3.Location = new System.Drawing.Point(435, 237);
            this.bull3.Name = "bull3";
            this.bull3.Size = new System.Drawing.Size(100, 100);
            this.bull3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bull3.TabIndex = 6;
            this.bull3.TabStop = false;
            this.bull3.Click += new System.EventHandler(this.imagePictureBox_Click);
            this.bull3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseDown);
            // 
            // bull2
            // 
            this.bull2.Image = global::CO453_Part_B.Properties.Resources.bullseye;
            this.bull2.Location = new System.Drawing.Point(76, 237);
            this.bull2.Name = "bull2";
            this.bull2.Size = new System.Drawing.Size(100, 100);
            this.bull2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bull2.TabIndex = 7;
            this.bull2.TabStop = false;
            this.bull2.Click += new System.EventHandler(this.imagePictureBox_Click);
            this.bull2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseDown);
            // 
            // MonkeyBash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 471);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lbldebug);
            this.Controls.Add(this.lbltestcoord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MonkeyBash";
            this.Text = "Derek\'s Monkey Bash";
            this.Click += new System.EventHandler(this.MonkeyBash_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyBash_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bull1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bull3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bull2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbltestcoord;
        private System.Windows.Forms.Label lbldebug;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.PictureBox bull2;
        private System.Windows.Forms.PictureBox bull3;
        private System.Windows.Forms.PictureBox bull1;
    }
}
namespace CO453_Part_B
{
    partial class Calculator
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.linePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.powerbtn = new System.Windows.Forms.Button();
            this.averagebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(83, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(282, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Godfrey\'s Simple Calculator";
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.Black;
            this.linePanel.Location = new System.Drawing.Point(88, 75);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(518, 10);
            this.linePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(304, 127);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(100, 32);
            this.firstNumberTextBox.TabIndex = 3;
            this.firstNumberTextBox.Text = "5";
            this.firstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(304, 191);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(100, 32);
            this.secondNumberTextBox.TabIndex = 5;
            this.secondNumberTextBox.Text = "10";
            this.secondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Number";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(304, 253);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 32);
            this.resultTextBox.TabIndex = 7;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(93, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 10);
            this.panel1.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(696, 332);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 42);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.showExitSplashForm);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::CO453_Part_B.Properties.Resources.plus;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(445, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 90);
            this.addButton.TabIndex = 10;
            this.addButton.Tag = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Calculate);
            // 
            // subtractButton
            // 
            this.subtractButton.BackgroundImage = global::CO453_Part_B.Properties.Resources.minus;
            this.subtractButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subtractButton.Location = new System.Drawing.Point(445, 220);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(90, 90);
            this.subtractButton.TabIndex = 11;
            this.subtractButton.Tag = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.Calculate);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackgroundImage = global::CO453_Part_B.Properties.Resources.multiply;
            this.multiplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiplyButton.Location = new System.Drawing.Point(570, 106);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(90, 90);
            this.multiplyButton.TabIndex = 12;
            this.multiplyButton.Tag = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.Calculate);
            // 
            // divideButton
            // 
            this.divideButton.BackgroundImage = global::CO453_Part_B.Properties.Resources.divide;
            this.divideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.divideButton.Location = new System.Drawing.Point(570, 220);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(90, 90);
            this.divideButton.TabIndex = 13;
            this.divideButton.Tag = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.Calculate);
            // 
            // powerbtn
            // 
            this.powerbtn.BackgroundImage = global::CO453_Part_B.Properties.Resources.power;
            this.powerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powerbtn.Location = new System.Drawing.Point(696, 106);
            this.powerbtn.Name = "powerbtn";
            this.powerbtn.Size = new System.Drawing.Size(90, 90);
            this.powerbtn.TabIndex = 14;
            this.powerbtn.Tag = "power";
            this.powerbtn.UseVisualStyleBackColor = true;
            this.powerbtn.Click += new System.EventHandler(this.Calculate);
            // 
            // averagebtn
            // 
            this.averagebtn.Location = new System.Drawing.Point(696, 220);
            this.averagebtn.Name = "averagebtn";
            this.averagebtn.Size = new System.Drawing.Size(115, 37);
            this.averagebtn.TabIndex = 15;
            this.averagebtn.Tag = "average";
            this.averagebtn.Text = "Average";
            this.averagebtn.UseVisualStyleBackColor = true;
            this.averagebtn.Click += new System.EventHandler(this.Calculate);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(696, 273);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(122, 37);
            this.clearbtn.TabIndex = 16;
            this.clearbtn.Tag = "";
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(929, 501);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.averagebtn);
            this.Controls.Add(this.powerbtn);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "U1_CalculatorForm";
            this.Load += new System.EventHandler(this.showSplashForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button powerbtn;
        private System.Windows.Forms.Button averagebtn;
        private System.Windows.Forms.Button clearbtn;
    }
}
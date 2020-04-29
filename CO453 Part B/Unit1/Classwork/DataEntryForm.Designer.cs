namespace CO453_Part_B.Unit1.Classwork
{
    partial class DataEntryForm
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnChangeMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTown = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMain.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(50, 20);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(559, 58);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "User Details Data Entry";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(52, 88);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(160, 32);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSname.Location = new System.Drawing.Point(52, 134);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(138, 32);
            this.lblSname.TabIndex = 2;
            this.lblSname.Text = "Surname:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(222, 230);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(2, 27);
            this.lblMessage.TabIndex = 3;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(38, 366);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(150, 48);
            this.btnMessage.TabIndex = 4;
            this.btnMessage.Text = "&Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(397, 445);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(152, 48);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(209, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 48);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear Message";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSname
            // 
            this.txtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSname.Location = new System.Drawing.Point(222, 140);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(265, 26);
            this.txtSname.TabIndex = 8;
            // 
            // textFname
            // 
            this.textFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFname.Location = new System.Drawing.Point(222, 94);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(265, 26);
            this.textFname.TabIndex = 9;
            this.textFname.Text = " ";
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(38, 445);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(152, 48);
            this.btnUpper.TabIndex = 10;
            this.btnUpper.Text = "&Upper Case";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(209, 445);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(152, 48);
            this.btnLower.TabIndex = 11;
            this.btnLower.Text = "&Lower Case";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnChangeMessage
            // 
            this.btnChangeMessage.Location = new System.Drawing.Point(397, 366);
            this.btnChangeMessage.Name = "btnChangeMessage";
            this.btnChangeMessage.Size = new System.Drawing.Size(152, 48);
            this.btnChangeMessage.TabIndex = 12;
            this.btnChangeMessage.Text = "Change Message";
            this.btnChangeMessage.UseVisualStyleBackColor = true;
            this.btnChangeMessage.Click += new System.EventHandler(this.btnChangeMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Town:";
            // 
            // textTown
            // 
            this.textTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTown.Location = new System.Drawing.Point(222, 188);
            this.textTown.Name = "textTown";
            this.textTown.Size = new System.Drawing.Size(265, 26);
            this.textTown.TabIndex = 14;
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 559);
            this.Controls.Add(this.textTown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeMessage);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblMain);
            this.Name = "frmDataEntry";
            this.Text = "Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnChangeMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTown;
    }
}
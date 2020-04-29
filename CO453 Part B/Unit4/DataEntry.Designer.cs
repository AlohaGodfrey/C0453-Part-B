

namespace CO453_Part_B.Unit4
{
    partial class DataEntry
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnSeeBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSchool = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxDinner = new System.Windows.Forms.CheckBox();
            this.ckbxLunch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(559, 340);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(139, 54);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(327, 340);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(139, 54);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Totals";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnSeeBill
            // 
            this.btnSeeBill.Location = new System.Drawing.Point(80, 340);
            this.btnSeeBill.Name = "btnSeeBill";
            this.btnSeeBill.Size = new System.Drawing.Size(139, 54);
            this.btnSeeBill.TabIndex = 2;
            this.btnSeeBill.Text = "See Bill";
            this.btnSeeBill.UseVisualStyleBackColor = true;
            this.btnSeeBill.Click += new System.EventHandler(this.btnSeeBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 26);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "School :";
            // 
            // cbxSchool
            // 
            this.cbxSchool.FormattingEnabled = true;
            this.cbxSchool.Items.AddRange(new object[] {
            "Lewisham School",
            "London School",
            "Broadwater School"});
            this.cbxSchool.Location = new System.Drawing.Point(152, 117);
            this.cbxSchool.Name = "cbxSchool";
            this.cbxSchool.Size = new System.Drawing.Size(121, 28);
            this.cbxSchool.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxDinner);
            this.groupBox1.Controls.Add(this.ckbxLunch);
            this.groupBox1.Location = new System.Drawing.Point(84, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meals";
            // 
            // ckbxDinner
            // 
            this.ckbxDinner.AutoSize = true;
            this.ckbxDinner.Location = new System.Drawing.Point(175, 51);
            this.ckbxDinner.Name = "ckbxDinner";
            this.ckbxDinner.Size = new System.Drawing.Size(82, 24);
            this.ckbxDinner.TabIndex = 1;
            this.ckbxDinner.Text = "Dinner";
            this.ckbxDinner.UseVisualStyleBackColor = true;
            // 
            // ckbxLunch
            // 
            this.ckbxLunch.AutoSize = true;
            this.ckbxLunch.Location = new System.Drawing.Point(41, 51);
            this.ckbxLunch.Name = "ckbxLunch";
            this.ckbxLunch.Size = new System.Drawing.Size(79, 24);
            this.ckbxLunch.TabIndex = 0;
            this.ckbxLunch.Text = "Lunch";
            this.ckbxLunch.UseVisualStyleBackColor = true;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeeBill);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnQuit);
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Education in the 21st Century";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnSeeBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSchool;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbxDinner;
        private System.Windows.Forms.CheckBox ckbxLunch;
    }
}


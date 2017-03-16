namespace WindowsForms
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.sessionStartLabel = new System.Windows.Forms.Label();
            this.sessionQtyLabel = new System.Windows.Forms.Label();
            this.stopSessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Session Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Session quantity:";
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(124, 35);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(35, 13);
            this.loginNameLabel.TabIndex = 5;
            this.loginNameLabel.Text = "label6";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(124, 68);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(35, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "label7";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(124, 102);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(35, 13);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "label8";
            // 
            // sessionStartLabel
            // 
            this.sessionStartLabel.AutoSize = true;
            this.sessionStartLabel.Location = new System.Drawing.Point(124, 137);
            this.sessionStartLabel.Name = "sessionStartLabel";
            this.sessionStartLabel.Size = new System.Drawing.Size(35, 13);
            this.sessionStartLabel.TabIndex = 8;
            this.sessionStartLabel.Text = "label9";
            // 
            // sessionQtyLabel
            // 
            this.sessionQtyLabel.AutoSize = true;
            this.sessionQtyLabel.Location = new System.Drawing.Point(124, 170);
            this.sessionQtyLabel.Name = "sessionQtyLabel";
            this.sessionQtyLabel.Size = new System.Drawing.Size(41, 13);
            this.sessionQtyLabel.TabIndex = 9;
            this.sessionQtyLabel.Text = "label10";
            // 
            // stopSessionButton
            // 
            this.stopSessionButton.Location = new System.Drawing.Point(60, 207);
            this.stopSessionButton.Name = "stopSessionButton";
            this.stopSessionButton.Size = new System.Drawing.Size(149, 23);
            this.stopSessionButton.TabIndex = 10;
            this.stopSessionButton.Text = "Stop Session!";
            this.stopSessionButton.UseVisualStyleBackColor = true;
            this.stopSessionButton.Click += new System.EventHandler(this.stopSessionButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stopSessionButton);
            this.Controls.Add(this.sessionQtyLabel);
            this.Controls.Add(this.sessionStartLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.loginNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label loginNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label sessionStartLabel;
        private System.Windows.Forms.Label sessionQtyLabel;
        private System.Windows.Forms.Button stopSessionButton;
    }
}
﻿namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLable = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.chipsLabel = new System.Windows.Forms.Label();
            this.cookieLabel = new System.Windows.Forms.Label();
            this.calculatetotalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculatechangeButton = new System.Windows.Forms.Button();
            this.printreceiptButton = new System.Windows.Forms.Button();
            this.subsInput = new System.Windows.Forms.TextBox();
            this.chipsInput = new System.Windows.Forms.TextBox();
            this.cookiesInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeOutput = new System.Windows.Forms.Label();
            this.blacklineLabel = new System.Windows.Forms.Label();
            this.blacklineLabel2 = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.tryLabel1 = new System.Windows.Forms.Label();
            this.tryLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.BackColor = System.Drawing.Color.DarkGreen;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLable.Location = new System.Drawing.Point(0, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(801, 40);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Subway";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(26, 54);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(127, 13);
            this.subLabel.TabIndex = 1;
            this.subLabel.Text = "Number of Footlong Subs";
            // 
            // chipsLabel
            // 
            this.chipsLabel.AutoSize = true;
            this.chipsLabel.Location = new System.Drawing.Point(26, 84);
            this.chipsLabel.Name = "chipsLabel";
            this.chipsLabel.Size = new System.Drawing.Size(85, 13);
            this.chipsLabel.TabIndex = 3;
            this.chipsLabel.Text = "Number of Chips";
            // 
            // cookieLabel
            // 
            this.cookieLabel.AutoSize = true;
            this.cookieLabel.Location = new System.Drawing.Point(26, 115);
            this.cookieLabel.Name = "cookieLabel";
            this.cookieLabel.Size = new System.Drawing.Size(97, 13);
            this.cookieLabel.TabIndex = 4;
            this.cookieLabel.Text = "Number of Cookies";
            // 
            // calculatetotalButton
            // 
            this.calculatetotalButton.Location = new System.Drawing.Point(24, 162);
            this.calculatetotalButton.Name = "calculatetotalButton";
            this.calculatetotalButton.Size = new System.Drawing.Size(124, 23);
            this.calculatetotalButton.TabIndex = 6;
            this.calculatetotalButton.Text = "Calculate Totals";
            this.calculatetotalButton.UseVisualStyleBackColor = true;
            this.calculatetotalButton.Click += new System.EventHandler(this.calculatetotalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(26, 208);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(53, 13);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(26, 243);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(26, 276);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(26, 322);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(26, 394);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Change";
            // 
            // calculatechangeButton
            // 
            this.calculatechangeButton.Location = new System.Drawing.Point(24, 369);
            this.calculatechangeButton.Name = "calculatechangeButton";
            this.calculatechangeButton.Size = new System.Drawing.Size(124, 23);
            this.calculatechangeButton.TabIndex = 12;
            this.calculatechangeButton.Text = "Calculate Change";
            this.calculatechangeButton.UseVisualStyleBackColor = true;
            this.calculatechangeButton.Click += new System.EventHandler(this.calculatechangeButton_Click);
            // 
            // printreceiptButton
            // 
            this.printreceiptButton.Location = new System.Drawing.Point(29, 415);
            this.printreceiptButton.Name = "printreceiptButton";
            this.printreceiptButton.Size = new System.Drawing.Size(75, 23);
            this.printreceiptButton.TabIndex = 13;
            this.printreceiptButton.Text = "Print Receipt";
            this.printreceiptButton.UseVisualStyleBackColor = true;
            this.printreceiptButton.Click += new System.EventHandler(this.printreceiptButton_Click);
            // 
            // subsInput
            // 
            this.subsInput.Location = new System.Drawing.Point(180, 54);
            this.subsInput.Name = "subsInput";
            this.subsInput.Size = new System.Drawing.Size(22, 20);
            this.subsInput.TabIndex = 14;
            // 
            // chipsInput
            // 
            this.chipsInput.Location = new System.Drawing.Point(180, 84);
            this.chipsInput.Name = "chipsInput";
            this.chipsInput.Size = new System.Drawing.Size(22, 20);
            this.chipsInput.TabIndex = 15;
            // 
            // cookiesInput
            // 
            this.cookiesInput.Location = new System.Drawing.Point(180, 115);
            this.cookiesInput.Name = "cookiesInput";
            this.cookiesInput.Size = new System.Drawing.Size(22, 20);
            this.cookiesInput.TabIndex = 16;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(180, 208);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 13);
            this.subtotalOutput.TabIndex = 17;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(180, 243);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 13);
            this.taxOutput.TabIndex = 18;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(180, 276);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 13);
            this.totalOutput.TabIndex = 19;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(180, 319);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 20;
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(180, 394);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 13);
            this.changeOutput.TabIndex = 21;
            // 
            // blacklineLabel
            // 
            this.blacklineLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blacklineLabel.Location = new System.Drawing.Point(21, 300);
            this.blacklineLabel.Name = "blacklineLabel";
            this.blacklineLabel.Size = new System.Drawing.Size(259, 12);
            this.blacklineLabel.TabIndex = 22;
            // 
            // blacklineLabel2
            // 
            this.blacklineLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blacklineLabel2.Location = new System.Drawing.Point(21, 189);
            this.blacklineLabel2.Name = "blacklineLabel2";
            this.blacklineLabel2.Size = new System.Drawing.Size(259, 12);
            this.blacklineLabel2.TabIndex = 23;
            // 
            // neworderButton
            // 
            this.neworderButton.Location = new System.Drawing.Point(195, 415);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(85, 23);
            this.neworderButton.TabIndex = 24;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Visible = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // tryLabel1
            // 
            this.tryLabel1.AutoSize = true;
            this.tryLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryLabel1.ForeColor = System.Drawing.Color.Red;
            this.tryLabel1.Location = new System.Drawing.Point(26, 146);
            this.tryLabel1.Name = "tryLabel1";
            this.tryLabel1.Size = new System.Drawing.Size(0, 13);
            this.tryLabel1.TabIndex = 25;
            // 
            // tryLabel2
            // 
            this.tryLabel2.AutoSize = true;
            this.tryLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryLabel2.ForeColor = System.Drawing.Color.Red;
            this.tryLabel2.Location = new System.Drawing.Point(26, 353);
            this.tryLabel2.Name = "tryLabel2";
            this.tryLabel2.Size = new System.Drawing.Size(0, 13);
            this.tryLabel2.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tryLabel2);
            this.Controls.Add(this.tryLabel1);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.blacklineLabel2);
            this.Controls.Add(this.blacklineLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.cookiesInput);
            this.Controls.Add(this.chipsInput);
            this.Controls.Add(this.subsInput);
            this.Controls.Add(this.printreceiptButton);
            this.Controls.Add(this.calculatechangeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculatetotalButton);
            this.Controls.Add(this.cookieLabel);
            this.Controls.Add(this.chipsLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Subway";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label chipsLabel;
        private System.Windows.Forms.Label cookieLabel;
        private System.Windows.Forms.Button calculatetotalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button calculatechangeButton;
        private System.Windows.Forms.Button printreceiptButton;
        private System.Windows.Forms.TextBox subsInput;
        private System.Windows.Forms.TextBox chipsInput;
        private System.Windows.Forms.TextBox cookiesInput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label blacklineLabel;
        private System.Windows.Forms.Label blacklineLabel2;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label tryLabel1;
        private System.Windows.Forms.Label tryLabel2;
    }
}


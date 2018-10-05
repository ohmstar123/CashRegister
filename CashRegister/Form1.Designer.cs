namespace CashRegister
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
            this.drinkLabel = new System.Windows.Forms.Label();
            this.calculatetotalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculatechangeButton = new System.Windows.Forms.Button();
            this.printreceiptButton = new System.Windows.Forms.Button();
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
            this.subLabel.Location = new System.Drawing.Point(39, 68);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(127, 13);
            this.subLabel.TabIndex = 1;
            this.subLabel.Text = "Number of Footlong Subs";
            // 
            // chipsLabel
            // 
            this.chipsLabel.AutoSize = true;
            this.chipsLabel.Location = new System.Drawing.Point(39, 93);
            this.chipsLabel.Name = "chipsLabel";
            this.chipsLabel.Size = new System.Drawing.Size(85, 13);
            this.chipsLabel.TabIndex = 3;
            this.chipsLabel.Text = "Number of Chips";
            // 
            // cookieLabel
            // 
            this.cookieLabel.AutoSize = true;
            this.cookieLabel.Location = new System.Drawing.Point(39, 116);
            this.cookieLabel.Name = "cookieLabel";
            this.cookieLabel.Size = new System.Drawing.Size(97, 13);
            this.cookieLabel.TabIndex = 4;
            this.cookieLabel.Text = "Number of Cookies";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(39, 139);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(89, 13);
            this.drinkLabel.TabIndex = 5;
            this.drinkLabel.Text = "Number of Drinks";
            // 
            // calculatetotalButton
            // 
            this.calculatetotalButton.Location = new System.Drawing.Point(29, 187);
            this.calculatetotalButton.Name = "calculatetotalButton";
            this.calculatetotalButton.Size = new System.Drawing.Size(124, 23);
            this.calculatetotalButton.TabIndex = 6;
            this.calculatetotalButton.Text = "Calculate Totals";
            this.calculatetotalButton.UseVisualStyleBackColor = true;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(39, 229);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(53, 13);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(39, 262);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(39, 295);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(42, 340);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(45, 377);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Change";
            // 
            // calculatechangeButton
            // 
            this.calculatechangeButton.Location = new System.Drawing.Point(42, 356);
            this.calculatechangeButton.Name = "calculatechangeButton";
            this.calculatechangeButton.Size = new System.Drawing.Size(124, 23);
            this.calculatechangeButton.TabIndex = 12;
            this.calculatechangeButton.Text = "Calculate Change";
            this.calculatechangeButton.UseVisualStyleBackColor = true;
            // 
            // printreceiptButton
            // 
            this.printreceiptButton.Location = new System.Drawing.Point(42, 415);
            this.printreceiptButton.Name = "printreceiptButton";
            this.printreceiptButton.Size = new System.Drawing.Size(75, 23);
            this.printreceiptButton.TabIndex = 13;
            this.printreceiptButton.Text = "Print Receipt";
            this.printreceiptButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printreceiptButton);
            this.Controls.Add(this.calculatechangeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculatetotalButton);
            this.Controls.Add(this.drinkLabel);
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
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Button calculatetotalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button calculatechangeButton;
        private System.Windows.Forms.Button printreceiptButton;
    }
}


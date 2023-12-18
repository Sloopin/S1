
namespace The_money_box
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfCoins = new System.Windows.Forms.Label();
            this.tbNumberOfCoins = new System.Windows.Forms.TextBox();
            this.lbCoins = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTwoEuro = new System.Windows.Forms.Button();
            this.btnOneEuro = new System.Windows.Forms.Button();
            this.btnFiftyCent = new System.Windows.Forms.Button();
            this.btnTwentyCent = new System.Windows.Forms.Button();
            this.btnTenCent = new System.Windows.Forms.Button();
            this.btnFiveCent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblNumberOfCoins);
            this.panel1.Controls.Add(this.tbNumberOfCoins);
            this.panel1.Controls.Add(this.lbCoins);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnTwoEuro);
            this.panel1.Controls.Add(this.btnOneEuro);
            this.panel1.Controls.Add(this.btnFiftyCent);
            this.panel1.Controls.Add(this.btnTwentyCent);
            this.panel1.Controls.Add(this.btnTenCent);
            this.panel1.Controls.Add(this.btnFiveCent);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 565);
            this.panel1.TabIndex = 0;
            // 
            // lblNumberOfCoins
            // 
            this.lblNumberOfCoins.AutoSize = true;
            this.lblNumberOfCoins.Location = new System.Drawing.Point(17, 378);
            this.lblNumberOfCoins.Name = "lblNumberOfCoins";
            this.lblNumberOfCoins.Size = new System.Drawing.Size(128, 20);
            this.lblNumberOfCoins.TabIndex = 13;
            this.lblNumberOfCoins.Text = "How many coins:";
            // 
            // tbNumberOfCoins
            // 
            this.tbNumberOfCoins.Location = new System.Drawing.Point(146, 374);
            this.tbNumberOfCoins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumberOfCoins.Name = "tbNumberOfCoins";
            this.tbNumberOfCoins.Size = new System.Drawing.Size(112, 26);
            this.tbNumberOfCoins.TabIndex = 12;
            this.tbNumberOfCoins.TextChanged += new System.EventHandler(this.tbNumberOfCoins_TextChanged);
            // 
            // lbCoins
            // 
            this.lbCoins.FormattingEnabled = true;
            this.lbCoins.ItemHeight = 20;
            this.lbCoins.Location = new System.Drawing.Point(29, 106);
            this.lbCoins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(178, 224);
            this.lbCoins.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(519, 108);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(112, 26);
            this.tbTotal.TabIndex = 8;
            this.tbTotal.Text = "€0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Value";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(515, 81);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // btnTwoEuro
            // 
            this.btnTwoEuro.Location = new System.Drawing.Point(749, 431);
            this.btnTwoEuro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTwoEuro.Name = "btnTwoEuro";
            this.btnTwoEuro.Size = new System.Drawing.Size(110, 55);
            this.btnTwoEuro.TabIndex = 5;
            this.btnTwoEuro.Text = "€2.00";
            this.btnTwoEuro.UseVisualStyleBackColor = true;
            this.btnTwoEuro.Click += new System.EventHandler(this.btnTwoEuro_Click);
            // 
            // btnOneEuro
            // 
            this.btnOneEuro.Location = new System.Drawing.Point(632, 431);
            this.btnOneEuro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOneEuro.Name = "btnOneEuro";
            this.btnOneEuro.Size = new System.Drawing.Size(110, 55);
            this.btnOneEuro.TabIndex = 4;
            this.btnOneEuro.Text = "€1.00";
            this.btnOneEuro.UseVisualStyleBackColor = true;
            this.btnOneEuro.Click += new System.EventHandler(this.btnOneEuro_Click);
            // 
            // btnFiftyCent
            // 
            this.btnFiftyCent.Location = new System.Drawing.Point(515, 431);
            this.btnFiftyCent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiftyCent.Name = "btnFiftyCent";
            this.btnFiftyCent.Size = new System.Drawing.Size(110, 55);
            this.btnFiftyCent.TabIndex = 3;
            this.btnFiftyCent.Text = "€0.50";
            this.btnFiftyCent.UseVisualStyleBackColor = true;
            this.btnFiftyCent.Click += new System.EventHandler(this.btnFiftyCent_Click);
            // 
            // btnTwentyCent
            // 
            this.btnTwentyCent.Location = new System.Drawing.Point(263, 431);
            this.btnTwentyCent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTwentyCent.Name = "btnTwentyCent";
            this.btnTwentyCent.Size = new System.Drawing.Size(110, 55);
            this.btnTwentyCent.TabIndex = 2;
            this.btnTwentyCent.Text = "€0.20";
            this.btnTwentyCent.UseVisualStyleBackColor = true;
            this.btnTwentyCent.Click += new System.EventHandler(this.btnTwentyCent_Click);
            // 
            // btnTenCent
            // 
            this.btnTenCent.Location = new System.Drawing.Point(146, 431);
            this.btnTenCent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTenCent.Name = "btnTenCent";
            this.btnTenCent.Size = new System.Drawing.Size(110, 55);
            this.btnTenCent.TabIndex = 1;
            this.btnTenCent.Text = "€0.10";
            this.btnTenCent.UseVisualStyleBackColor = true;
            this.btnTenCent.Click += new System.EventHandler(this.btnTenCent_Click);
            // 
            // btnFiveCent
            // 
            this.btnFiveCent.Location = new System.Drawing.Point(29, 431);
            this.btnFiveCent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiveCent.Name = "btnFiveCent";
            this.btnFiveCent.Size = new System.Drawing.Size(110, 55);
            this.btnFiveCent.TabIndex = 0;
            this.btnFiveCent.Text = "€0.05";
            this.btnFiveCent.UseVisualStyleBackColor = true;
            this.btnFiveCent.Click += new System.EventHandler(this.btnFiveCent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbCoins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTwoEuro;
        private System.Windows.Forms.Button btnOneEuro;
        private System.Windows.Forms.Button btnFiftyCent;
        private System.Windows.Forms.Button btnTwentyCent;
        private System.Windows.Forms.Button btnTenCent;
        private System.Windows.Forms.Button btnFiveCent;
        private System.Windows.Forms.Label lblNumberOfCoins;
        private System.Windows.Forms.TextBox tbNumberOfCoins;
    }
}


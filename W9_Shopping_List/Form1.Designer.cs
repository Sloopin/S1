
namespace W9_Shopping_List
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
            this.tbxItem = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTotalForEntry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxFilterString = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFilterAbove = new System.Windows.Forms.Button();
            this.btnFilterBelow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxFilterPrice = new System.Windows.Forms.TextBox();
            this.btnShowAllItems = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxFilterLimit = new System.Windows.Forms.TextBox();
            this.btnFilterLimit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxItem
            // 
            this.tbxItem.Location = new System.Drawing.Point(24, 44);
            this.tbxItem.Name = "tbxItem";
            this.tbxItem.Size = new System.Drawing.Size(150, 20);
            this.tbxItem.TabIndex = 0;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(24, 98);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(63, 20);
            this.tbxPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price per item in $";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(111, 98);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(63, 20);
            this.tbxAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(24, 150);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(150, 23);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add to list";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(225, 44);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(230, 342);
            this.lbxItems.TabIndex = 7;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL:";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(390, 419);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(65, 20);
            this.tbxTotal.TabIndex = 10;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove selected item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOTAL for selected entry:";
            // 
            // tbxTotalForEntry
            // 
            this.tbxTotalForEntry.Location = new System.Drawing.Point(390, 392);
            this.tbxTotalForEntry.Name = "tbxTotalForEntry";
            this.tbxTotalForEntry.ReadOnly = true;
            this.tbxTotalForEntry.Size = new System.Drawing.Size(65, 20);
            this.tbxTotalForEntry.TabIndex = 13;
            this.tbxTotalForEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilterLimit);
            this.groupBox1.Controls.Add(this.tbxFilterLimit);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbxFilterString);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnFilterAbove);
            this.groupBox1.Controls.Add(this.btnFilterBelow);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxFilterPrice);
            this.groupBox1.Location = new System.Drawing.Point(491, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 414);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(137, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxFilterString
            // 
            this.tbxFilterString.Location = new System.Drawing.Point(23, 113);
            this.tbxFilterString.Name = "tbxFilterString";
            this.tbxFilterString.Size = new System.Drawing.Size(100, 20);
            this.tbxFilterString.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Search items";
            // 
            // btnFilterAbove
            // 
            this.btnFilterAbove.Location = new System.Drawing.Point(137, 47);
            this.btnFilterAbove.Name = "btnFilterAbove";
            this.btnFilterAbove.Size = new System.Drawing.Size(29, 23);
            this.btnFilterAbove.TabIndex = 3;
            this.btnFilterAbove.Text = ">";
            this.btnFilterAbove.UseVisualStyleBackColor = true;
            this.btnFilterAbove.Click += new System.EventHandler(this.btnFilterAbove_Click);
            // 
            // btnFilterBelow
            // 
            this.btnFilterBelow.Location = new System.Drawing.Point(172, 47);
            this.btnFilterBelow.Name = "btnFilterBelow";
            this.btnFilterBelow.Size = new System.Drawing.Size(29, 23);
            this.btnFilterBelow.TabIndex = 2;
            this.btnFilterBelow.Text = "<";
            this.btnFilterBelow.UseVisualStyleBackColor = true;
            this.btnFilterBelow.Click += new System.EventHandler(this.btnFilterBelow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Filter price";
            // 
            // tbxFilterPrice
            // 
            this.tbxFilterPrice.Location = new System.Drawing.Point(23, 49);
            this.tbxFilterPrice.Name = "tbxFilterPrice";
            this.tbxFilterPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxFilterPrice.TabIndex = 0;
            // 
            // btnShowAllItems
            // 
            this.btnShowAllItems.Location = new System.Drawing.Point(24, 222);
            this.btnShowAllItems.Name = "btnShowAllItems";
            this.btnShowAllItems.Size = new System.Drawing.Size(150, 23);
            this.btnShowAllItems.TabIndex = 15;
            this.btnShowAllItems.Text = "Show all items";
            this.btnShowAllItems.UseVisualStyleBackColor = true;
            this.btnShowAllItems.Click += new System.EventHandler(this.btnShowAllItems_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Price limit";
            // 
            // tbxFilterLimit
            // 
            this.tbxFilterLimit.Location = new System.Drawing.Point(23, 175);
            this.tbxFilterLimit.Name = "tbxFilterLimit";
            this.tbxFilterLimit.Size = new System.Drawing.Size(100, 20);
            this.tbxFilterLimit.TabIndex = 8;
            // 
            // btnFilterLimit
            // 
            this.btnFilterLimit.Location = new System.Drawing.Point(137, 175);
            this.btnFilterLimit.Name = "btnFilterLimit";
            this.btnFilterLimit.Size = new System.Drawing.Size(64, 23);
            this.btnFilterLimit.TabIndex = 9;
            this.btnFilterLimit.Text = "Go";
            this.btnFilterLimit.UseVisualStyleBackColor = true;
            this.btnFilterLimit.Click += new System.EventHandler(this.btnFilterLimit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnShowAllItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxTotalForEntry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxItem;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTotalForEntry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterAbove;
        private System.Windows.Forms.Button btnFilterBelow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxFilterPrice;
        private System.Windows.Forms.Button btnShowAllItems;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxFilterString;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFilterLimit;
        private System.Windows.Forms.TextBox tbxFilterLimit;
        private System.Windows.Forms.Label label9;
    }
}


namespace Shipping_Rates
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.shippingMethod = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.calcShippingBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfItemsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numOfItems = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shippingCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.yes);
            this.groupBox1.Location = new System.Drawing.Point(254, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surcharge (HA or AL)";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(24, 101);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(62, 29);
            this.no.TabIndex = 1;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            this.no.CheckedChanged += new System.EventHandler(this.no_CheckedChanged);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(24, 49);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(71, 29);
            this.yes.TabIndex = 0;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.CheckedChanged += new System.EventHandler(this.yes_CheckedChanged);
            // 
            // shippingMethod
            // 
            this.shippingMethod.FormattingEnabled = true;
            this.shippingMethod.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Same Day"});
            this.shippingMethod.Location = new System.Drawing.Point(39, 158);
            this.shippingMethod.Name = "shippingMethod";
            this.shippingMethod.Size = new System.Drawing.Size(172, 32);
            this.shippingMethod.TabIndex = 1;
            this.shippingMethod.Text = "(Click to Select)";
            this.shippingMethod.SelectedIndexChanged += new System.EventHandler(this.shippingMethod_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "By Weight",
            "Number of Items"});
            this.category.Location = new System.Drawing.Point(283, 158);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(172, 32);
            this.category.TabIndex = 2;
            this.category.Text = "(Click to Select)";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // calcShippingBtn
            // 
            this.calcShippingBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calcShippingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.calcShippingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcShippingBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcShippingBtn.Location = new System.Drawing.Point(56, 389);
            this.calcShippingBtn.Name = "calcShippingBtn";
            this.calcShippingBtn.Size = new System.Drawing.Size(121, 108);
            this.calcShippingBtn.TabIndex = 3;
            this.calcShippingBtn.Text = "Calculate Shipping";
            this.calcShippingBtn.UseVisualStyleBackColor = false;
            this.calcShippingBtn.Click += new System.EventHandler(this.calcShippingBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(162, 34);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shipping Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shipping Method";
            // 
            // numOfItemsLabel
            // 
            this.numOfItemsLabel.AutoSize = true;
            this.numOfItemsLabel.Location = new System.Drawing.Point(39, 244);
            this.numOfItemsLabel.Name = "numOfItemsLabel";
            this.numOfItemsLabel.Size = new System.Drawing.Size(154, 25);
            this.numOfItemsLabel.TabIndex = 7;
            this.numOfItemsLabel.Text = "Number of Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Red Fern On-Line Electronics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shipping Calculator";
            // 
            // numOfItems
            // 
            this.numOfItems.Location = new System.Drawing.Point(39, 283);
            this.numOfItems.Name = "numOfItems";
            this.numOfItems.Size = new System.Drawing.Size(172, 29);
            this.numOfItems.TabIndex = 10;
            this.numOfItems.TextChanged += new System.EventHandler(this.numOfItems_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            // 
            // shippingCost
            // 
            this.shippingCost.AutoSize = true;
            this.shippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingCost.Location = new System.Drawing.Point(283, 526);
            this.shippingCost.Name = "shippingCost";
            this.shippingCost.Size = new System.Drawing.Size(66, 25);
            this.shippingCost.TabIndex = 12;
            this.shippingCost.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(598, 594);
            this.Controls.Add(this.shippingCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numOfItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOfItemsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcShippingBtn);
            this.Controls.Add(this.category);
            this.Controls.Add(this.shippingMethod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shipping Rates";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.ComboBox shippingMethod;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button calcShippingBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numOfItemsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numOfItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label shippingCost;
    }
}


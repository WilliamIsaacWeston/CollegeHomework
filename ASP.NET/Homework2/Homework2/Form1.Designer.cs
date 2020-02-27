namespace Homework2
{
    partial class FormMainWindow
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
            this.panelSize = new System.Windows.Forms.Panel();
            this.radioButtonTwelveInch = new System.Windows.Forms.RadioButton();
            this.radioButtonNineInch = new System.Windows.Forms.RadioButton();
            this.radioButtonSixInch = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.panelMeat = new System.Windows.Forms.Panel();
            this.radioButtonClub = new System.Windows.Forms.RadioButton();
            this.labelMeat = new System.Windows.Forms.Label();
            this.radioButtonRoastBeef = new System.Windows.Forms.RadioButton();
            this.radioButtonTurkey = new System.Windows.Forms.RadioButton();
            this.radioButtonHam = new System.Windows.Forms.RadioButton();
            this.panelCondiments = new System.Windows.Forms.Panel();
            this.labelCondiments = new System.Windows.Forms.Label();
            this.checkedListBoxCondiments = new System.Windows.Forms.CheckedListBox();
            this.panelCheese = new System.Windows.Forms.Panel();
            this.checkBoxCheese = new System.Windows.Forms.CheckBox();
            this.radioButtonCheddar = new System.Windows.Forms.RadioButton();
            this.radioButtonProvolone = new System.Windows.Forms.RadioButton();
            this.radioButtonAmerican = new System.Windows.Forms.RadioButton();
            this.panelGratuity = new System.Windows.Forms.Panel();
            this.labelGratuityInitial = new System.Windows.Forms.Label();
            this.textBoxGratuity = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelGratuityFinal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubtotalAmount = new System.Windows.Forms.Label();
            this.labelTaxAmount = new System.Windows.Forms.Label();
            this.labelGratuityAmount = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelSize.SuspendLayout();
            this.panelMeat.SuspendLayout();
            this.panelCondiments.SuspendLayout();
            this.panelCheese.SuspendLayout();
            this.panelGratuity.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.radioButtonTwelveInch);
            this.panelSize.Controls.Add(this.radioButtonNineInch);
            this.panelSize.Controls.Add(this.radioButtonSixInch);
            this.panelSize.Controls.Add(this.labelSize);
            this.panelSize.Location = new System.Drawing.Point(12, 12);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(104, 143);
            this.panelSize.TabIndex = 0;
            // 
            // radioButtonTwelveInch
            // 
            this.radioButtonTwelveInch.AutoSize = true;
            this.radioButtonTwelveInch.Location = new System.Drawing.Point(0, 62);
            this.radioButtonTwelveInch.Name = "radioButtonTwelveInch";
            this.radioButtonTwelveInch.Size = new System.Drawing.Size(102, 17);
            this.radioButtonTwelveInch.TabIndex = 3;
            this.radioButtonTwelveInch.Text = "12 inch ($10.00)";
            this.radioButtonTwelveInch.UseVisualStyleBackColor = true;
            this.radioButtonTwelveInch.CheckedChanged += new System.EventHandler(this.radioButtonTwelveInch_CheckedChanged);
            // 
            // radioButtonNineInch
            // 
            this.radioButtonNineInch.AutoSize = true;
            this.radioButtonNineInch.Location = new System.Drawing.Point(0, 39);
            this.radioButtonNineInch.Name = "radioButtonNineInch";
            this.radioButtonNineInch.Size = new System.Drawing.Size(90, 17);
            this.radioButtonNineInch.TabIndex = 2;
            this.radioButtonNineInch.Text = "9 inch ($8.00)";
            this.radioButtonNineInch.UseVisualStyleBackColor = true;
            this.radioButtonNineInch.CheckedChanged += new System.EventHandler(this.radioButtonNineInch_CheckedChanged);
            // 
            // radioButtonSixInch
            // 
            this.radioButtonSixInch.AutoSize = true;
            this.radioButtonSixInch.Location = new System.Drawing.Point(0, 16);
            this.radioButtonSixInch.Name = "radioButtonSixInch";
            this.radioButtonSixInch.Size = new System.Drawing.Size(90, 17);
            this.radioButtonSixInch.TabIndex = 1;
            this.radioButtonSixInch.Text = "6 inch ($5.00)";
            this.radioButtonSixInch.UseVisualStyleBackColor = true;
            this.radioButtonSixInch.CheckedChanged += new System.EventHandler(this.radioButtonSixInch_CheckedChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(22, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(49, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Sub Size";
            // 
            // panelMeat
            // 
            this.panelMeat.Controls.Add(this.radioButtonClub);
            this.panelMeat.Controls.Add(this.labelMeat);
            this.panelMeat.Controls.Add(this.radioButtonRoastBeef);
            this.panelMeat.Controls.Add(this.radioButtonTurkey);
            this.panelMeat.Controls.Add(this.radioButtonHam);
            this.panelMeat.Location = new System.Drawing.Point(122, 12);
            this.panelMeat.Name = "panelMeat";
            this.panelMeat.Size = new System.Drawing.Size(104, 143);
            this.panelMeat.TabIndex = 1;
            // 
            // radioButtonClub
            // 
            this.radioButtonClub.AutoSize = true;
            this.radioButtonClub.Location = new System.Drawing.Point(0, 85);
            this.radioButtonClub.Name = "radioButtonClub";
            this.radioButtonClub.Size = new System.Drawing.Size(46, 17);
            this.radioButtonClub.TabIndex = 4;
            this.radioButtonClub.Text = "Club";
            this.radioButtonClub.UseVisualStyleBackColor = true;
            // 
            // labelMeat
            // 
            this.labelMeat.AutoSize = true;
            this.labelMeat.Location = new System.Drawing.Point(36, 0);
            this.labelMeat.Name = "labelMeat";
            this.labelMeat.Size = new System.Drawing.Size(31, 13);
            this.labelMeat.TabIndex = 0;
            this.labelMeat.Text = "Meat";
            // 
            // radioButtonRoastBeef
            // 
            this.radioButtonRoastBeef.AutoSize = true;
            this.radioButtonRoastBeef.Location = new System.Drawing.Point(0, 62);
            this.radioButtonRoastBeef.Name = "radioButtonRoastBeef";
            this.radioButtonRoastBeef.Size = new System.Drawing.Size(78, 17);
            this.radioButtonRoastBeef.TabIndex = 3;
            this.radioButtonRoastBeef.Text = "Roast Beef";
            this.radioButtonRoastBeef.UseVisualStyleBackColor = true;
            // 
            // radioButtonTurkey
            // 
            this.radioButtonTurkey.AutoSize = true;
            this.radioButtonTurkey.Location = new System.Drawing.Point(0, 39);
            this.radioButtonTurkey.Name = "radioButtonTurkey";
            this.radioButtonTurkey.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTurkey.TabIndex = 2;
            this.radioButtonTurkey.Text = "Turkey";
            this.radioButtonTurkey.UseVisualStyleBackColor = true;
            // 
            // radioButtonHam
            // 
            this.radioButtonHam.AutoSize = true;
            this.radioButtonHam.Location = new System.Drawing.Point(0, 16);
            this.radioButtonHam.Name = "radioButtonHam";
            this.radioButtonHam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHam.TabIndex = 1;
            this.radioButtonHam.Text = "Ham";
            this.radioButtonHam.UseVisualStyleBackColor = true;
            // 
            // panelCondiments
            // 
            this.panelCondiments.Controls.Add(this.labelCondiments);
            this.panelCondiments.Controls.Add(this.checkedListBoxCondiments);
            this.panelCondiments.Location = new System.Drawing.Point(232, 12);
            this.panelCondiments.Name = "panelCondiments";
            this.panelCondiments.Size = new System.Drawing.Size(103, 143);
            this.panelCondiments.TabIndex = 2;
            // 
            // labelCondiments
            // 
            this.labelCondiments.Location = new System.Drawing.Point(1, 0);
            this.labelCondiments.Name = "labelCondiments";
            this.labelCondiments.Size = new System.Drawing.Size(101, 13);
            this.labelCondiments.TabIndex = 3;
            this.labelCondiments.Text = "Condiments";
            this.labelCondiments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxCondiments
            // 
            this.checkedListBoxCondiments.CheckOnClick = true;
            this.checkedListBoxCondiments.FormattingEnabled = true;
            this.checkedListBoxCondiments.Items.AddRange(new object[] {
            "Lettuce",
            "Tomato",
            "Peppers",
            "Onions",
            "Mayo",
            "Salt",
            "Pepper"});
            this.checkedListBoxCondiments.Location = new System.Drawing.Point(0, 16);
            this.checkedListBoxCondiments.Name = "checkedListBoxCondiments";
            this.checkedListBoxCondiments.Size = new System.Drawing.Size(104, 109);
            this.checkedListBoxCondiments.TabIndex = 0;
            // 
            // panelCheese
            // 
            this.panelCheese.Controls.Add(this.checkBoxCheese);
            this.panelCheese.Controls.Add(this.radioButtonCheddar);
            this.panelCheese.Controls.Add(this.radioButtonProvolone);
            this.panelCheese.Controls.Add(this.radioButtonAmerican);
            this.panelCheese.Controls.Add(this.panelGratuity);
            this.panelCheese.Location = new System.Drawing.Point(342, 12);
            this.panelCheese.Name = "panelCheese";
            this.panelCheese.Size = new System.Drawing.Size(104, 143);
            this.panelCheese.TabIndex = 3;
            // 
            // checkBoxCheese
            // 
            this.checkBoxCheese.AutoSize = true;
            this.checkBoxCheese.Location = new System.Drawing.Point(0, 4);
            this.checkBoxCheese.Name = "checkBoxCheese";
            this.checkBoxCheese.Size = new System.Drawing.Size(98, 17);
            this.checkBoxCheese.TabIndex = 8;
            this.checkBoxCheese.Text = "Cheese ($1.00)";
            this.checkBoxCheese.UseVisualStyleBackColor = true;
            this.checkBoxCheese.CheckedChanged += new System.EventHandler(this.checkBoxCheese_CheckedChanged);
            // 
            // radioButtonCheddar
            // 
            this.radioButtonCheddar.AutoSize = true;
            this.radioButtonCheddar.Enabled = false;
            this.radioButtonCheddar.Location = new System.Drawing.Point(0, 73);
            this.radioButtonCheddar.Name = "radioButtonCheddar";
            this.radioButtonCheddar.Size = new System.Drawing.Size(65, 17);
            this.radioButtonCheddar.TabIndex = 3;
            this.radioButtonCheddar.Text = "Cheddar";
            this.radioButtonCheddar.UseVisualStyleBackColor = true;
            // 
            // radioButtonProvolone
            // 
            this.radioButtonProvolone.AutoSize = true;
            this.radioButtonProvolone.Enabled = false;
            this.radioButtonProvolone.Location = new System.Drawing.Point(0, 50);
            this.radioButtonProvolone.Name = "radioButtonProvolone";
            this.radioButtonProvolone.Size = new System.Drawing.Size(73, 17);
            this.radioButtonProvolone.TabIndex = 2;
            this.radioButtonProvolone.Text = "Provolone";
            this.radioButtonProvolone.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmerican
            // 
            this.radioButtonAmerican.AutoSize = true;
            this.radioButtonAmerican.Checked = true;
            this.radioButtonAmerican.Enabled = false;
            this.radioButtonAmerican.Location = new System.Drawing.Point(0, 27);
            this.radioButtonAmerican.Name = "radioButtonAmerican";
            this.radioButtonAmerican.Size = new System.Drawing.Size(69, 17);
            this.radioButtonAmerican.TabIndex = 1;
            this.radioButtonAmerican.TabStop = true;
            this.radioButtonAmerican.Text = "American";
            this.radioButtonAmerican.UseVisualStyleBackColor = true;
            // 
            // panelGratuity
            // 
            this.panelGratuity.Controls.Add(this.labelGratuityInitial);
            this.panelGratuity.Controls.Add(this.textBoxGratuity);
            this.panelGratuity.Location = new System.Drawing.Point(3, 113);
            this.panelGratuity.Name = "panelGratuity";
            this.panelGratuity.Size = new System.Drawing.Size(104, 27);
            this.panelGratuity.TabIndex = 7;
            // 
            // labelGratuityInitial
            // 
            this.labelGratuityInitial.AutoSize = true;
            this.labelGratuityInitial.Location = new System.Drawing.Point(3, 6);
            this.labelGratuityInitial.Name = "labelGratuityInitial";
            this.labelGratuityInitial.Size = new System.Drawing.Size(43, 13);
            this.labelGratuityInitial.TabIndex = 5;
            this.labelGratuityInitial.Text = "Gratuity";
            // 
            // textBoxGratuity
            // 
            this.textBoxGratuity.Location = new System.Drawing.Point(52, 3);
            this.textBoxGratuity.Name = "textBoxGratuity";
            this.textBoxGratuity.Size = new System.Drawing.Size(46, 20);
            this.textBoxGratuity.TabIndex = 6;
            this.textBoxGratuity.TextChanged += new System.EventHandler(this.textBoxGratuity_TextChanged);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(369, 269);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubtotal.Location = new System.Drawing.Point(1, 2);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(64, 17);
            this.labelSubtotal.TabIndex = 8;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTax.Location = new System.Drawing.Point(1, 29);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(35, 17);
            this.labelTax.TabIndex = 9;
            this.labelTax.Text = "Tax:";
            // 
            // labelGratuityFinal
            // 
            this.labelGratuityFinal.AutoSize = true;
            this.labelGratuityFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGratuityFinal.Location = new System.Drawing.Point(1, 56);
            this.labelGratuityFinal.Name = "labelGratuityFinal";
            this.labelGratuityFinal.Size = new System.Drawing.Size(62, 17);
            this.labelGratuityFinal.TabIndex = 10;
            this.labelGratuityFinal.Text = "Gratuity:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(0, 81);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total:";
            // 
            // labelSubtotalAmount
            // 
            this.labelSubtotalAmount.AutoSize = true;
            this.labelSubtotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubtotalAmount.Location = new System.Drawing.Point(155, 1);
            this.labelSubtotalAmount.Name = "labelSubtotalAmount";
            this.labelSubtotalAmount.Size = new System.Drawing.Size(44, 17);
            this.labelSubtotalAmount.TabIndex = 12;
            this.labelSubtotalAmount.Text = "$0.00";
            // 
            // labelTaxAmount
            // 
            this.labelTaxAmount.AutoSize = true;
            this.labelTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTaxAmount.Location = new System.Drawing.Point(155, 29);
            this.labelTaxAmount.Name = "labelTaxAmount";
            this.labelTaxAmount.Size = new System.Drawing.Size(44, 17);
            this.labelTaxAmount.TabIndex = 13;
            this.labelTaxAmount.Text = "$0.00";
            // 
            // labelGratuityAmount
            // 
            this.labelGratuityAmount.AutoSize = true;
            this.labelGratuityAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGratuityAmount.Location = new System.Drawing.Point(155, 56);
            this.labelGratuityAmount.Name = "labelGratuityAmount";
            this.labelGratuityAmount.Size = new System.Drawing.Size(44, 17);
            this.labelGratuityAmount.TabIndex = 14;
            this.labelGratuityAmount.Text = "$0.00";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(154, 81);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(54, 20);
            this.labelTotalAmount.TabIndex = 15;
            this.labelTotalAmount.Text = "$0.00";
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.labelTotalAmount);
            this.panelTotal.Controls.Add(this.labelGratuityAmount);
            this.panelTotal.Controls.Add(this.labelTaxAmount);
            this.panelTotal.Controls.Add(this.labelSubtotalAmount);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.labelGratuityFinal);
            this.panelTotal.Controls.Add(this.labelTax);
            this.panelTotal.Controls.Add(this.labelSubtotal);
            this.panelTotal.Location = new System.Drawing.Point(233, 161);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(213, 104);
            this.panelTotal.TabIndex = 16;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 304);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.panelCheese);
            this.Controls.Add(this.panelCondiments);
            this.Controls.Add(this.panelMeat);
            this.Controls.Add(this.panelSize);
            this.Name = "FormMainWindow";
            this.Text = "Sal\'s Subs Order Form";
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.panelMeat.ResumeLayout(false);
            this.panelMeat.PerformLayout();
            this.panelCondiments.ResumeLayout(false);
            this.panelCheese.ResumeLayout(false);
            this.panelCheese.PerformLayout();
            this.panelGratuity.ResumeLayout(false);
            this.panelGratuity.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.RadioButton radioButtonTwelveInch;
        private System.Windows.Forms.RadioButton radioButtonNineInch;
        private System.Windows.Forms.RadioButton radioButtonSixInch;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Panel panelMeat;
        private System.Windows.Forms.RadioButton radioButtonClub;
        private System.Windows.Forms.Label labelMeat;
        private System.Windows.Forms.RadioButton radioButtonRoastBeef;
        private System.Windows.Forms.RadioButton radioButtonTurkey;
        private System.Windows.Forms.RadioButton radioButtonHam;
        private System.Windows.Forms.Panel panelCondiments;
        private System.Windows.Forms.Label labelCondiments;
        private System.Windows.Forms.Panel panelCheese;
        private System.Windows.Forms.RadioButton radioButtonProvolone;
        private System.Windows.Forms.RadioButton radioButtonAmerican;
        private System.Windows.Forms.RadioButton radioButtonCheddar;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelGratuityInitial;
        private System.Windows.Forms.TextBox textBoxGratuity;
        private System.Windows.Forms.Panel panelGratuity;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelGratuityFinal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubtotalAmount;
        private System.Windows.Forms.Label labelTaxAmount;
        private System.Windows.Forms.Label labelGratuityAmount;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.CheckedListBox checkedListBoxCondiments;
        private System.Windows.Forms.CheckBox checkBoxCheese;

    }
}


namespace Methods_Exercise
{
    partial class Shirt_customization
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
            this.txtShirtsize = new System.Windows.Forms.ComboBox();
            this.txtPlainshirtprice = new System.Windows.Forms.TextBox();
            this.btnClearControls = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomizationtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomizedShirtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomizationCharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.rtfRECEIPT = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplayReceipt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textCharacters = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalcharge = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHIRT CUSTOMIZATION SALE APP";
            // 
            // txtShirtsize
            // 
            this.txtShirtsize.FormattingEnabled = true;
            this.txtShirtsize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.txtShirtsize.Location = new System.Drawing.Point(247, 110);
            this.txtShirtsize.Name = "txtShirtsize";
            this.txtShirtsize.Size = new System.Drawing.Size(144, 21);
            this.txtShirtsize.TabIndex = 3;
            this.txtShirtsize.SelectedIndexChanged += new System.EventHandler(this.txtShirtsize_SelectedIndexChanged);
            // 
            // txtPlainshirtprice
            // 
            this.txtPlainshirtprice.Location = new System.Drawing.Point(247, 154);
            this.txtPlainshirtprice.Name = "txtPlainshirtprice";
            this.txtPlainshirtprice.Size = new System.Drawing.Size(144, 20);
            this.txtPlainshirtprice.TabIndex = 4;
            // 
            // btnClearControls
            // 
            this.btnClearControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearControls.Location = new System.Drawing.Point(45, 446);
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.Size = new System.Drawing.Size(155, 23);
            this.btnClearControls.TabIndex = 5;
            this.btnClearControls.Text = "CLEAR CONTROLS";
            this.btnClearControls.UseVisualStyleBackColor = true;
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "CUSTOMIZATION TEXT";
            // 
            // txtCustomizationtext
            // 
            this.txtCustomizationtext.Location = new System.Drawing.Point(247, 195);
            this.txtCustomizationtext.Name = "txtCustomizationtext";
            this.txtCustomizationtext.Size = new System.Drawing.Size(144, 20);
            this.txtCustomizationtext.TabIndex = 7;
            this.txtCustomizationtext.TextChanged += new System.EventHandler(this.txtCustomizationtext_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "PLAIN SHIRT PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "CUSTOMIZED SHIRT PRICE";
            // 
            // txtCustomizedShirtPrice
            // 
            this.txtCustomizedShirtPrice.Location = new System.Drawing.Point(247, 312);
            this.txtCustomizedShirtPrice.Name = "txtCustomizedShirtPrice";
            this.txtCustomizedShirtPrice.Size = new System.Drawing.Size(144, 20);
            this.txtCustomizedShirtPrice.TabIndex = 4;
            this.txtCustomizedShirtPrice.TextChanged += new System.EventHandler(this.txtCustomizedShirtPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "CUSTOMIZATION CHARGE/\r\nCHARACTER";
            // 
            // txtCustomizationCharge
            // 
            this.txtCustomizationCharge.Location = new System.Drawing.Point(247, 267);
            this.txtCustomizationCharge.Name = "txtCustomizationCharge";
            this.txtCustomizationCharge.Size = new System.Drawing.Size(144, 20);
            this.txtCustomizationCharge.TabIndex = 7;
            this.txtCustomizationCharge.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "QUANTITY";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(247, 354);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(144, 20);
            this.txtquantity.TabIndex = 4;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // rtfRECEIPT
            // 
            this.rtfRECEIPT.Location = new System.Drawing.Point(411, 110);
            this.rtfRECEIPT.Name = "rtfRECEIPT";
            this.rtfRECEIPT.Size = new System.Drawing.Size(377, 299);
            this.rtfRECEIPT.TabIndex = 8;
            this.rtfRECEIPT.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 9;
            // 
            // btnDisplayReceipt
            // 
            this.btnDisplayReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayReceipt.Location = new System.Drawing.Point(505, 446);
            this.btnDisplayReceipt.Name = "btnDisplayReceipt";
            this.btnDisplayReceipt.Size = new System.Drawing.Size(155, 23);
            this.btnDisplayReceipt.TabIndex = 5;
            this.btnDisplayReceipt.Text = "DISPLAY RECEIPT";
            this.btnDisplayReceipt.UseVisualStyleBackColor = true;
            this.btnDisplayReceipt.Click += new System.EventHandler(this.btnDisplayReceipt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "SHIRT SIZE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number of characters";
            // 
            // textCharacters
            // 
            this.textCharacters.Location = new System.Drawing.Point(247, 230);
            this.textCharacters.Name = "textCharacters";
            this.textCharacters.Size = new System.Drawing.Size(144, 20);
            this.textCharacters.TabIndex = 4;
            this.textCharacters.TextChanged += new System.EventHandler(this.textCharacters_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "TOTAL CHARGE";
            // 
            // txtTotalcharge
            // 
            this.txtTotalcharge.Location = new System.Drawing.Point(247, 390);
            this.txtTotalcharge.Name = "txtTotalcharge";
            this.txtTotalcharge.Size = new System.Drawing.Size(144, 20);
            this.txtTotalcharge.TabIndex = 4;
            // 
            // Shirt_customization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtfRECEIPT);
            this.Controls.Add(this.txtCustomizationCharge);
            this.Controls.Add(this.txtCustomizationtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplayReceipt);
            this.Controls.Add(this.btnClearControls);
            this.Controls.Add(this.txtTotalcharge);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.textCharacters);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustomizedShirtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlainshirtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShirtsize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Name = "Shirt_customization";
            this.Text = "Shirt customization sale app";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtShirtsize;
        private System.Windows.Forms.TextBox txtPlainshirtprice;
        private System.Windows.Forms.Button btnClearControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomizationtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomizedShirtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomizationCharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.RichTextBox rtfRECEIPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplayReceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCharacters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalcharge;
    }
}


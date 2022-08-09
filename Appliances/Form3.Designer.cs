
namespace Appliances
{
    partial class TransactionForm
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
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.AmountTenderedTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AmountTendered = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitPriceListBox = new System.Windows.Forms.ListBox();
            this.ApplianceSoldListBox = new System.Windows.Forms.ListBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ChargeButton = new System.Windows.Forms.Button();
            this.CashButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AppliancesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(477, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "label11";
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Enabled = false;
            this.ChangeTextBox.Location = new System.Drawing.Point(616, 462);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(131, 25);
            this.ChangeTextBox.TabIndex = 76;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeButton.Location = new System.Drawing.Point(366, 462);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(93, 34);
            this.ChangeButton.TabIndex = 75;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // AmountTenderedTextBox
            // 
            this.AmountTenderedTextBox.Location = new System.Drawing.Point(616, 409);
            this.AmountTenderedTextBox.Name = "AmountTenderedTextBox";
            this.AmountTenderedTextBox.Size = new System.Drawing.Size(131, 25);
            this.AmountTenderedTextBox.TabIndex = 74;
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Enabled = false;
            this.TotalAmountTextBox.Location = new System.Drawing.Point(616, 374);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(131, 25);
            this.TotalAmountTextBox.TabIndex = 73;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Location = new System.Drawing.Point(635, 306);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(112, 25);
            this.SubtotalTextBox.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(649, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "Sub-total:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Enabled = false;
            this.AmountTextBox.Location = new System.Drawing.Point(635, 120);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(112, 25);
            this.AmountTextBox.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(649, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Amount";
            // 
            // AmountTendered
            // 
            this.AmountTendered.AutoSize = true;
            this.AmountTendered.BackColor = System.Drawing.Color.Transparent;
            this.AmountTendered.Location = new System.Drawing.Point(363, 409);
            this.AmountTendered.Name = "AmountTendered";
            this.AmountTendered.Size = new System.Drawing.Size(135, 20);
            this.AmountTendered.TabIndex = 68;
            this.AmountTendered.Text = "Amount Tendered:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(363, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Total Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(496, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Unit Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(353, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Appliance Sold:";
            // 
            // UnitPriceListBox
            // 
            this.UnitPriceListBox.FormattingEnabled = true;
            this.UnitPriceListBox.ItemHeight = 19;
            this.UnitPriceListBox.Location = new System.Drawing.Point(480, 120);
            this.UnitPriceListBox.Name = "UnitPriceListBox";
            this.UnitPriceListBox.Size = new System.Drawing.Size(139, 213);
            this.UnitPriceListBox.TabIndex = 64;
            // 
            // ApplianceSoldListBox
            // 
            this.ApplianceSoldListBox.FormattingEnabled = true;
            this.ApplianceSoldListBox.ItemHeight = 19;
            this.ApplianceSoldListBox.Location = new System.Drawing.Point(340, 120);
            this.ApplianceSoldListBox.Name = "ApplianceSoldListBox";
            this.ApplianceSoldListBox.Size = new System.Drawing.Size(139, 213);
            this.ApplianceSoldListBox.TabIndex = 63;
            // 
            // ComputeButton
            // 
            this.ComputeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ComputeButton.Location = new System.Drawing.Point(236, 409);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(98, 68);
            this.ComputeButton.TabIndex = 62;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = false;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.Location = new System.Drawing.Point(243, 334);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 44);
            this.CloseButton.TabIndex = 61;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearButton.Location = new System.Drawing.Point(243, 250);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 44);
            this.ClearButton.TabIndex = 60;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewButton.Location = new System.Drawing.Point(243, 173);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 44);
            this.NewButton.TabIndex = 59;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(243, 120);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(75, 25);
            this.QuantityNumericUpDown.TabIndex = 58;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(240, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Quantity";
            // 
            // ChargeButton
            // 
            this.ChargeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChargeButton.Location = new System.Drawing.Point(145, 473);
            this.ChargeButton.Name = "ChargeButton";
            this.ChargeButton.Size = new System.Drawing.Size(75, 36);
            this.ChargeButton.TabIndex = 56;
            this.ChargeButton.Text = "Charge";
            this.ChargeButton.UseVisualStyleBackColor = false;
            this.ChargeButton.Click += new System.EventHandler(this.ChargeButton_Click);
            // 
            // CashButton
            // 
            this.CashButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CashButton.Location = new System.Drawing.Point(54, 473);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(75, 36);
            this.CashButton.TabIndex = 55;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = false;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(77, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Type of Payment";
            // 
            // AppliancesListBox
            // 
            this.AppliancesListBox.FormattingEnabled = true;
            this.AppliancesListBox.ItemHeight = 19;
            this.AppliancesListBox.Items.AddRange(new object[] {
            "Air Conditioner",
            "Electric Fan",
            "Electric Pot",
            "Electric Stove",
            "Flat Iron",
            "Karaoke",
            "Microwave Oven",
            "Mini Component",
            "Oven Toaster",
            "Refrigerator",
            "Rice Cooker",
            "Television",
            "VCD Player",
            "Washing Machine"});
            this.AppliancesListBox.Location = new System.Drawing.Point(54, 120);
            this.AppliancesListBox.Name = "AppliancesListBox";
            this.AppliancesListBox.Size = new System.Drawing.Size(166, 289);
            this.AppliancesListBox.TabIndex = 53;
            this.AppliancesListBox.DoubleClick += new System.EventHandler(this.AppliancesListBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Appliances:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(612, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "<Insert Time and Date>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "User Name:    Charisse Oblefias";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Appliances.Properties.Resources._053063327ec3af7c075e81763026d438;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AmountTenderedTextBox);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AmountTendered);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UnitPriceListBox);
            this.Controls.Add(this.ApplianceSoldListBox);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChargeButton);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppliancesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox AmountTenderedTextBox;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AmountTendered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox UnitPriceListBox;
        private System.Windows.Forms.ListBox ApplianceSoldListBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChargeButton;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox AppliancesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
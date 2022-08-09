using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliances
{
	public partial class TransactionForm : Form
	{
		public TransactionForm()
		{
			InitializeComponent();
			label11.Visible = false;
			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label2.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
		}

		private void AppliancesListBox_DoubleClick(object sender, EventArgs e)
		{
			if (AppliancesListBox.SelectedItem.ToString() == "Air Conditioner")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("10000");

			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Electric Fan")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("500");

			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Electric Pot")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("800");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Electric Stove")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("1000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Flat Iron")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("350");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Karaoke")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("2500");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Microwave Oven")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("3000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Mini Component")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("3500");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Oven Toaster")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("550");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Refrigerator")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("9000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Rice Cooker")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("600");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Television")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("5000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "VCD Player")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("1200");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Washing Machine")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("4000");
			}
		}

		private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			decimal amount = 0;

			if (QuantityNumericUpDown.Value <= 0)
			{
				MessageBox.Show("Please input a quantity");
			}
			else
			{
				for (int i = 0; i < UnitPriceListBox.Items.Count; i++)
				{
					amount = Convert.ToDecimal(UnitPriceListBox.Items[i]) * QuantityNumericUpDown.Value;
				}
				AmountTextBox.Text = amount.ToString();
			}
		}

		private void ComputeButton_Click(object sender, EventArgs e)
		{
			decimal sum = 0;
			for (int i = 0; i < UnitPriceListBox.Items.Count; i++)
			{
				sum += Convert.ToDecimal(UnitPriceListBox.Items[i]) * QuantityNumericUpDown.Value;
			}
			SubtotalTextBox.Text = sum.ToString();

			ComputeButton.Enabled = false;
		}

		private void CashButton_Click(object sender, EventArgs e)
		{
			double subtotal = Convert.ToDouble(SubtotalTextBox.Text);
			double totalamount = subtotal - (subtotal * 0.5);
			TotalAmountTextBox.Text = totalamount.ToString();

			NewButton.Enabled = true;
			ClearButton.Enabled = true;
			CloseButton.Enabled = true;
			ComputeButton.Enabled = true;
			CashButton.Enabled = false;
		}

		private void ChargeButton_Click(object sender, EventArgs e)
		{
			label8.Visible = false;
			AmountTendered.Visible = false;
			TotalAmountTextBox.Visible = false;
			AmountTenderedTextBox.Visible = false;
			ChangeButton.Visible = false;
			ChangeTextBox.Visible = false;
			label11.Visible = true;
			label11.Text = "5% Additional to all charge payment";
			ChargeButton.Enabled = true;
			CashButton.Enabled = false;
		}

		private void ChangeButton_Click(object sender, EventArgs e)
		{
			int amounttendered = Convert.ToInt16(AmountTenderedTextBox.Text);
			int totalamount = Convert.ToInt16(TotalAmountTextBox.Text);

			if (amounttendered < totalamount)
			{
				MessageBox.Show("Please enter valid amount");
			}
			else
			{
				int change = amounttendered - totalamount;
				ChangeTextBox.Text = change.ToString();
			}

			ChangeButton.Enabled = false;
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			AmountTextBox.Clear();
			SubtotalTextBox.Clear();
			TotalAmountTextBox.Clear();
			AmountTenderedTextBox.Clear();
			ChangeTextBox.Clear();
			ApplianceSoldListBox.Items.Clear();
			UnitPriceListBox.Items.Clear();
			label11.Visible = false;
			label8.Visible = true;
			AmountTendered.Visible = true;
			TotalAmountTextBox.Visible = true;
			AmountTenderedTextBox.Visible = true;
			ChangeButton.Visible = true;
			ChangeTextBox.Visible = true;
			CashButton.Enabled = true;
			QuantityNumericUpDown.ResetText();
			ApplianceSoldListBox.Items.Clear();
			UnitPriceListBox.Items.Clear();
			CashButton.Enabled = true;
			ChargeButton.Enabled = true;
			ComputeButton.Enabled = true;
			ChangeButton.Enabled = true;
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			QuantityNumericUpDown.ResetText();
			ApplianceSoldListBox.Items.Clear();
			UnitPriceListBox.Items.Clear();
			CashButton.Enabled = true;
			ChargeButton.Enabled = true;
			ComputeButton.Enabled = true;
			ChangeButton.Enabled = true;
		}

        private void CloseButton_Click(object sender, EventArgs e)
        {
			this.Hide();
		}
    }
}

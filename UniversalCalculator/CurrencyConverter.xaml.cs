using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// A currency converter feature for the calculator app
	/// </summary>

	/* Michael Bradbury
	* 000501031
	* 21/03/2022
	*/

	public sealed partial class CurrencyConverter : Page
	{
		public CurrencyConverter()
		{
			this.InitializeComponent();
		}

		private void btnConvert_Click(object sender, RoutedEventArgs e)
		{
			// constants for USD conversion
			double USD_TO_EUR = 0.85189982;
			double USD_TO_GBP = 0.72872436;
			double USD_TO_INR = 74.257327;

			// constations for EUR conversion
			double EUR_TO_USD = 1.1739732;
			double EUR_TO_GBP = 0.8556672;
			double EUR_TO_INR = 87.00755;

			// constants for GBP conversion
			double GBP_TO_USD = 1.371907;
			double GBP_TO_EUR = 1.1686692;
			double GBP_TO_INR = 101.68635;

			// constants for INR convesion
			double INR_TO_USD = 0.011492628;
			double INR_TO_EUR = 0.013492774;
			double INR_TO_GBP = 0.0098339397;

			// variables for conversion
			double amount1; // the input value
			double amount2; // the output (converted) value

			amount1 = double.Parse(txtboxAmount.Text); // parsing the input value from textbox

			// calculation if USD is selected in first combobox
			if (cmbitemUSD1.IsSelected)
			{
				txtblkAmount.Text = amount1 + " US Dollars =";

				if(cmbitemEUR2.IsSelected) // if EUR is selected in second combobox
				{
					amount2 = amount1 * USD_TO_EUR;
					txtblkConverted.Text = amount2 + " Euros";
					txtblkCalculation1.Text = "1 US Dollar = " + USD_TO_EUR + " Euros";
					txtblkCalculation2.Text = "1 Euro = " + EUR_TO_USD + " US Dollars";
				}

				if(cmbitemGBP2.IsSelected) // if GBP is selected in second combobox
				{
					amount2 = amount1 * USD_TO_GBP;
					txtblkConverted.Text = amount2 + " British Pounds";
					txtblkCalculation1.Text = "1 US Dollar = " + USD_TO_GBP + " British Pounds";
					txtblkCalculation2.Text = "1 British Pound = " + GBP_TO_USD + " US Dollars";
				}

				if(cmbitemINR2.IsSelected) // if INR is selected in second combobox
				{
					amount2 = amount1 * USD_TO_INR;
					txtblkConverted.Text = amount2 + " Indian Rupees";
					txtblkCalculation1.Text = "1 US Dollar = " + USD_TO_INR + " Indian Rupees";
					txtblkCalculation2.Text = "1 Indian Rupee = " + INR_TO_USD + " US Dollars";
				}

				if(cmbitemUSD2.IsSelected) // if USD is selected in second combobox
				{
					amount2 = amount1;
					txtblkConverted.Text = amount2 + " US Dollars";
					txtblkCalculation1.Text = "1 US Dollar = 1 US Dollar";
					txtblkCalculation2.Text = "1 US Dollar = 1 US Dollar";
				}
			}

			// calculation if EUR is selected in first combobox
			if (cmbitemEUR1.IsSelected)
			{
				txtblkAmount.Text = amount1 + " Euros =";

				if (cmbitemEUR2.IsSelected) // if EUR is selected in second combobox
				{
					amount2 = amount1;
					txtblkConverted.Text = amount2 + " Euros";
					txtblkCalculation1.Text = "1 Euro = 1 Euro";
					txtblkCalculation2.Text = "1 Euro = 1 Euro";
				}
				if (cmbitemGBP2.IsSelected) // if GBP is selected in second combobox
				{
					amount2 = amount1 * EUR_TO_GBP;
					txtblkConverted.Text = amount2 + " British Pounds";
					txtblkCalculation1.Text = "1 Euro = " + EUR_TO_GBP + " British Pounds";
					txtblkCalculation2.Text = "1 British Pound = " + GBP_TO_EUR + " Euros";
				}

				if (cmbitemINR2.IsSelected) // if INR is selected in second combobox
				{
					amount2 = amount1 * EUR_TO_INR;
					txtblkConverted.Text = amount2 + " Indian Rupees";
					txtblkCalculation1.Text = "1 Euro = " + EUR_TO_INR + " Indian Rupees";
					txtblkCalculation2.Text = "1 Indian Rupee = " + INR_TO_EUR + " Euros";
				}

				if (cmbitemUSD2.IsSelected) // if USD is selected in second combobox
				{
					amount2 = amount1 * EUR_TO_USD;
					txtblkConverted.Text = amount2 + " US Dollars";
					txtblkCalculation1.Text = "1 Euro = " + EUR_TO_USD + " US Dollars";
					txtblkCalculation2.Text = "1 US Dollar = " + USD_TO_EUR + " Euros";
				}
			}

			// calculation if GBP is selected in first combobox
			if (cmbitemGBP1.IsSelected)
			{
				txtblkAmount.Text = amount1 + " British Pounds =";

				if (cmbitemEUR2.IsSelected) // if EUR is selected in second combobox
				{
					amount2 = amount1 * GBP_TO_EUR;
					txtblkConverted.Text = amount2 + " Euros";
					txtblkCalculation1.Text = "1 British Pound = " + GBP_TO_EUR + " Euros";
					txtblkCalculation2.Text = "1 Euro = " + EUR_TO_GBP + " British Pounds";
				}

				if (cmbitemGBP2.IsSelected) // if GBP is selected in second combobox
				{
					amount2 = amount1;
					txtblkConverted.Text = amount2 + " British Pounds";
					txtblkCalculation1.Text = "1 British Pound = 1 British Pound";
					txtblkCalculation2.Text = "1 British Pound = 1 British Pound";
				}

				if (cmbitemINR2.IsSelected) // if INR is selected in second combobox
				{
					amount2 = amount1 * GBP_TO_INR;
					txtblkConverted.Text = amount2 + " Indian Rupees";
					txtblkCalculation1.Text = "1 British Pound = " + GBP_TO_INR + " Indian Rupees";
					txtblkCalculation2.Text = "1 Indian Rupee = " + INR_TO_GBP + " British Pounds";
				}

				if (cmbitemUSD2.IsSelected) // if USD is selected in second combobox
				{
					amount2 = amount1 * GBP_TO_USD;
					txtblkConverted.Text = amount2 + " US Dollars";
					txtblkCalculation1.Text = "1 British Pound = " + GBP_TO_USD + " US Dollars";
					txtblkCalculation2.Text = "1 US Dollar = " + USD_TO_GBP + " British Pounds";
				}
			}

			// calculation if INR is selected in first combobox
			if (cmbitemINR1.IsSelected)
			{
				txtblkAmount.Text = amount1 + " Indian Rupees =";

				if (cmbitemEUR2.IsSelected) // if EUR is selected in second combobox
				{
					amount2 = amount1 * INR_TO_EUR;
					txtblkConverted.Text = amount2 + " Euros";
					txtblkCalculation1.Text = "1 Indian Rupees = " + INR_TO_EUR + " Euros";
					txtblkCalculation2.Text = "1 Euro = " + EUR_TO_INR + " Indian Rupees";
				}

				if (cmbitemGBP2.IsSelected) // if GBP is selected in second combobox
				{
					amount2 = amount1 * INR_TO_GBP;
					txtblkConverted.Text = amount2 + " British Pounds";
					txtblkCalculation1.Text = "1 Indian Rupees = " + INR_TO_GBP + " British Pounds";
					txtblkCalculation2.Text = "1 British Pound = " + GBP_TO_INR + " Indian Rupees";
				}

				if (cmbitemINR2.IsSelected) // if INR is selected in second combobox
				{
					amount2 = amount1;
					txtblkConverted.Text = amount2 + " Indian Rupees";
					txtblkCalculation1.Text = "1 Indian Rupee = 1 Indian Rupee";
					txtblkCalculation2.Text = "1 Indian Rupee = 1 Indian Rupee";
				}

				if (cmbitemUSD2.IsSelected) // if USD is selected in second combobox
				{
					amount2 = amount1 * INR_TO_USD;
					txtblkConverted.Text = amount2 + " Indian Rupees";
					txtblkCalculation1.Text = "1 Indian Rupee = " + INR_TO_USD + " US Dollars";
					txtblkCalculation2.Text = "1 US Dollar = " + USD_TO_INR + " Indian Rupees";
				}
			}
		}

		private void btnExit_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}

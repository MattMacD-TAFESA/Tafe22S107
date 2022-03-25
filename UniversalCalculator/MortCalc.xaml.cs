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
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortCalc : Page
	{
		public MortCalc()
		{
			this.InitializeComponent();
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}

		private void calcMortButton_Click(object sender, RoutedEventArgs e)
		{
			double principalLoanamount;
			double monthlyInterestRate;
			double monthstoRepay;
			double monthlyPayment;

			monthstoRepay = (double.Parse(yearTextBox.Text) * 12) + double.Parse(monthTextBox.Text);
			

			monthlyInterestRate = (double.Parse(yearlyInterestTextBox.Text)) / 1200;

			principalLoanamount = double.Parse(principalBorrowTextBox.Text);

			monthlyPayment = CalculateMortgageRepayment(principalLoanamount, monthlyInterestRate, monthstoRepay);

			monthlyInterestTextBox.Text = monthlyInterestRate.ToString("P");
			monthlyRepaymentTextBox.Text = monthlyPayment.ToString("C");


		}

		private double CalculateMortgageRepayment(double P, double i, double n)
		{
			double M = P * i * (Math.Pow(1 + i, n) / (Math.Pow(1 + i, n - 1)));
			return M;
		}
	}
}

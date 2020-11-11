using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;

namespace assignment_6
{
    public partial class MainPage : ContentPage
    {
        Bank capitec;
        Customer CustomerZ;
        BankAccount account;
        public MainPage()
        {
            InitializeComponent();
            capitec = new Bank("Capitec", 4324, "CapeTown");

            CustomerZ = new Customer("10111911", "24 cops street", "Jonny", "Depp");

            capitec.AddCustomer(CustomerZ);
            account = CustomerZ.ApplyForBankAccount();
  
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            decimal cash = Decimal.Parse(amountWithdraw.Text.ToString());
            string reason = withdrawReason.Text.ToString();

            account.WithdrawMoney(cash, DateTime.Now, reason);
        }

      

        private void Button_Clicked_TransactionButton(object sender, EventArgs e)
        {
            string history = account.GetTransactionHistory();
            TransactionHistory.Text = history;
        }

        private void Button_Clicked_WithdrawButton(object sender, EventArgs e)
        {
            decimal cash = Decimal.Parse(amountDeopsit.Text.ToString());
            string reason = reasonDeposit.Text.ToString();

            account.WithdrawMoney(cash, DateTime.Now, reason);
        }
    }
}

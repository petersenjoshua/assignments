using System.Collections.Generic;

namespace Banking
{
    public class Bank
    {
        private string v;

        public string BankName { get; set; }
        public int BranchCode { get; set; }
        public string BranchName { get; set; }

        private List<Customer> BankingCustomers { get; set; }

        public Bank(string bankName, int branchCode, string branchName)
        {
            BankName = bankName;
            BranchCode = branchCode;
            BranchName = branchName; 

            BankingCustomers = new List<Customer>();   
        }

        public Bank(string v)
        {
            this.v = v;
        }

        public void AddCustomer(Customer customer)
        {
            BankingCustomers.Add(customer);
        }
    }
}
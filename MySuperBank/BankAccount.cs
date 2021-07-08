﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;

        }
        public void MakeDeposit(decimal amount, DateTime date, string note )
        {

        }
        public void WithDrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}

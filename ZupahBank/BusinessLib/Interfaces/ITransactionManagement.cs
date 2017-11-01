﻿using BusinessLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Interfaces
{
    interface ITransactionManagement
    {
        void CreateTransaction(Account fromAccount, Account toAccount, decimal amount);
    }
}

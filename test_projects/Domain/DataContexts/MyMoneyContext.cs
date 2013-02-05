using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Domain.MyMoney;

namespace Domain.DataContexts
{
    public class MyMoneyContext : DbContext
    {
        public MyMoneyContext()
            : base("MyMoneyContext")
        {
        }

        public DbSet<JournalPayment> JournalPayments { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Prioritet> Prioritets { get; set; }
        public DbSet<Balance> Balance { get; set; }
    }
}

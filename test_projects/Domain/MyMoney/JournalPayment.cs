using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.MyMoney
{
    public class JournalPayment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public int OperationTypeId { get; set; }
        public string Description { get; set; }
        public int PrioritetId { get; set; }
    }
}

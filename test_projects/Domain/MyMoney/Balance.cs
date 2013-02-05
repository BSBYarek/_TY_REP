using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.MyMoney
{
    public class Balance
    {
        public int Id { get; set; }
        public decimal Summa { get; set; }
        public DateTime DateTime { get; set; }
    }
}

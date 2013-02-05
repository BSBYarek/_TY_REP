using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.MyMoney
{
    public class OperationType
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string NameShort { get; set; }
        public string NameLong { get; set; }
        public bool Income { get; set; }
        public int ParentId { get; set; }
    }
}

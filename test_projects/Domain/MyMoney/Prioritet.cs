using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain.MyMoney
{
    public class Prioritet
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public int Name { get; set; }
    }
}

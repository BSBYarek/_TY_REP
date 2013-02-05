using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IBaseService
    {
        Service Service { get; set; }
    }

    public class BaseService : IBaseService
    {
        public Service Service { get; set; }
    }
}

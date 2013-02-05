using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services.MyMoney;

namespace Services
{
    public interface IService : IDisposable
    {
        BookService BookServices { get; }
        FlowerService FlowerService { get; }
        MyMoneyService MyMoneyService { get; }
    }
}

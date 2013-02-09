using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Domain.MyMoney;

namespace Services.MyMoney
{
    public interface IMyMoneyInterface
    {
        JournalPayment GetJournalPaymentById(int id);
        void AddJournalPayment(JournalPayment journalPayment);
        Balance GetBalanceByDateTime(DateTime dateTime);
        void AddBalance(Balance balance);
        OperationType GetOperationTypeById(int id);
        void AddOperationType(OperationType operationType);
        Prioritet GetPrioritetById(int id);
        void AddPrioritet(Prioritet prioritet);

        List<JournalPayment> GetAllJournalPaymentsByDate(DateTime dateTime);

    }
    public class MyMoneyService:BaseService,IMyMoneyInterface
    {

        public JournalPayment GetJournalPaymentById(int id)
        {
            return Service.MyMoneyContext.JournalPayments.Find(id);
        }

        public void AddJournalPayment(JournalPayment journalPayment)
        {
            if (journalPayment!=null) Service.MyMoneyContext.JournalPayments.Add(journalPayment);
            Service.Commit();
        }

        public Balance GetBalanceByDateTime(DateTime dateTime)
        {
            return Service.MyMoneyContext.Balance.FirstOrDefault(_ => _.DateTime == dateTime);
        }

        public void AddBalance(Balance balance)
        {
            if (balance != null) Service.MyMoneyContext.Balance.Add(balance);
            Service.Commit();
        }

        public OperationType GetOperationTypeById(int id)
        {
            return Service.MyMoneyContext.OperationTypes.Find(id);
        }

        public void AddOperationType(OperationType operationType)
        {
            if (operationType != null) Service.MyMoneyContext.OperationTypes.Add(operationType);
            Service.Commit();
        }
        
        public Prioritet GetPrioritetById(int id)
        {
            return Service.MyMoneyContext.Prioritets.Find(id);
        }

        public void AddPrioritet(Prioritet prioritet)
        {
            if (prioritet != null) Service.MyMoneyContext.Prioritets.Add(prioritet);
        }

        public List<JournalPayment> GetAllJournalPaymentsByDate(DateTime dateTime)
        {
            return (from jp in Service.MyMoneyContext.JournalPayments
                    where EntityFunctions.TruncateTime(jp.DateTime) == dateTime.Date
                    select jp).ToList();
        }
    }
}

using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;
using System.Data;

namespace InventoryManagementSystem.Core
{
    class TransactionService:ITransactionService
    {
        private static TransactionDataAccess transactionDataAccess = null;

        public TransactionService()
        {
            if (TransactionService.transactionDataAccess == null)
            {
                TransactionService.transactionDataAccess = new TransactionDataAccess();
            }
        }

        public int Add(Entity.Transaction transaction)
        {
            return TransactionService.transactionDataAccess.Add(transaction);
        }

        public int AddWithoutOfferID(Entity.Transaction transaction)
        {
            return TransactionService.transactionDataAccess.AddWithoutOfferID(transaction);
        }

        public List<Entity.Transaction> GetAll()
        {
            return TransactionService.transactionDataAccess.GetAll();
        }

        public DataTable GetReportData()
        {
            return TransactionService.transactionDataAccess.GetReportData();
        }

        public int Remove(int id)
        {
            return TransactionService.transactionDataAccess.Remove(id);
        }
    }
}

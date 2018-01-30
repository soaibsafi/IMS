using InventoryManagementSystem.Entity;
using System.Collections.Generic;
using System.Data;

namespace InventoryManagementSystem.Core
{
    public interface ITransactionService
    {
        int Add(Transaction transaction);
        int Remove(int id);
        List<Transaction> GetAll();
        DataTable GetReportData();
        int AddWithoutOfferID(Entity.Transaction transaction);
    }
}

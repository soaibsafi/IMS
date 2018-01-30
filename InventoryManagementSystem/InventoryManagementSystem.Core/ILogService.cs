using InventoryManagementSystem.Entity;
using System.Collections.Generic;
using System.Data;

namespace InventoryManagementSystem.Core
{
    public interface ILogService
    {
        int Add(Log log);
        int Remove(int id);
        int Edit(Log log);
        List<Log> GetAll();
        DataTable GetItemLogData();
        DataTable GetStockLogData();
        DataTable GetAccountLogData();
        DataTable GetLoginHistoryData();
    }
}

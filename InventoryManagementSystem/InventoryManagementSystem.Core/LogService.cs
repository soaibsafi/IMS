using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;
using System.Data;

namespace InventoryManagementSystem.Core
{
    class LogService:ILogService
    {
        private static LogDataAccess logDataAccess = null;

        public LogService()
        {
            if (LogService.logDataAccess == null)
            {
                LogService.logDataAccess = new LogDataAccess();
            }
        }

        public int Add(Entity.Log log)
        {
            return LogService.logDataAccess.Add(log);
        }

        public int Edit(Entity.Log log)
        {
            return LogService.logDataAccess.Edit(log);
        }

        public DataTable GetAccountLogData()
        {
            return LogService.logDataAccess.GetAccountLogData();
        }

        public List<Entity.Log> GetAll()
        {
            return LogService.logDataAccess.GetAll();
        }

        public DataTable GetItemLogData()
        {
            return LogService.logDataAccess.GetItemLogData();
        }

        public DataTable GetLoginHistoryData()
        {
            return LogService.logDataAccess.GetLoginHistoryData();
        }

        public DataTable GetStockLogData()
        {
            return LogService.logDataAccess.GetStockLogData();
        }

        public int Remove(int id)
        {
            return LogService.logDataAccess.Remove(id);
        }
    }
}

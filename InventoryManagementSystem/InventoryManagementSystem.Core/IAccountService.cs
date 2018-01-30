using InventoryManagementSystem.Entity;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    public interface IAccountService
    {
        int Add(Account account);
        int Remove(string id);
        int Edit(Account account);
        List<Account> GetAllSortedByAccountName();
        List<Account> GetAll();
        Account GetByUsernamePassword(string username, string password);
        List<string> GetUserNameList();
        int  checkValidUser(string dept, string email);
        string ValidUserPass(string userName);
    }
}

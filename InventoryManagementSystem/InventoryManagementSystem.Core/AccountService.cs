using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    class AccountService:IAccountService
    {
        private static AccountDataAccess accountDataAccess = null;

        public AccountService()
        {
            if (AccountService.accountDataAccess == null)
            {
                AccountService.accountDataAccess = new AccountDataAccess();
            }
        }

        public int Add(Entity.Account account)
        {
            return AccountService.accountDataAccess.Add(account);
        }

        public int Edit(Entity.Account account)
        {
            return AccountService.accountDataAccess.Edit(account);
        }

        public List<Entity.Account> GetAll()
        {
            return AccountService.accountDataAccess.GetAll();
        }

        public List<Entity.Account> GetAllSortedByAccountName()
        {
            List<Entity.Account> itemList = AccountService.accountDataAccess.GetAll();
            itemList.Sort(new AccountNameComparer());
            return itemList;
        }

        public Entity.Account GetByUsernamePassword(string username, string password)
        {
            return AccountService.accountDataAccess.GetByUsernamePassword(username, password);
        }

        public int Remove(string id)
        {
            return AccountService.accountDataAccess.Remove(id);
        }
        public List<string> GetUserNameList()
        {
            return accountDataAccess.GetUserNameList();
        }

        public  int checkValidUser(string dept, string email)   //method added 
        {
            return accountDataAccess.checkValidUser(dept, email);
        }
        public string ValidUserPass(string userName)
        {
            return accountDataAccess.ValidUserPass(userName);
        }
    }
    class AccountNameComparer : IComparer<Entity.Account>
    {
        public int Compare(Entity.Account x, Entity.Account y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
    }
}

using System;

namespace InventoryManagementSystem.Core
{
    public class ServiceFactory
    {
        public IAccountService GetAccountServiceInstance()
        {
            return new AccountService();
        }
        public ICategoryService GetCategoryServiceInstance()
        {
            return new CategoryService();
        }
        public IItemService GetItemServiceInstance()
        {
            return new ItemService();
        }
        public ILogService GetLogServiceInstance()
        {
            return new LogService();
        }
        public IMembershipService GetMembershipServiceInstance()
        {
            return new MembershipService();
        }
        public IMemberTypeService GetMemberTypeServiceInstance()
        {
            return new MemberTypeService();
        }
        public IOfferService GetOfferServiceInstance()
        {
            return new OfferService();
        }
        public ITransactionService GetTransactionServiceInstance()
        {
            return new TransactionService();
        }
        public IUserTypeService GetUserTypeServiceInstance()
        {
            return new UserTypeService();
        }
    }
}

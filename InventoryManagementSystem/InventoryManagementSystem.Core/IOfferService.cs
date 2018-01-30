using InventoryManagementSystem.Entity;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    public interface IOfferService
    {
        int Add(Offer offer);
        int Remove(string id);
        int Edit(Offer offer);
        List<Offer> GetAll();
        Entity.Offer GetDiscount(string id);
        List<string> GetOfferNames();
    }
}

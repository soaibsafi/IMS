using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    class OfferService:IOfferService
    {
        private static OfferDataAccess offerDataAccess = null;

        public OfferService()
        {
            if (OfferService.offerDataAccess == null)
            {
                OfferService.offerDataAccess = new OfferDataAccess();
            }
        }

        public int Add(Entity.Offer offerService)
        {
            return OfferService.offerDataAccess.Add(offerService);
        }

        public int Edit(Entity.Offer offerService)
        {
            return OfferService.offerDataAccess.Edit(offerService);
        }

        public List<Entity.Offer> GetAll()
        {
            return OfferService.offerDataAccess.GetAll();
        }

        public int Remove(string id)
        {
            return OfferService.offerDataAccess.Remove(id);
        }

        public Entity.Offer GetDiscount(string id)
        {
            return OfferService.offerDataAccess.GetDiscount(id);
        }
        public List<string> GetOfferNames()
        {
            return OfferService.offerDataAccess.GetOfferNames();
        }
    }
}

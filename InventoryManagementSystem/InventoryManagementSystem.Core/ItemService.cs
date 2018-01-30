using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;
using System.Data;

namespace InventoryManagementSystem.Core
{
    class ItemService:IItemService
    {
        private static ItemDataAccess itemDataAccess = null;

        public ItemService()
        {
            if (ItemService.itemDataAccess == null)
            {
                ItemService.itemDataAccess = new ItemDataAccess();
            }
        }

        public int Add(Entity.Item item)
        {
            return ItemService.itemDataAccess.Add(item);
        }

        public int Edit(Entity.Item item)
        {
            return ItemService.itemDataAccess.Edit(item);
        }

        public int Remove(string id)
        {
            return ItemService.itemDataAccess.Remove(id);
        }

        public List<Entity.Item> GetAll()
        {
            return ItemService.itemDataAccess.GetAll();
        }

        public List<Entity.Item> GetAllSortedByItemName()
        {
            List<Entity.Item> itemList = ItemService.itemDataAccess.GetAll();
            itemList.Sort(new ItemNameComparer());
            return itemList;
        }

        public Entity.Item GetById(string id)
        {
            return ItemService.itemDataAccess.GetById(id);
        }
        public DataTable GetByName(string name, double quantity)
        {
            return ItemService.itemDataAccess.GetByName(name, quantity);
        }
        public List<string> GetName()
        {
            List<string> itemList = new List<string>();
            itemList = ItemService.itemDataAccess.GetName();
            return itemList;
        }
        public DataTable GetAllSortedItem()
        {
            return ItemService.itemDataAccess.GetAllSortedItem();
        }
        public double GetPrice(string itemcode)
        {
            return ItemService.itemDataAccess.GetPrice(itemcode);
        }

        public int UpdateStock(string itemcode, int quantity)
        {
            return ItemService.itemDataAccess.UpdateStock(itemcode, quantity);
        }
        public bool checkStockQuantity(string itemName, int quantity)              // method added
        {
            return ItemService.itemDataAccess.checkStockQuantity(itemName, quantity);
        }
    }
    class ItemNameComparer : IComparer<Entity.Item>
    {
        public int Compare(Entity.Item x, Entity.Item y)
        {
            return string.Compare(x.ItemName, y.ItemName);
        }
    }
}

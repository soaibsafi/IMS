using InventoryManagementSystem.Entity;
using System.Collections.Generic;
using System.Data;

namespace InventoryManagementSystem.Core
{
    public interface IItemService
    {
        int Add(Item item);
        int Remove(string id);
        int Edit(Item item);
        List<Item> GetAll();
        List<Item> GetAllSortedByItemName();
        Item GetById(string id);
        DataTable GetAllSortedItem();
        List<string> GetName();
        DataTable GetByName(string name, double quantity);
        double GetPrice(string itemcode);
        int UpdateStock(string itemcode, int quantity);
        bool checkStockQuantity(string itemName, int quantity);
    }
}

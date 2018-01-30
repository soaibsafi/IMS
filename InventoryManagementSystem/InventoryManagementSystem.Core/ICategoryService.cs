using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Core
{
    public interface ICategoryService
    {
        int Add(Category category);
        int Remove(string id);
        int Edit(Category category);
        List<Category> GetAll();
        List<string> GetAllCategoryName();
    }
}

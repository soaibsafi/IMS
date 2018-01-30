using System;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.Data;
using System.Collections.Generic;

namespace InventoryManagementSystem.Core
{
    class CategoryService:ICategoryService
    {
        private static CategoryDataAccess categoryDataAccess = null;

        public CategoryService()
        {
            if (CategoryService.categoryDataAccess == null)
            {
                CategoryService.categoryDataAccess = new CategoryDataAccess();
            }
        }

        public int Add(Entity.Category category)
        {
            return CategoryService.categoryDataAccess.Add(category);
        }

        public int Edit(Entity.Category category)
        {
            return CategoryService.categoryDataAccess.Edit(category);
        }

        public List<Entity.Category> GetAll()
        {
            return CategoryService.categoryDataAccess.GetAll();
        }

        public int Remove(string id)
        {
            return CategoryService.categoryDataAccess.Remove(id);
        }

        public List<string> GetAllCategoryName()
        {
            List<Entity.Category> categoryList = CategoryService.categoryDataAccess.GetAll();
            List<string> allCategoryName = new List<string>();
            foreach (Entity.Category category in categoryList)
            {
                allCategoryName.Add(category.CategoryName);
            }
            return allCategoryName;
        }
    }
}

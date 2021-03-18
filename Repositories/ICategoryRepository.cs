using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;
using WebShopIP.Models.ViewModels;

namespace WebShopIP.Repositories
{
    public interface ICategoryRepository
    {
        int CreateCategory(Category category);

        List<Category> Categories { get; }

        Category GetCategoryById(int id);

        int UpdateCategory(Category category);

        int DeleteCategory(int id);

        int RemoveProduct(int id);

        List<Product> GetProductsByCategoryId(int id);

        List<ReStoreView> GetInActiveCategories();

        int RestoreCategories(List<ReStoreView> reStoreCategoryViews);
    }
}

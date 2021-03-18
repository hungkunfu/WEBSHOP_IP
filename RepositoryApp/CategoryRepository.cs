using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Models.ViewModels;
using WebShopIP.Repositories;

namespace WebShopIP.RepositoryApp
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContexts context;

        public CategoryRepository(AppDbContexts context)
        {
            this.context = context;
        }

        public int CreateCategory(Category category)
        {
            if (context.Categories.ToList().Exists(el => el.Name == category.Name))
                return -1;

            context.Add(category);
            return (context.SaveChanges());
        }
        [HttpGet]
        public int DeleteCategory(int id)
        {
            var category = context.Categories.FirstOrDefault(el => el.Id == id);

            if (category != null)
            {
                List<Product> Products = context.Products.ToList().FindAll(el => el.CategoryId == category.Id);

                Products.ForEach(el => el.Status = Enum.Status.InActive);
                context.UpdateRange(Products);

                category.Status = Enum.Status.InActive;
                context.Update(category);

                return context.SaveChanges();
            }
            return -1;
        }

        /// <summary>
        /// Get list categories with Status = Active
        /// </summary>
        public List<Category> Categories => context.Categories.ToList().FindAll(el => el.Status == Enum.Status.Active);

        public Category GetCategoryById(int id) => context.Categories.ToList().Find(el => el.Id == id);


        public int UpdateCategory(Category category)
        {
            if (category == null)
                return -1;
            var FindCategory = GetCategoryById(category.Id);

            FindCategory.Name = category.Name;
            FindCategory.Status = category.Status;
            FindCategory.CreateAt = category.CreateAt;

            context.Update(FindCategory);
            return context.SaveChanges();
        }

        public int RemoveProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(el => el.Id == id);

            if (product != null)
            {
                product.Status = Enum.Status.InActive;
                return context.SaveChanges();
            }
            return -1;
        }

       
        public List<Product> GetProductsByCategoryId(int id) =>
            context.Products.ToList().FindAll(el => el.CategoryId == id && el.Status == Enum.Status.Active);

        public List<ReStoreView> GetInActiveCategories()
        {
            List<Category> InActiveCategories = context.Categories.ToList().FindAll(el => el.Status == Enum.Status.InActive);
            List<ReStoreView> reStoreViews = new List<ReStoreView>();

            foreach (var item in InActiveCategories)
            {
                var reStoreView = new ReStoreView()
                {
                    Id = item.Id,
                    Name = item.Name,
                };
                reStoreViews.Add(reStoreView);
            }
            return reStoreViews;
        }

        public int RestoreCategories(List<ReStoreView> reStoreCategoryViews)
        {
            List<Category> categories = new List<Category>();

            foreach (var item in reStoreCategoryViews)
                if (item.IsRestore)
                {
                    Category category = context.Categories.FirstOrDefault(el => el.Id == item.Id);
                    category.Status = Enum.Status.Active;
                    categories.Add(category);

                    context.Products.ToList().FindAll(el =>
                        el.CategoryId == category.Id).ForEach(el => el.Status = Enum.Status.Active);
                }
            context.UpdateRange(categories);

            return Task.Run(async () => await context.SaveChangesAsync()).Result;
        }
    }
}

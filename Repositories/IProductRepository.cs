using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;
using WebShopIP.Models.ViewModels;

namespace WebShopIP.Repositories
{
    public interface IProductRepository
    {
        public List<Product> Gets(string keyword);
        public int CreateProduct(CreateProductView productView);

        public string UploadedFile(IFormFile formFile);

        public List<Product> ProductList();

        public int DeleteProduct(int id);

        public EditProductView FindProductToView(int id);

        public int UpdateProduct(EditProductView productView);

        public List<ReStoreView> GetInActiveProducts();

        public int RestoreProducts(List<ReStoreView> reStoreCategoryViews);
    }
}

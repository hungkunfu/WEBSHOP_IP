using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Models.ViewModels;
using WebShopIP.Repositories;

namespace WebShopIP.RepositoryApp
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContexts context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private const string ProductImageDefault = "default_product_image.png";

        public ProductRepository(AppDbContexts context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public int CreateProduct(CreateProductView productView)
        {
            if (context.Products.ToList().Exists(el => el.Name == productView.Name))
                return -1;

            Product product = new Product()
            {
                Name = productView.Name,
                PricePerUnit = productView.Price,
                CreateAt = productView.CreateAt,
                CreateBy = productView.CreateBy,
                CategoryId = productView.CategoryId
            };
            if (productView.IformfilePath != null)
                product.ImagePath = UploadedFile(productView.IformfilePath);

            context.Add(product);
            return (context.SaveChanges());
        }

        public int DeleteProduct(int id)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == id);

            if (product != null)
            {
                product.Status = Enum.Status.InActive;
                context.Update(product);

                return context.SaveChanges();
            }
            return -1;
        }

        public EditProductView FindProductToView(int id)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == id);

            var productview = new EditProductView()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.PricePerUnit,
                CreateAt = product.CreateAt,
                CreateBy = product.CreateBy,
                CategoryId = product.CategoryId,
                ImgPath = product.ImagePath
            };

            return productview;
        }

        public List<Product> ProductList()
        {
            var list = context.Products.Where(p => p.Status == Enum.Status.Active).ToList();
            return list;
        }

        public int UpdateProduct(EditProductView productView)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == productView.Id);

            product.Name = productView.Name;
            product.CategoryId = productView.CategoryId;
            product.CreateAt = productView.CreateAt;
            product.CreateBy = productView.CreateBy;
            product.PricePerUnit = productView.Price;

            if (productView.IformfilePath != null)
            {
                product.ImagePath = UploadedFile(productView.IformfilePath);

                if (!string.IsNullOrEmpty(productView.ImgPath) && productView.ImgPath != ProductImageDefault)
                {
                    string DelPath = Path.Combine(_webHostEnvironment.WebRootPath, "img/ProductImages", productView.ImgPath);
                    File.Delete(DelPath);
                }
            }
            context.Update(product);
            return (context.SaveChanges());
        }

        public string UploadedFile(IFormFile formFile)
        {
            string uniqueFileName = null;

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img/ProductImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                formFile.CopyTo(fileStream);
            }
            return uniqueFileName;
        }

        public List<ReStoreView> GetInActiveProducts()
        {
            List<Product> InActiveProducts = context.Products.ToList().FindAll(el => el.Status == Enum.Status.InActive);
            List<ReStoreView> ReStoreViews = new List<ReStoreView>();

            foreach (var item in InActiveProducts)
            {
                var reStoreView = new ReStoreView()
                {
                    Id = item.Id,
                    Name = item.Name,
                };
                ReStoreViews.Add(reStoreView);
            }
            return ReStoreViews;
        }

        public int RestoreProducts(List<ReStoreView> ReStoreViews)
        {
            List<Product> products = new List<Product>();

            foreach (var item in ReStoreViews)
                if (item.IsRestore)
                {
                    Product product = context.Products.FirstOrDefault(el => el.Id == item.Id);
                    product.Status = Enum.Status.Active;
                    products.Add(product);
                }
            context.UpdateRange(products);

            return Task.Run(async () => await context.SaveChangesAsync()).Result;
        }
        public List<Product> Gets(string keyword)
        {
            var products = context.Products.ToList();
            var viewProduct = new List<Product>();
            if (!string.IsNullOrEmpty(keyword))
            {
                viewProduct = (from e in products
                               where e.Name.ToLower().Contains(keyword.ToLower())
                               select new Product()
                               {
                                   Status =e.Status,
                                   Category = e.Category,
                                   Name = e.Name,
                                   CategoryId = e.CategoryId,
                                   PricePerUnit = e.PricePerUnit,
                                   ImagePath = e.ImagePath,
                                   Id = e.Id,
                                   CreateAt = e.CreateAt,
                                   CreateBy = e.CreateBy,
                                   OrderDetails = e.OrderDetails
                               }).ToList();
            }
            else
            {
                viewProduct = (from e in products
                               select new Product()
                               {
                                   Status = e.Status,
                                   Category = e.Category,
                                   CategoryId =e.CategoryId,
                                   Name = e.Name,                                 
                                   PricePerUnit = e.PricePerUnit,
                                   ImagePath = e.ImagePath,
                                   Id = e.Id,
                                   CreateAt = e.CreateAt,
                                   CreateBy = e.CreateBy,
                                   OrderDetails = e.OrderDetails
                               }).ToList();
            }
            return viewProduct;

        }
    }
}

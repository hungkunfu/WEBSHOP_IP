using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Dbcontexts;
using WebShopIP.Entities;
using WebShopIP.Models.Product;

namespace WebShopIP.Services
{
    public class ProductService: IProductService
    {
        private readonly AppDbContexts context;

        public ProductService(AppDbContexts context)
        {
            this.context = context;
        }

        public Product Get(int productId)
        {
            return context.Products.FirstOrDefault(p => p.Id == productId);
        }

        public List<Product> Gets()
        {
            return context.Products.ToList();
        }

        public SaveResponse Save(SaveRequest request)
        {
            var result = new SaveResponse()
            {
                Success = false,
                Message = "Something went wrong, please contact administrator"
            };
            try
            {
                //add new
                if (request.ProductId == 0)
                {
                    var product = new Product()
                    {
                        Id = request.ProductId,
                       
                        PricePerUnit = request.Price,
                        Name = request.ProductName
                    };
                    context.Add(product);
                    result.Success = context.SaveChanges() > 0;
                    result.Message = "Product has been created successfully";
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}

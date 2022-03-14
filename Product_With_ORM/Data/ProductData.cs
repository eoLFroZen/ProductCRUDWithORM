using Product_With_ORM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_With_ORM.Data
{
    public class ProductData
    {
        private ProductDbContext dbContext;

        public ProductData(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Update(Product updatedProduct)
        {
            Product dbProduct = GetById(updatedProduct.Id);

            dbProduct.Name = updatedProduct.Name;
            dbProduct.Price = updatedProduct.Price;
            dbProduct.Stock = updatedProduct.Stock;

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.Products.Remove(GetById(id));
            dbContext.SaveChanges();
        }
    }
}

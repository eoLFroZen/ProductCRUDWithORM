using Product_With_ORM.Data;
using Product_With_ORM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_With_ORM.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private ProductData productData;

        public ProductBusiness(ProductData productData)
        {
            this.productData = productData;
        }

        public List<Product> GetAll()
        {
            return productData.GetAll();
        }

        public Product GetById(int id)
        {
            return productData.GetById(id);
        }

        public void Add(Product product)
        {
            productData.Add(product);
        }

        public void Update(Product product)
        {
            productData.Update(product);
        }

        public void Delete(int id)
        {
            productData.Delete(id);
        }
    }
}

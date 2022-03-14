using Product_With_ORM.Business;
using Product_With_ORM.Data;
using Product_With_ORM.Presentation;
using System;

namespace Product_With_ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDbContext dbContext = new ProductDbContext();

            ProductData productData = new ProductData(dbContext);

            ProductBusiness productBusiness = new ProductBusiness(productData);

            Display display = new Display(productBusiness);
        }
    }
}

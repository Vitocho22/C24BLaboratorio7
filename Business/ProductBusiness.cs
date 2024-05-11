using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductBusiness
    {
        public List<Product> Get()
        {
            ProductData data = new ProductData();
            var product = data.Get();
            return product;
        }
        public void Delete(int productId)
        {
            ProductData data = new ProductData();
            data.Delete(productId);
        }

        public void Insert(string name, decimal price, int stock, bool active)
        {
            ProductData data = new ProductData();
            data.Insert(name, price, stock, active);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniCrudApp.Models;

namespace MiniCrudApp.Controllers
{
    public class ProductoController
    {
        private List<Producto> productsList = new List<Producto>();
        public IEnumerable<Producto> ObtainProducts() => productsList;

        public void AddProduct(int id, string name, decimal price)
        {
            productsList.Add(new Producto(id, name, price));
        }
        public bool EditProduct(int id, string newName, decimal newPrice)
        {
            var product = productsList.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
                return true;
            }
            return false;

        }
        public bool DeleteProduct(int id)
        {
            var product = productsList.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                productsList.Remove(product);
                return true;
            }
            return false;
        }
    }
}

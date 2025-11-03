using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCrudApp.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Producto(int ID, string Name, decimal Price)
        {
            this.Name = Name;
            this.ID = ID;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"ID: {ID} - Name: {Name} - ${Price}";
        }
    }
}

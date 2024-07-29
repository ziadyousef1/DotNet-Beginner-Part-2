using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Beginner_Part_2
{
    public class ProductBuilder
    {
        private Product _product;

        public ProductBuilder()
        {
            _product = new Product();
        }

        public ProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            _product.Description = description;
            return this;
        }

        public ProductBuilder SetPrice(double price)
        {
            _product.Price = price;
            return this;
        }

        public ProductBuilder SetManufacturer(string manufacturer)
        {
            _product.Manufacturer = manufacturer;
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }

}

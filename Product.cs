using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float CurrentPrice { get; set; }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product.

            return new Product();
        }

        /// <summary>
        /// Retrieve all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            // Code that retrieves all products.

            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product.

            return true;
        }
    }
}

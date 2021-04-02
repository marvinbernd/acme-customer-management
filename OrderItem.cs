using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public Product OrderProduct { get; set; }
        public int Quantity { get; set; }
        public float PurchasePrice { get; set; }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;



            return isValid;
        }

        /// <summary>
        /// Retrieves the defined order item.
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item.

            return new OrderItem();
        }

        /// <summary>
        /// Retrieves all order items.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            // Code that retrieves all order items.

            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the defined order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order item.

            return true;
        }
    }
}

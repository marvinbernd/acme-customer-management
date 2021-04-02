using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
            // Code that generates the order date.
        }

        public int OrderId { get; private set; }
        public int OrderDate { get; private set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            // Code that validates the order data.

            return isValid;
        }

        /// <summary>
        /// Retrieves the defined order.
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order.

            return new Order();
        }

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            // Code that retrieves all orders.

            return new List<Order>();
        }

        /// <summary>
        /// Saves the defined order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order.

            return true;
        }
    }
}

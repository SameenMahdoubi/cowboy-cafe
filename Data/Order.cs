/* Order.cs
 * Author: Max Maus
 * Last modified: 2/28/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class defines a single order being purchased by a customer.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            lastOrderNumber++;
            orderNumber = lastOrderNumber;
        }

        /// <summary>
        /// This field represents the current order number, it initializes at 0 since we initially haven't had any orders.
        /// </summary>
        private static uint lastOrderNumber = 0;

        private uint orderNumber;
        public uint OrderNumber { 
            get 
            {
                return orderNumber;
            }
        } 

        /// <summary>
        /// This refers to the total of all order items' prices before tax, starts at 0 since we haven't increased it yet
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// A list of all items in the order.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// A public reference to items, to preserve data hiding
        /// </summary>
        public IEnumerable<IOrderItem> Items { get => items.ToArray(); }

        /// <summary>
        /// Adds an item to the list of items in the order.
        /// </summary>
        /// <param name="item">The item to be added</param>
        public void Add(IOrderItem item) 
        { 
            
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// Removes an item from the list of items in the order.
        /// </summary>
        /// <param name="item">The item to be removed. If multiple identical instances of this item are present, it removes the first.</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

    }
}

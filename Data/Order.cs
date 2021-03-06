﻿/* Order.cs
 * Author: Max Maus, with code taken with permission from Zachery Brunner
 * Last modified: 3/2/20
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
            if(item is INotifyPropertyChanged pcitem) // DELETE THIS LATER
            {
                pcitem.PropertyChanged += OnItemChanged;
            }
            
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
            /*
            if (item is INotifyPropertyChanged pcitem) // DELETE THIS LATER
            {
                pcitem.PropertyChanged -= OnItemChanged;
            }
            */
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        /// <summary>
        /// This invokes all property change events, to avoid having to add the propertychanged interface to every customization screen
        /// </summary>
        public void UpdateAllProperties()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}

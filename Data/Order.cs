using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// list of items in order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// creates ienumerable of iorderitem 
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private static uint number = 0;

        /// <summary>
        /// displays number of order this is
        /// </summary>
        public uint OrderNumber { get { return number++; } }

        private double subtotal = 0;
        /// <summary>
        /// creates a sub total price of order
        /// </summary>
        public double Subtotal { get { return subtotal; } private set { subtotal = value; }  }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// add item to order list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// removes item from order list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}

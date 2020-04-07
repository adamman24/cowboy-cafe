using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        /// <summary>
        /// creates a sub total price of order
        /// </summary>
        public double Subtotal 
        { 
            get 
            {
                double total = 0;
                foreach(IOrderItem item in Items)
                {
                    total += item.Price;
                }
                return total;
            }  
        }

        /// <summary>
        /// gets total price with 16% sales tax and returns
        /// </summary>
        public double total
        {
            get
            {
                double totalPrice = 0;
                totalPrice = Math.Round(((Subtotal * .16) + Subtotal) * 100f) / 100;
                return totalPrice;
            }
        }

        
        /// <summary>
        /// add item to order list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// removes item from order list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price") 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// abstract entree base class
    /// </summary>
    public abstract class Entree: IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// abstract class for entrees prices
        /// </summary>
        public abstract double Price
        {
            get;
        }

        /// <summary>
        /// abstract class for entree calories
        /// </summary>
        public abstract uint Calories
        {
            get;
        }

        /// <summary>
        /// abstract class for special isntructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// if property changes it will update here
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}

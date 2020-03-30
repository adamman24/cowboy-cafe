using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class ChiliCheeseFriesPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var ChiliCheeseFries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ChiliCheeseFries);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var ChiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(ChiliCheeseFries, "Size", () =>
            {
                ChiliCheeseFries.Size = Size.Small;
            });

            Assert.PropertyChanged(ChiliCheeseFries, "Calories", () =>
            {
                ChiliCheeseFries.Size = Size.Small;
            });

            Assert.PropertyChanged(ChiliCheeseFries, "Price", () =>
            {
                ChiliCheeseFries.Size = Size.Small;
            });
        }


    }
}

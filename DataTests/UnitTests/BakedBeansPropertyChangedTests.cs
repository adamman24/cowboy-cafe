using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class BakedBeansPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var BakedBeans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(BakedBeans);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var BakedBeans = new BakedBeans();
            Assert.PropertyChanged(BakedBeans, "Size", () =>
            {
                BakedBeans.Size = Size.Small;
            });

            Assert.PropertyChanged(BakedBeans, "Calories", () =>
            {
                BakedBeans.Size = Size.Small;
            });

            Assert.PropertyChanged(BakedBeans, "Price", () =>
            {
                BakedBeans.Size = Size.Small;
            });
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class WaterPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Small;
            });

            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Small;
            });

            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Small;
            });
        }

        /// <summary>
        /// changing Size should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Size = Size.Small;
            });
        }

        /// <summary>
        /// changing Lemon should change Lemon
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = false;
            });
        }

        /// <summary>
        /// changing Lemon should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = false;
            });
        }

        /// <summary>
        /// changing Ice should change Ice
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// changing Ice should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }
    }
}

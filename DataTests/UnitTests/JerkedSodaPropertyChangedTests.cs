using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small;
            });

            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Small;
            });

            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Small;
            });
        }

        /// <summary>
        /// changing Size should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Size = Size.Small;
            });
        }

        /// <summary>
        /// changing Flavor should change Flavor
        /// </summary>
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedforFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            });
        }

        /// <summary>
        /// changing Flavor should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedforSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            });
        }

        /// <summary>
        /// changing Ice should change Ice
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        /// <summary>
        /// changing Ice should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }
    }
}

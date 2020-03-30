using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeePropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);

        }

        /// <summary>
        /// changing RoomForCream should change RoomForCream 
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedforRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// changing RoomForCream should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedforSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// changing Decaf should change Decaf
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedforDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = false;
            });
        }

        /// <summary>
        /// changing Decaf should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedforSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = false;
            });
        }

        /// <summary>
        /// changing Ice should change Ice
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = false;
            });
        }

        /// <summary>
        /// changing Ice should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = false;
            });
        }
    }
}

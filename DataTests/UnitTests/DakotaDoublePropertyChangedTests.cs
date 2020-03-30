using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class DakotaDoublePropertyChangedTests
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void DakotaDoubleShouldImplementINotifyPropertyChanged()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakota);

        }

        /// <summary>
        /// changing Ketchup should change Ketchup
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforKetchup()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Ketchup", () =>
            {
                dakota.Ketchup = false;
            });
        }

        /// <summary>
        /// changing SpecialInstructions should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Ketchup = false;
            });
        }

        /// <summary>
        /// changing Mustard should change Mustard 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforMustard()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mustard", () =>
            {
                dakota.Mustard = false;
            });
        }

        /// <summary>
        /// changing SpecialInstructions should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Mustard = false;
            });
        }

        /// <summary>
        /// changing Pickle should change Pickle 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Pickle", () =>
            {
                dakota.Pickle = false;
            });
        }

        /// <summary>
        /// changing Pickle should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Pickle = false;
            });
        }

        /// <summary>
        /// changing Cheese should change Cheese 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforCheese()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Cheese", () =>
            {
                dakota.Cheese = false;
            });
        }


        /// <summary>
        /// changing Cheese should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Cheese = false;
            });
        }

        /// <summary>
        /// changing Bun should change Bun
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Bun", () =>
            {
                dakota.Bun = false;
            });
        }

        /// <summary>
        /// changing Bun should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Bun = false;
            });
        }

        /// <summary>
        /// changing Tomato should change Tomato
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforTomato()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Tomato", () =>
            {
                dakota.Tomato = false;
            });
        }

        /// <summary>
        /// changing Tomato should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Tomato = false;
            });
        }

        /// <summary>
        /// changing Lettuce should change Lettuce
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforLettuce()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Lettuce", () =>
            {
                dakota.Lettuce = false;
            });
        }

        /// <summary>
        /// changing Lettuce should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Lettuce = false;
            });
        }

        /// <summary>
        /// changing Mayo should change Mayo
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforMayo()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mayo", () =>
            {
                dakota.Mayo = false;
            });
        }

        /// <summary>
        /// changing Mayo should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Mayo = false;
            });
        }

    }
}

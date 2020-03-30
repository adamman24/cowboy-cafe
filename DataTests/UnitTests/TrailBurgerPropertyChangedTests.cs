using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var trail = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trail);

        }

        /// <summary>
        /// changing Ketchup should change Ketchup
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforKetchup()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Ketchup", () =>
            {
                trail.Ketchup = false;
            });
        }

        /// <summary>
        /// changing SpecialInstructions should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Ketchup = false;
            });
        }

        /// <summary>
        /// changing Mustard should change Mustard 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforMustard()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Mustard", () =>
            {
                trail.Mustard = false;
            });
        }

        /// <summary>
        /// changing SpecialInstructions should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Mustard = false;
            });
        }

        /// <summary>
        /// changing Pickle should change Pickle 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Pickle", () =>
            {
                trail.Pickle = false;
            });
        }

        /// <summary>
        /// changing Pickle should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Pickle = false;
            });
        }

        /// <summary>
        /// changing Cheese should change Cheese 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforCheese()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Cheese", () =>
            {
                trail.Cheese = false;
            });
        }


        /// <summary>
        /// changing Cheese should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Cheese = false;
            });
        }

        /// <summary>
        /// changing Bun should change Bun
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Bun", () =>
            {
                trail.Bun = false;
            });
        }

        /// <summary>
        /// changing Bun should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Bun = false;
            });
        }
    }
}
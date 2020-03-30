using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class TexasTriplePropertyChangedTests
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void TexasTripleShouldImplementINotifyPropertyChanged()
        {
            var triple = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(triple);

        }

        /// <summary>
        /// changing Ketchup should change Ketchup
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforKetchup()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Ketchup", () =>
            {
                triple.Ketchup = false;
            });
        }

        /// <summary>
        /// changing SpecialInstructions should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Ketchup = false;
            });
        }

        /// <summary>
        /// changing Mustard should change Mustard 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforMustard()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mustard", () =>
            {
                triple.Mustard = false;
            });
        }

        /// <summary>
        /// changing SpecialInstructions should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Mustard = false;
            });
        }

        /// <summary>
        /// changing Pickle should change Pickle 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Pickle", () =>
            {
                triple.Pickle = false;
            });
        }

        /// <summary>
        /// changing Pickle should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Pickle = false;
            });
        }

        /// <summary>
        /// changing Cheese should change Cheese 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforCheese()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Cheese", () =>
            {
                triple.Cheese = false;
            });
        }


        /// <summary>
        /// changing Cheese should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Cheese = false;
            });
        }

        /// <summary>
        /// changing Bun should change Bun
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bun", () =>
            {
                triple.Bun = false;
            });
        }

        /// <summary>
        /// changing Bun should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Bun = false;
            });
        }

        /// <summary>
        /// changing Tomato should change Tomato
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforTomato()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Tomato", () =>
            {
                triple.Tomato = false;
            });
        }

        /// <summary>
        /// changing Tomato should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Tomato = false;
            });
        }

        /// <summary>
        /// changing Lettuce should change Lettuce
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforLettuce()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Lettuce", () =>
            {
                triple.Lettuce = false;
            });
        }

        /// <summary>
        /// changing Lettuce should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Lettuce = false;
            });
        }

        /// <summary>
        /// changing Mayo should change Mayo
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforMayo()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mayo", () =>
            {
                triple.Mayo = false;
            });
        }

        /// <summary>
        /// changing Mayo should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Mayo = false;
            });
        }

        /// <summary>
        /// changing Egg should change Egg
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedforEgg()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Egg", () =>
            {
                triple.Egg = false;
            });
        }

        /// <summary>
        /// changing Egg should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Egg = false;
            });
        }

        /// <summary>
        /// changing Bacon should change Bacon
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedforBacon()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bacon", () =>
            {
                triple.Bacon = false;
            });
        }

        /// <summary>
        /// changing Bacon should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedforSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () =>
            {
                triple.Bacon = false;
            });
        }

    }
}
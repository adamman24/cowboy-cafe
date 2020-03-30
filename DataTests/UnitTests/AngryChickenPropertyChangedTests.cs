using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);

        }

        /// <summary>
        /// changing bread should change bread 
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// changing bread should change instructions
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// changing pickle should change pickle
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangeForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }

        /// <summary>
        /// changing pickle should change instructions
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangeForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }
    }
}

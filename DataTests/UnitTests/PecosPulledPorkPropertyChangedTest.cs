using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);

        }

        /// <summary>
        /// changing Pickle should change Pickle 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }

        /// <summary>
        /// changing Pickle should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }

        /// <summary>
        /// changing Bread should change Bread
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedforBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });
        }

        /// <summary>
        /// changing Bread should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedforSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }
    }
}

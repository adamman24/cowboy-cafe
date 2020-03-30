using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void ChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);

        }

        /// <summary>
        /// changing cheese should change cheese
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// changing cheese should change special instructions
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// changing sour cream should change sour cream
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedforSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// changing sour cream should change special Instructions
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// changing green onions should change green onions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedforGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// changing green onions should change Special Instructions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// changing tortilla Strips should change tortilla strips
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedforTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }

        /// <summary>
        /// changing tortilla Strips should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}

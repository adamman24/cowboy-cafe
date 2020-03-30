using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class TexasTeaPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Small;
            });

            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Small;
            });

            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Small;
            });
        }

        /// <summary>
        /// changing Size should change SpecialInstructions 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Size = Size.Small;
            });
        }

        /// <summary>
        /// changing Lemon should change Lemon
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = false;
            });
        }

        /// <summary>
        /// changing Lemon should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = false;
            });
        }

        /// <summary>
        /// changing Lemon should change Sweet
        /// </summary>
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedforSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }

        /// <summary>
        /// changing Sweet should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedforSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }

        /// <summary>
        /// changing Ice should change Ice
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }

        /// <summary>
        /// changing Ice should change SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }
    }
}

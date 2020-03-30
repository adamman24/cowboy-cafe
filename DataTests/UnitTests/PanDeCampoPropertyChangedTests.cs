using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class PanDeCampoPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var PanDeCampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(PanDeCampo);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var PanDeCampo = new PanDeCampo();
            Assert.PropertyChanged(PanDeCampo, "Size", () =>
            {
                PanDeCampo.Size = Size.Small;
            });

            Assert.PropertyChanged(PanDeCampo, "Calories", () =>
            {
                PanDeCampo.Size = Size.Small;
            });

            Assert.PropertyChanged(PanDeCampo, "Price", () =>
            {
                PanDeCampo.Size = Size.Small;
            });
        }


    }
}

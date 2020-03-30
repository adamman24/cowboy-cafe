using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CornDodgersPropertyChangedTest
    {
        /// <summary>
        /// making sure property changed implemented
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var CornDodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(CornDodgers);

        }

        /// <summary>
        /// changing Size should change Size 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var CornDodgers = new CornDodgers();
            Assert.PropertyChanged(CornDodgers, "Size", () =>
            {
                CornDodgers.Size = Size.Small;
            });

            Assert.PropertyChanged(CornDodgers, "Calories", () =>
            {
                CornDodgers.Size = Size.Small;
            });

            Assert.PropertyChanged(CornDodgers, "Price", () =>
            {
                CornDodgers.Size = Size.Small;
            });
        }


    }
}

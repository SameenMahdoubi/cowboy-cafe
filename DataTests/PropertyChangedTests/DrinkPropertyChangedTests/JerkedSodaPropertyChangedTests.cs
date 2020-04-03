using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.DrinkPropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(jerkedSoda);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Size", () => {
                jerkedSoda.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Price", () => {
                jerkedSoda.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Ice", () => {
                jerkedSoda.Ice = false;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "SpecialInstructions", () => {
                jerkedSoda.Ice = false;
            });
        }

        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangedForFlavor()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Flavor", () => {
                jerkedSoda.Flavor = SodaFlavor.Sarsparilla;
            });
        }

        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "SpecialInstructions", () => {
                jerkedSoda.Flavor = SodaFlavor.Sarsparilla;
            });
        }
    }
}

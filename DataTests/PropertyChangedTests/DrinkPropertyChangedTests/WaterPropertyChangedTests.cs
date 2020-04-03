using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.DrinkPropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () => {
                water.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Price", () => {
                water.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () => {
                water.Ice = false;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () => {
                water.Lemon = true;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Lemon = true;
            });
        }
    }
}

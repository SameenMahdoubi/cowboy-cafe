using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.DrinkPropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowboyCoffee);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Size", () => {
                cowboyCoffee.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Price", () => {
                cowboyCoffee.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Ice", () => {
                cowboyCoffee.Ice = true;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.Ice = true;
            });
        }

        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "Decaf", () => {
                cowboyCoffee.Decaf = true;
            });
        }

        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.Decaf = true;
            });
        }

        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "RoomForCream", () => {
                cowboyCoffee.RoomForCream = true;
            });
        }

        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowboyCoffee = new CowboyCoffee();
            Assert.PropertyChanged(cowboyCoffee, "SpecialInstructions", () => {
                cowboyCoffee.RoomForCream = true;
            });
        }
    }
}

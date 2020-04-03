using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var trailBurger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trailBurger);
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Bun", () => {
                trailBurger.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Ketchup", () => {
                trailBurger.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Ketchup = false;
            });
        }




        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Mustard", () => {
                trailBurger.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Pickle", () => {
                trailBurger.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "Cheese", () => {
                trailBurger.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trailBurger = new TrailBurger();
            Assert.PropertyChanged(trailBurger, "SpecialInstructions", () => {
                trailBurger.Cheese = false;
            });
        }
    }
}

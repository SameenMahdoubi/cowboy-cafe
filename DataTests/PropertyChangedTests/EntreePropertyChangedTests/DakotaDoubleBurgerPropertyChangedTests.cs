using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakota);
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Bun", () => {
                dakota.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Ketchup", () => {
                dakota.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Ketchup = false;
            });
        }




        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mustard", () => {
                dakota.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Pickle", () => {
                dakota.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Cheese", () => {
                dakota.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Cheese = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Lettuce", () => {
                dakota.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Tomato", () => {
                dakota.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Tomato = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mayo", () => {
                dakota.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => {
                dakota.Mayo = false;
            });
        }
    }
}

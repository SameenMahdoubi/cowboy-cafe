using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.DrinkPropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var texasTea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTea);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Size", () => {
                texasTea.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Price", () => {
                texasTea.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Ice", () => {
                texasTea.Ice = false;
            });
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Lemon", () => {
                texasTea.Lemon = true;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Lemon = true;
            });
        }

        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "Sweet", () => {
                texasTea.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTea = new TexasTea();
            Assert.PropertyChanged(texasTea, "SpecialInstructions", () => {
                texasTea.Sweet = false;
            });
        }
    }
}

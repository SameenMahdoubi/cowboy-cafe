using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.SidePropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () => {
                pan.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () => {
                pan.Size = Size.Large;
            });
        }
    }
}

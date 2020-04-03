using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.SidePropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () => {
                beans.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () => {
                beans.Size = Size.Large;
            });
        }
    }
}

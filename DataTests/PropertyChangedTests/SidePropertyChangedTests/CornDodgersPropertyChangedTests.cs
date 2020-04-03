using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests.SidePropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () => {
                dodgers.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Price", () => {
                dodgers.Size = Size.Large;
            });
        }
    }
}

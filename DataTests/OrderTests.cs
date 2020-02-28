using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; } = new List<string>();

            public string Name { get; }
        }
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Fact] // means no paramaters
        public void ShouldBeAbleToGetEnumerationOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items, 
                item => Assert.Equal(item0, item), // checks whether this item is what its expected value (item0) is
                item => Assert.Equal(item1, item), 
                item => Assert.Equal(item2, item));
        }

        [Theory] // means parameters are supplied
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0.3, 0 })]
        [InlineData(new double[] { 199.34, 799})]
        [InlineData(new double[] { 798})]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5})]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] { 3.1345234262})]
        [InlineData(new double[] { double.NaN })]
        public void SubtotalShouldBeSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });

                Assert.Equal(total, order.Subtotal);
            }
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }
       

        [Fact]
        public void OrderNumbersShouldIncrementConsecutively()
        {
            var order0 = new Order();
            var order1 = new Order();
            var order2 = new Order();
            Assert.Equal(order0.OrderNumber, (uint)1);
            Assert.Equal(order1.OrderNumber, (uint)2);
            Assert.Equal(order2.OrderNumber, (uint)3);
        }

        [Fact]
        public void ShouldBeAbleToAddEntrees()
        {
            var order = new Order();
            var item0 = new AngryChicken();           
            var item1 = new CowpokeChili();
            var item2 = new DakotaDoubleBurger();
            var item3 = new PecosPulledPork();
            var item4 = new RustlersRibs();
            var item5 = new TrailBurger();
            var item6 = new TexasTripleBurger();

            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);
            order.Add(item4);
            order.Add(item5);
            order.Add(item6);

            Assert.Contains(item0, order.Items);
            Assert.Contains(item1, order.Items);
            Assert.Contains(item2, order.Items);
            Assert.Contains(item3, order.Items);
            Assert.Contains(item4, order.Items);
            Assert.Contains(item5, order.Items);
            Assert.Contains(item6, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToAddDrinks()
        {
            var order = new Order();
            var item0 = new CowboyCoffee();
            var item1 = new JerkedSoda();
            var item2 = new TexasTea();
            var item3 = new Water();

            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);

            Assert.Contains(item0, order.Items);
            Assert.Contains(item1, order.Items);
            Assert.Contains(item2, order.Items);
            Assert.Contains(item3, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToAddSides()
        {
            var order = new Order();
            var item0 = new ChiliCheeseFries();
            var item1 = new CornDodgers();
            var item2 = new PanDeCampo();
            var item3 = new BakedBeans();

            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);

            Assert.Contains(item0, order.Items);
            Assert.Contains(item1, order.Items);
            Assert.Contains(item2, order.Items);
            Assert.Contains(item3, order.Items);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests
{
    class MockOrderItem : IOrderItem
     {
        public double Price { get; set; }

        public List<string> SpecialInstructions { get; set; }
    }
    public class OrderTests
    {

        
        ///adding somethign to order has 
        ///same thing appear in order
        [Fact]
        public void AddingAnIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void RemovedOrderItemDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Theory]
        [InlineData(new double[] { })]
        [InlineData(new double[] { 0 })]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] { -100, -5 })]
        public void SubTotalShouldBeTheSumOfOrderItemPrices(double[] prices)
        { 
            double total = 0;
            var order = new Order();
            foreach(var price in prices)
            {
                order.Add(new MockOrderItem() 
                {
                   Price = price
                });
                
            }

            Assert.Equal(total, order.Subtotal);
        }

        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var order = new Order();
            var items = new IOrderItem[]
            {
            new MockOrderItem() {Price = 3},
            new MockOrderItem() {Price = 4},
            new MockOrderItem() {Price = 7}
            };
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }


        ///removing something should remove
        ///from order
        
        ///get correct price
        ///
    }
}

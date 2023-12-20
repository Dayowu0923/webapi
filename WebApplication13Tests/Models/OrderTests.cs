using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace WebApplication13.Models.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void OrderTest_CombinationDiscountRule_ReturnsGetTotalPrice()
        {
            // Arrange
            Books A = new Books("哈利波特1", 100);
            Books B = new Books("哈利波特2", 150);
            double discount = 0.9;
            IDiscountRule rule = new CombinationDiscountRule(discount);
            Order order = new Order();
            order.Add_books(A);
            order.Add_books(B);
            order.Add_rules(rule);
            // Act
            double result = order.GetTotalPrice();
            // Assert
            Assert.AreEqual((A._price + B._price) * discount, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myStore.Controllers;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace myStore.IntegrationTests
{
    [Binding]
    public class MKTPO_8435
    {
        private OrdersController orderController = new OrdersController();
        private IEnumerable<string> actualOrderList;
        private string actualSpecificOrder;
        [When(@"我發出一個Request\(Get\)到orders api")]
        public void 當我發出一個RequestGet到OrdersApi()
        {
            actualOrderList = orderController.Get();
        }
        
        [When(@"我發出一個Request\(Get\)到orders api,其中包含參數(.*)")]
        public void 當我發出一個RequestGet到OrdersApi其中包含參數(int orderId)
        {
            actualSpecificOrder = orderController.Get(orderId);
        }
        
        [Then(@"應該要回傳整個訂單清單")]
        public void 那麼應該要回傳整個訂單清單()
        {
            IEnumerable<string> expectedResult = new string[] { "item1", "item2" };
            Assert.AreEqual(expectedResult.ToString(), actualOrderList.ToString());
            
        }
        
        [Then(@"應該要回傳訂單(.*)")]
        public void 那麼應該要回傳訂單Item(string expectedSpecificOrder)
        {
            Assert.AreEqual(actualSpecificOrder, expectedSpecificOrder);
        }
    }
}

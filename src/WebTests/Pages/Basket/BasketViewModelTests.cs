using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.eShopWeb.Web.Pages.Basket;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.eShopWeb.Web.Pages.Basket.Tests
{
    [TestClass()]
    public class BasketViewModelTests
    {
        private const double TAXRATE = .06;
        //public object Items { get; private set; }

        [TestMethod()]
        public void GrandTotalTest()
        {
            var total = 0m;
            total = GrandTotal();

            if (total < 0)
                Assert.Fail();

            if (total > 1000000)
                Assert.Fail();
        }


        public decimal Total()
        {
            var total = 0m;
            total = (decimal)24.12;
            return total;
        }

        public decimal Tax()
        {
            var total = 0m;
            var taxRate = 0m;
            var tax = 0m;

            total = Total();
            taxRate = (decimal)TAXRATE;
            tax = total * taxRate;
            return tax;

        }

        private decimal GrandTotal()
        {
            var total = 0m;
            var tax = 0m;
            var grandTotal = 0m;

            total = Total();
            tax = Tax();
            grandTotal = total + tax;
            return grandTotal;
        }






    }



    
}
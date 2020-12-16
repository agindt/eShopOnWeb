using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.eShopWeb.Web.Pages.Basket
{
    public class BasketViewModel
    {
        private const double TAXRATE = .06;

        public int Id { get; set; }
        public List<BasketItemViewModel> Items { get; set; } = new List<BasketItemViewModel>();
        public string BuyerId { get; set; }

        public decimal Total()
        {
            return Math.Round(Items.Sum(x => x.UnitPrice * x.Quantity), 2);
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

        public decimal GrandTotal()
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

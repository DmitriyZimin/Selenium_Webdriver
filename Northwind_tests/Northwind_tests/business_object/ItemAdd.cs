using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.business_object
{
    class ItemAdd
    {
        public string selectName { get; set; }
        public string selectCategory { get; set; }
        public string selectSupplier { get; set; }
        public string selectPrice { get; set; }
        public string selectQuantity { get; set; }
        public string selectInstock { get; set; }
        public string selectOnorder { get; set; }
        public string selectReorder { get; set; }
        public ItemAdd(string selectName, string selectCategory, string selectSupplier, string selectPrice, string selectQuantity, string selectInstock, string selectOnorder, string selectReorder)
        {
            this.selectName = selectName;
            this.selectCategory = selectCategory;
            this.selectSupplier = selectSupplier;
            this.selectPrice = selectPrice;
            this.selectQuantity = selectQuantity;
            this.selectInstock = selectInstock;
            this.selectOnorder = selectOnorder;
            this.selectReorder = selectReorder;
            
        }
    }
}

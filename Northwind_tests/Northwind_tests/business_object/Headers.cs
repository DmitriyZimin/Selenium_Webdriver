using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.business_object
{
    class Headers
    {
        public string Allproducts { get; set; }
        public string HomePage { get; set; }
        public string Login { get; set; }
        public Headers(string Allproducts, string HomePage, string Login)
        {
            this.Allproducts = Allproducts;
            this.HomePage = HomePage;
            this.Login = Login;

        }
    }
}

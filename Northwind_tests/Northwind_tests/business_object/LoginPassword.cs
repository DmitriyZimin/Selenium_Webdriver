using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.business_object
{
    class LoginPassword
    {
        public string selectLogin { get; set; }
        public string selectPassword { get; set; }
        public LoginPassword(string selectLogin, string selectPassword)
        {
            this.selectLogin = selectLogin;
            this.selectPassword = selectPassword;
           
        }
    }
}

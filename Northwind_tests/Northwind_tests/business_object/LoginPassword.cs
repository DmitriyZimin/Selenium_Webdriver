using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.business_object
{
    class LoginPassword
    {
        private object p1;
        private object p2;
        private object p3;
        private object p4;
        private object p5;
        private object p6;

        public string selectLogin { get; set; }
        public string selectPassword { get; set; }
        public LoginPassword(string selectLogin, string selectPassword)
        {
            this.selectLogin = selectLogin;
            this.selectPassword = selectPassword;
           
        }

        public LoginPassword(string selectLogin, string selectPassword, object p1, object p2, object p3, object p4, object p5, object p6) : this(selectLogin, selectPassword)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
        }
    }
}

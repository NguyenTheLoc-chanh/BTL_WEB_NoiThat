using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class checkoutInfo
    {
        private string name;
        private string email;
        private string phone;
        private string address;
        private string city;
        private string district;
        private string ward;
        private string paymentMethod;

        public checkoutInfo() { }
        public checkoutInfo(string name, string email, string phone, string address, string city, string discrict, string ward, string paymentMethod)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.city = city;
            this.district= discrict;
            this.ward = ward;
            this.paymentMethod = paymentMethod;
        }
    }
}
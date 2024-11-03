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

        public checkoutInfo (string email, string phone, string address)
        {
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public string SName { get => name; set => name = value; }
        public string SEmail { get => email; set => email = value; }
        public string SPhone  { get => phone; set => phone = value; }
        public string SAddress { get => address; set => address = value; }
        public string SCity { get => city; set => city = value; }
        public string SDistrict { get => district; set => district = value; }
        public string SWard { get => ward; set => ward = value; }
        public string SPaymentMethod { get => paymentMethod; set => paymentMethod = value; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class Coupon
    {
        private string id;
        private string name;
        private int discount;
        private DateTime expireAt;

        public Coupon() { }
        public Coupon(string id, string name, int discount, DateTime expireAt) {
            this.id = id;
            this.name = name;
            this.discount = discount;
            this.expireAt = expireAt;
        }

        public string SId { get => id; set => id = value; }
        public string SName { get => name; set => name = value; }
        public int IDiscount { get => discount; set => discount = value; }
        public DateTime DExpireAt { get => expireAt; set => expireAt = value; }
    }
}
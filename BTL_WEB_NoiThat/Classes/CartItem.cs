using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class CartItem
    {
        private string id;
        private string userId;
        private Dictionary<int, int> listProduct;
        private bool wasOrder = false;
        private Coupon coupon;

        public CartItem(string id, Dictionary<int, int> listProduct, string userId)
        {
            this.id = id;
            this.listProduct = listProduct;
            this.userId = userId;
            this.wasOrder = wasOrder;
        }
        public CartItem(string id, Dictionary<int, int> listProduct)
        {
            this.id = id;
            this.listProduct = listProduct;
        }
        public CartItem(string id)
        {
            this.id = id;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public Dictionary<int, int> ListProduct
        {
            get { return listProduct; }
            set { listProduct = value; }
        }
        public bool WasOrder { get => wasOrder; set => wasOrder = value; }
        public Coupon Coupon { get => coupon; set => coupon = value; }
    }
}
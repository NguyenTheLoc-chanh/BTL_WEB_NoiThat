using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class Order
    {
        private string id;
        private string userId;
        private string cartId;
        private string status;
        private string orderType;
        private DateTime timeOrder;
        private checkoutInfo checkoutInfo;

        public Order(string id, string userId, string cartId, string status, string orderType, DateTime timeOrder, checkoutInfo checkoutInfo)
        {
            this.id = id;
            this.userId = userId;
            this.cartId = cartId;
            this.status = status;
            this.orderType = orderType;
            this.timeOrder = timeOrder;
            this.checkoutInfo = checkoutInfo;
        }

        public string SId { get => id; set => id = value; }
        public string SUserId { get => userId; set => userId = value; }
        public string SCartId { get => cartId; set => cartId = value; }
        public string SStatus { get => status; set => status = value; }
        public string SOrderType { get => orderType; set => orderType = value; }
        public DateTime DTimeOrder { get => timeOrder; set => timeOrder = value; }
        public checkoutInfo CheckoutInfo { get => checkoutInfo; set => checkoutInfo = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class Product
    {
        private int Id;
        private string nameProduct;
        private string imgProduct;
        private int priceProduct;
        //Detail
        private string infoProduct;
        private string imgDetail1;
        private string imgDetail2;
        private string imgDetail3;
        private int stock;

        public Product(int id, string nameProduct, string imgPro, int price, string infoPro, string imgDetail1, string imgDetail2, string imgDetail3, int stock)
        {
            this.Id = id;
            this.nameProduct = nameProduct;
            this.imgProduct = imgPro;
            this.priceProduct = price;
            this.infoProduct = infoPro;
            this.imgDetail1 = imgDetail1;
            this.imgDetail2 = imgDetail2;
            this.imgDetail3 = imgDetail3;
            this.stock = stock;
        }

        public Product()
        {

        }

        public int iID { get => Id; set => Id = value; }
        public string sNameProduct { get => nameProduct; set => nameProduct = value; }
        public string sImgProduct { get => imgProduct; set => imgProduct = value; }
        public int iPriceProduct { get => priceProduct; set => priceProduct = value; }
        public string sInfoProduct { get => infoProduct; set => infoProduct = value; }
        public string sImgDetail1 { get => imgDetail1; set => imgDetail1 = value; }
        public string sImgDetail2 { get => imgDetail2; set => imgDetail2 = value; }
        public string sImgDetail3 { get => imgDetail3; set => imgDetail3 = value; }
        public int iStock { get => stock; set => stock = value; }
    }
}
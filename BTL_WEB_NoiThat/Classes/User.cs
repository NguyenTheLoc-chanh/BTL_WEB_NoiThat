using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB_NoiThat.Classes
{
    public class User
    {
        private string nameRegister;
        private string userName;
        private string passRegister;
        //private string sIdConfirm;

        public User(string nameRes, string userNameRes, string passRes)
        {
            this.nameRegister = nameRes;
            this.userName = userNameRes;
            this.passRegister = passRes;
            //this.sIdConfirm = sIdConfirm;
        }
        public User()
        {

        }

        public string sNameRegister { get => nameRegister; set => nameRegister = value; }
        public string sUserName { get => userName; set => userName = value; }
        public string sPassRegister { get => passRegister; set => passRegister = value; }
        // public string IdConfirm { get => sIdConfirm; set => sIdConfirm = value; }
    }
}
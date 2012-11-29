                 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Customer
    {
        private int _customerID;
        private string _customerName;
        private string _customerPassword;
        private string _customerTel;
        private string _customerAddress;
        private string _customerShenFenID;
        private string _customerEmail;



        public int CustomerID
        {
            get { return this._customerID; }
            set {this._customerID=value;}
        }
        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }
        public string CustomerPassword
        {
            get { return this._customerPassword; }
            set { this._customerPassword = value;}
        }
        public string CustomerTel
        {
            get { return this._customerTel; }
            set { this._customerTel = value; }
        }
        public string CustomerAddress
        {
            get { return this.CustomerAddress; }
            set { this.CustomerAddress = value; }
        }
        public string CustomerShenFenID
        {
            get { return this._customerShenFenID; }
            set { this._customerShenFenID = value; }
        }
        public string CustomerEmail
        {
            get { return this._customerEmail; }
            set { this._customerEmail = value; }
        }
        public Customer() { }
        public Customer(int customerid, string customername, string customerpassword)
        {
            this._customerID = customerid;
            this._customerName = customername;
            this._customerPassword = customerpassword;
        }
    }
}

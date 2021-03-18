using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Testing_March2021.MODEL
{
    class BillingOrder
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string addressLine1;
        public string addressLine2;
        public string city;
        public string state;
        public string zipCode;
        public string comment;
        public string itemNumber;



        //creating the default value
        public BillingOrder(string firstName = null,
            string lastName = null,
            string email = null,
            string phone = null,
            string addressLine1 = null,
            string addressLine2= null,
            string city = null,
            string state = null,
            string zipCode = null,
            string comment = null,
            string itemNumber = null) 
        
        {

            //this.firstName = firstName ?? "Julie Ann";
            //generating random data everytime (TestContext.CurrentContext.Random.GetString()
            this.firstName = firstName ?? TestContext.CurrentContext.Random.GetString();
            this.lastName = lastName ?? "Mondero";
            this.email = email ?? TestContext.CurrentContext.Random.GetString() + "@gmail.com";
            this.phone = phone ?? "0210280000";
            this.addressLine1 = addressLine1 ?? "Cockayne";
            this.addressLine2 = addressLine2 ?? "Crescent";
            this.city = city ?? "Auckand";
            this.state = state ?? "AL";
            this.zipCode = zipCode ?? "062015";
            this.comment = comment ?? "Api Testing going";
            this.itemNumber = itemNumber ?? "012";
           
        }


    }
}

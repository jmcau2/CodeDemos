using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;


namespace PeoriaTechnologyIntakeSheet 
{


    public class Customers
    {
        
    [JsonProperty("customerList")]
        public List<Customer> Customer { get; set; }

    public int getSize()
    {
        return Customer.Count;
    }
 
    }



    public class Customer 
    {
        [JsonProperty(PropertyName = "ID")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "IncomingDate")]
        public string IncomingDate { get; set; }
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "First_Name")]
        public string First_Name { get; set; }
        [JsonProperty(PropertyName = "Last_Name")]
        public string Last_Name { get; set; }
        [JsonProperty(PropertyName = "Phone_Number")]
        public string Phone_Number { get; set; }
        [JsonProperty(PropertyName = "EMail")]
        public string EMail { get; set; }
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }
        [JsonProperty(PropertyName = "Zip")]
        public string Zip { get; set; }
        [JsonProperty(PropertyName = "Equipment_Description")]
        public string Equipment_Description { get; set; }
        [JsonProperty(PropertyName = "Accessories")]
        public string Accessories { get; set; }
        [JsonProperty(PropertyName ="Description_Of_Problems")]
        public string Description_Of_Problems { get; set; }
        [JsonProperty(PropertyName = "isFinished")]
        public string IsFinished { get; set; }

       
    }

    

    
}


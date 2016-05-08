using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;


//This is the service call object, the JSON properties are tied to the getters and setters so when the data
//is sent from the server it is able to be parsed as the data from the server is sent via encoded JSON.
namespace PeoriaTechnologyIntakeSheet
{
    class ServiceCalls
    {
         [JsonProperty("serviceCallList")]
        public List<ServiceCall> ServiceCall { get; set; }

    public int getSize()
    {
       
            return ServiceCall.Count;

       
    }
    }
}




    public class ServiceCall 
    {
        [JsonProperty(PropertyName = "ID")]
        public int ID { get; set; }        
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
        [JsonProperty(PropertyName = "isFinished")]
        public string isFinished { get; set; }
        [JsonProperty(PropertyName = "Appointment_Date")]
        public string Appointment_Date { get; set; }
        [JsonProperty(PropertyName = "Time")]
        public string Time { get; set; }
        [JsonProperty(PropertyName ="Description_Of_Problems")]
        public string Description_Of_Problems { get; set; }
        
       
    }
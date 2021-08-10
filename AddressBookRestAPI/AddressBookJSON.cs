using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookRestAPI
{
    public class AddressBookJSON
    {
        RestClient client;
        public AddressBookJSON()
        {
            client = new RestClient("http://localhost:3000");
        }
        public IRestResponse RetrieveAllData()
        {
            //Pass the request
            RestRequest request = new RestRequest("/Contact");
            IRestResponse response = client.Execute(request);
            return response;
        }
        public List<Person> ReadDataFromServer()
        {
            IRestResponse response = RetrieveAllData();
            //Convert the json object to list
            var res = JsonConvert.DeserializeObject<List<Person>>(response.Content);
            return res;
        }
        public void AddContactIntoServer(Person person)
        {
            //Passing the post method 
            RestRequest request = new RestRequest("/Contact", Method.POST);
            //creating the object
            JsonObject json = new JsonObject();
            json.Add("id",person.id);
            json.Add("firstName", person.FirstName);
            json.Add("lastName", person.LastName);
            json.Add("address", person.Address);
            json.Add("city", person.City);
            json.Add("state", person.State);
            json.Add("zipCode", person.ZipCode);
            json.Add("phoneNumber", person.PhoneNumber);
            json.Add("email", person.EmailId);
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //Convert the json object to list
            var res = JsonConvert.DeserializeObject<Person>(response.Content);
            Console.WriteLine("" + res.id + "Added");
        }

    }
}

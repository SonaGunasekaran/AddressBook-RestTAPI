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

    }
}

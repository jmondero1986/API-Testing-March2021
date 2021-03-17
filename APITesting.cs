using NUnit.Framework;
using RestSharp;
using System;

namespace API_Testing_March2021
{
    public class Tests
    {
        [Test]
        public void TestCase_POST()


        {
            string postBody = "{\r\n  \"addressLine1\": \"COCKAYNE CRESCENT\",\r\n  \"addressLine2\": \"Sunnynook\",\r\n  \"city\": \"AUCKLAND\",\r\n  \"comment\": \"API TESTING DONE\",\r\n  \"email\": \"julia@gmail.com\",\r\n  \"firstName\": \"ABIGAIL\",\r\n  \"id\": 0,\r\n  \"itemNumber\": 0,\r\n  \"lastName\": \"MONDERO\",\r\n  \"phone\": \"0210848080\",\r\n  \"state\": \"AL\",\r\n  \"zipCode\": \"061102\"\r\n}\r\n\r\n";
            IRestResponse response = POST(postBody);
            TestContext.WriteLine(response.Content);


        }

        //API METHODS

        string baseURL = "http://localhost:8080/";


        [Test]
        public IRestResponse POST(string body)
        {

            //creating the client request connection
            var client = new RestClient($"{baseURL}/BillingOrder");


            //creating request such as POST/GET/DEL
            var request = new RestRequest(Method.POST);

            //adding the header (REQUEST PARAMETER)
            request.AddHeader("Content-Type", "application/json");

            //Adding the Body
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            //executing the request
            IRestResponse response = client.Execute(request);

            return response;
        }


        [Test]
        public IRestResponse PUT(int id, string body)
        {

            //creating the client request connection
            var client = new RestClient($"{baseURL}/BillingOrder/{id}");


            //creating request such as POST/GET/DEL
            var request = new RestRequest(Method.PUT);

            //adding the header (REQUEST PARAMETER)
            request.AddHeader("Content-Type", "application/json");

            //Adding the Body
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            //executing the request
            IRestResponse response = client.Execute(request);

            return response;
        }



        [Test]
        public IRestResponse GETSINGLE(int id)
        {

            //creating the client request connection
            var client = new RestClient($"{baseURL}/BillingOrder/{id}");


            //creating request such as POST/GET/DEL
            var request = new RestRequest(Method.GET);

            //executing the request
            IRestResponse response = client.Execute(request);

            return response;
        }


        [Test]
        public IRestResponse GETALL()
        {

            //creating the client request connection
            var client = new RestClient($"{baseURL}/BillingOrder");


            //creating request such as POST/GET/DEL
            var request = new RestRequest(Method.GET);

            //executing the request
            IRestResponse response = client.Execute(request);

            return response;
        }


        [Test]
        public IRestResponse DELETESINGLE(int id)
        {

            //creating the client request connection
            var client = new RestClient($"{baseURL}/BillingOrder/{id}");


            //creating request such as POST/GET/DEL
            var request = new RestRequest(Method.DELETE);

            //executing the request
            IRestResponse response = client.Execute(request);

            TestContext.WriteLine(response.StatusCode);

            return response;


        }

        //[Test]
        //public IRestResponse DELETEALL()
        //{

        //    for (int i = 0; i <= 50; i++)


        //    {


        //        //creating the client request connection
        //        var client = new RestClient($"{baseURL}/BillingOrder/{i}");


        //        //creating request such as POST/GET/DEL
        //        var request = new RestRequest(Method.DELETE);

        //        //executing the request
        //        IRestResponse response = client.Execute(request);
        //        TestContext.WriteLine(response.StatusCode);

        //        return response;

        //    }
        //}



    }
}

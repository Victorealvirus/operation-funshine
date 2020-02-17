using System;
using System.Collections.Generic;
using RestSharp;

namespace FunshineLogic
{
    public class LifxControl
    {
        private static readonly string AccessToken = "cb555bb8831eff835b4c391c652cf89c8f8ce0e700edaf15923e5408a0f00b57";

        protected RestClient RestClient;

        public LifxControl() 
        {
            RestClient = new RestClient("https://api.lifx.com/v1/lights");
            RestClient.AddDefaultHeader("Authorization: ", "Bearer " + AccessToken);
        }

        public IRestResponse GetLights()
        {
            var req = new RestRequest("all", DataFormat.Json);
            return RestClient.Get(req);
        }
    }
}

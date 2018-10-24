using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace GymPoints.Business
{
    public class AutenticacaoSF
    {
        public static string oauthToken { get; set; }
        public static string serviceUrl { get; set; }

        async public static Task autenticarSF()
        {
            HttpClient authClient = new HttpClient();
            
            string sfdcConsumerKey = "3MVG9dZJodJWITSsLl9Gbw5MqpTFalnkZeSE42RMZg6I15UwjjlEqvwgDRnIIOWLYsBtiXTpcXFDuDzLadPSl";
            string sfdcConsumerSecret = "8847434933220872042";
            string sfdcUserName = "membro@gympoints.com";
            string loginPassword = "userGYMPOINTS93vdXmGIPs2EV9oFxCyTAZ1mNE";
            HttpContent content = new FormUrlEncodedContent(new Dictionary<String, String>
                {
                    {"grant_type","password"},
                    {"client_id",sfdcConsumerKey},
                    {"client_secret",sfdcConsumerSecret},
                    {"username",sfdcUserName},
                    {"password",loginPassword}
                }
            );
            HttpResponseMessage message = await authClient.PostAsync("https://login.salesforce.com/services/oauth2/token", content);
            string responseString = await message.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(responseString);
            oauthToken = (string)obj["access_token"];
            serviceUrl = (string)obj["instance_url"];

        }

        
    }
}
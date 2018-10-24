using GymPoints.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace GymPoints.Business
{
    public class AcademiaBusiness
    {

        async public static Task<List<Academia>> getAcademias()
        {
            HttpClient queryClient = new HttpClient();
            string restQuery = AutenticacaoSF.serviceUrl + "/services/data/v43.0/query/?q=SELECT nome__c FROM Academia__c";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, restQuery);
            request.Headers.Add("Authorization", "Bearer " + AutenticacaoSF.oauthToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await queryClient.SendAsync(request);
            var contentJson = await response.Content.ReadAsStringAsync();
            dynamic response2 = JsonConvert.DeserializeObject(contentJson);
            JArray records = response2.records;

            List<Academia> academias = new List<Academia>();

            foreach(JObject academia in records)
            {
                academias.Add(new Academia(academia["nome__c"]+""));
            }

            return academias;
        }
    }
}
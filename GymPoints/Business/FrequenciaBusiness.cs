﻿using GymPoints.Models;
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
    public class FrequenciaBusiness
    {

        async public static Task <List<Frequencia>> getFrequencias()
        {
            System.Diagnostics.Debug.WriteLine("SERVICEURL" + AutenticacaoSF.serviceUrl);
           
            HttpClient queryClient = new HttpClient();
            string restQuery = AutenticacaoSF.serviceUrl + "/services/data/v43.0/query/?q=SELECT dataRegistro__c FROM Frequencia__c";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, restQuery);
            request.Headers.Add("Authorization", "Bearer " + AutenticacaoSF.oauthToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await queryClient.SendAsync(request);
            var contentJson = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine("response" + contentJson);
            dynamic response2 = JsonConvert.DeserializeObject(contentJson);
            JArray records = response2.records;

            List<Frequencia> frequencias = new List<Frequencia>();

            foreach (JObject frequencia in records)
            {
                frequencias.Add(new Frequencia(frequencia["dataRegistro__c"] + ""));
            }
            return frequencias;
        }
    }
}
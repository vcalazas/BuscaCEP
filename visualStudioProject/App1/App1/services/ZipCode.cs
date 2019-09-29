using App1.services.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace App1.services
{
    class ZipCode
    {
        // http://viacep.com.br/ws/81920250/json/
        private static string urlViaCep = "http://viacep.com.br/ws/{0}/json/"; 
        public static Address ConsultZipCode(string mCep)
        {
            Address response = new Address();
            try
            {
                string newUrlViaCep = string.Format(urlViaCep, mCep);
                WebClient webClient = new WebClient();
                string content = webClient.DownloadString(newUrlViaCep);
                response = JsonConvert.DeserializeObject<Address>(content);
                if (response.Cep == null || response.Cep.Equals(""))
                {
                    response.Success = false;
                }
            }
            catch (Exception) {
                response.Success = false;
            }
            return response;
        }
    }
}

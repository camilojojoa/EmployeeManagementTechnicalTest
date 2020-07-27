using System;
using System.Configuration;
using System.Net.Http;

namespace EmployeeManagement.Data
{
    public static class ApiConnection
    {
        private static string uriApi = ConfigurationManager.AppSettings["masglobaltestapi"];
        public static string GetEmployeesFromApi()
        {
            string data = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponseMessage = httpClient.GetAsync(uriApi).Result;
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        data = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    }
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

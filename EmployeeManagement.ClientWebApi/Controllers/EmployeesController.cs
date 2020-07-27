using EmployeeManagement.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Web.Mvc;

namespace EmployeeManagement.ClientWebApi.Controllers
{
    public class EmployeesController : Controller
    {

        private static int count = 0;

        // GET: Employees
        public ActionResult Index(string id = "")
        {
            if (count > 0)
            {
                List<EmployeeViewModel> employees = this.GetEmployees(id);
                return View(employees);
            }
            count++;
            return View();
        }

        private List<EmployeeViewModel> GetEmployees(string id = "")
        {
            List<EmployeeViewModel> employees = null;
            bool idEmpty = string.IsNullOrEmpty(id);
            string uri = ConfigurationManager.AppSettings["localwebapi"];
            string data = string.Empty;
            if (string.IsNullOrEmpty(uri))
            {
                return null;
            }
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage httpResponseMessage = null;
                    if (idEmpty)
                    {
                        httpResponseMessage = httpClient.GetAsync(uri).Result;
                    }
                    else
                    {
                        if (!int.TryParse(id, out int _id))
                        {
                            return null;
                        }
                        httpResponseMessage = httpClient.GetAsync(uri + "?id=" + id).Result;
                    }

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        data = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    }
                }

                if (!string.IsNullOrEmpty(data))
                {
                    if (idEmpty)
                    {
                        employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(data);
                    }
                    else
                    {
                        employees = new List<EmployeeViewModel>() { JsonConvert.DeserializeObject<EmployeeViewModel>(data) };
                    }
                }

                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
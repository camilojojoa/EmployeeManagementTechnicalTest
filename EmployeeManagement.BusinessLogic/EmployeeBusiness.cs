using EmployeeManagement.Data;
using EmployeeManagement.Entities.Dto;
using EmployeeManagement.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.BusinessLogic
{

    static public class EmployeeBusiness
    {
        private static List<EmployeeViewModel> employeesViewModel = null;

        public static List<EmployeeViewModel> GetEmployeesInformation()
        {
            try
            {
                string data = ApiConnection.GetEmployeesFromApi();
                if (string.IsNullOrEmpty(data))
                {
                    return employeesViewModel;
                }

                List<EmployeeProperties> employeesProperties = JsonConvert.DeserializeObject<List<EmployeeProperties>>(data);
                employeesViewModel = new List<EmployeeViewModel>();

                foreach (var item in employeesProperties)
                {
                    EmployeeDTO employeeDTO = employeeDTO = EmployeeFactory.FactoryMethod(item.ContractTypeName);
                    employeeDTO.EmployeeProperties = item;

                    EmployeeViewModel e = new EmployeeViewModel(employeeDTO.EmployeeProperties)
                    {
                        AnualSalary = employeeDTO.CalculatedAnualSalary()
                    };

                    employeesViewModel.Add(e);
                }

                return employeesViewModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static EmployeeViewModel GetEmployeeInformation(int id)
        {
            try
            {
                if (employeesViewModel == null)
                {
                    GetEmployeesInformation();
                }

                EmployeeViewModel employeeViewModel = employeesViewModel.Where(x => x.Id == id).FirstOrDefault();
                return employeeViewModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

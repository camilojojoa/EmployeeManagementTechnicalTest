namespace EmployeeManagement.ViewModels
{
    public class EmployeeViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnualSalary { get; set; }

        public EmployeeViewModel(Entities.Dto.EmployeeProperties employeeProperties)
        {
            this.Id = employeeProperties.Id;
            this.Name = employeeProperties.Name;
            this.ContractTypeName = employeeProperties.ContractTypeName;
            this.RoleId = employeeProperties.RoleId;
            this.RoleName = employeeProperties.RoleName;
            this.RoleDescription = employeeProperties.RoleDescription;
            this.HourlySalary = employeeProperties.HourlySalary;
            this.MonthlySalary = employeeProperties.MonthlySalary;
            
        }
    }
}

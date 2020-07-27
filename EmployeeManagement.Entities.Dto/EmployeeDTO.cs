namespace EmployeeManagement.Entities.Dto
{
    public struct EmployeeProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
    }

    public abstract class EmployeeDTO
    {
        public EmployeeProperties EmployeeProperties { get; set; }

        public abstract decimal CalculatedAnualSalary();
    
    }
}

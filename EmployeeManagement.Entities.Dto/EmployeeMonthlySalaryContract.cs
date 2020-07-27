namespace EmployeeManagement.Entities.Dto
{
    public class EmployeeMonthlySalaryContract : EmployeeDTO
    {
        public override decimal CalculatedAnualSalary()
        {
            return this.EmployeeProperties.MonthlySalary * 12;
        }
    }
}

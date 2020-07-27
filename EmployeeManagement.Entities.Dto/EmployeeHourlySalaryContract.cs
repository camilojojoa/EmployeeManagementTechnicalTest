namespace EmployeeManagement.Entities.Dto
{
    public class EmployeeHourlySalaryContract : EmployeeDTO
    {
        public override decimal CalculatedAnualSalary()
        {
            return 120 * this.EmployeeProperties.HourlySalary * 12;
        }
    }
}

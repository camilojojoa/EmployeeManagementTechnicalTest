namespace EmployeeManagement.Entities.Dto
{
    public class EmployeeFactory
    {
        public static EmployeeDTO FactoryMethod(string contractTypeName)
        {
            if (contractTypeName == "MonthlySalaryEmployee")
            {
                return new EmployeeMonthlySalaryContract();
            }
            else
            {
                return new EmployeeHourlySalaryContract();
            }
        }
    }
}

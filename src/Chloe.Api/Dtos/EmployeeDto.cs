using Chloe.Api.Models;

namespace Chloe.Api.Dtos
{
    public class EmployeeDto
    {
        public EmployeeDto(Employee employee)
        {
            this.FirstName = employee.FirstName;
            this.LastName = employee.LastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
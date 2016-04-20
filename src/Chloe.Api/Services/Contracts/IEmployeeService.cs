using Chloe.Api.Dtos;
using System.Collections.Generic;

namespace Chloe.Api.Services.Contracts
{
    public interface IEmployeeService
    {
        ICollection<EmployeeDto> Get();
    }
}

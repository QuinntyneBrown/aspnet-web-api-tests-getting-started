using System;
using System.Collections.Generic;
using Chloe.Api.Data.Contracts;
using Chloe.Api.Dtos;
using Chloe.Api.Services.Contracts;

namespace Chloe.Api.Services
{
    public class EmployeeService: IEmployeeService
    {
        public EmployeeService(IChloeUow uow)
        {
            this.uow = uow;
        }

        protected readonly IChloeUow uow;

        public ICollection<EmployeeDto> Get()
        {
            var result = new List<EmployeeDto>();
            foreach(var employee in uow.Employees.GetAll())
            {
                result.Add(new EmployeeDto(employee));
            }
            return result;
        }
    }
}
using Chloe.Api.Data.Contracts;
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
    }
}
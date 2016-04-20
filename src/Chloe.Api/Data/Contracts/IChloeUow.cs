using Chloe.Api.Models;

namespace Chloe.Api.Data.Contracts
{
    public interface IChloeUow
    {
        IRepository<Employee> Employees { get; }

        void SaveChanges();
    }
}

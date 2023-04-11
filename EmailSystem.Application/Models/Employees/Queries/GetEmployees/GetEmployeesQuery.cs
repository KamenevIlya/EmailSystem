using MediatR;
using EmailSystem.Application.Models.Employees.Queries.ViewModels;

namespace EmailSystem.Application.Models.Employees.Queries.GetEmployees
{
    public class GetEmployeesQuery : IRequest<EmployeesVm>
    {

    }
}

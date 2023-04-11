using System.Collections.Generic;
using EmailSystem.Domain;

namespace EmailSystem.Client.ResponseModels
{
    public class EmployeesResponse
    {
        public List<Employee> Employees { get; set; }
    }
}

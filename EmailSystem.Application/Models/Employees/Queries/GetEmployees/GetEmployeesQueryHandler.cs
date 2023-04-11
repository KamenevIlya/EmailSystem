using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using EmailSystem.Application.Common.Exceptions;
using EmailSystem.Application.Interfaces;
using EmailSystem.Application.Models.Employees.Queries.ViewModels;
using EmailSystem.Domain;

namespace EmailSystem.Application.Models.Employees.Queries.GetEmployees
{
    public class GetClientsQueryHandler : IRequestHandler<GetEmployeesQuery, EmployeesVm>
    {
        private readonly IEmailSystemDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetClientsQueryHandler(IEmailSystemDbContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<EmployeesVm> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employeesQuery = await _dbContext.Employees
                .ProjectTo<EmployeeVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            if (employeesQuery == null)
            {
                throw new NotFoundException(nameof(Employee), "Clients error");
            }

            return new() { Employees = employeesQuery };
        }
    }
}
using System;
using AutoMapper;
using EmailSystem.Application.Common.Mappings;
using EmailSystem.Domain;

namespace EmailSystem.Application.Models.Employees.Queries.ViewModels
{
    public class EmployeeVm : IMapWith<Employee>
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string GivenName { get; set; }

        public string Position { get; set; }

        public int ExperienceMonth { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, EmployeeVm>()
                .ForMember(employeeVm => employeeVm.Id,
                    opt => opt.MapFrom(employee => employee.Id))
                .ForMember(employeeVm => employeeVm.FirstName,
                    opt => opt.MapFrom(employee => employee.FirstName))
                .ForMember(employeeVm => employeeVm.SecondName,
                    opt => opt.MapFrom(employee => employee.SecondName))
                .ForMember(employeeVm => employeeVm.GivenName,
                    opt => opt.MapFrom(employee => employee.GivenName))
                .ForMember(employeeVm => employeeVm.Position,
                    opt => opt.MapFrom(employee => employee.Position))
                .ForMember(employeeVm => employeeVm.ExperienceMonth,
                    opt => opt.MapFrom(employee => employee.ExperienceMonth));
        }
    }
}
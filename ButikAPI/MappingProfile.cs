using AutoMapper;
using ButikAPI.DTOs;
using ButikAPI.Models;
using ButikAPI.ViewModels;

namespace ButikAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeDto,Employee>();
        }
    }
}

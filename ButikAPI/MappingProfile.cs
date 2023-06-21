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

            CreateMap<Customer, CustomerViewModel>();
            CreateMap<CustomerDto,Customer>();

            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductDto,Product>();

            CreateMap<Branch, BranchViewModel>();
            CreateMap<BranchDto,Branch>();

            CreateMap<Transaction, TransactionViewModel>();
            CreateMap<TransactionDto,Transaction>();
        }
    }
}

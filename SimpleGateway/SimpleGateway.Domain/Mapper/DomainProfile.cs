using AutoMapper;
using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Entities;

namespace SimpleGateway.Domain.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<object, SalesResponse>();
            CreateMap<Transaction, SalesResponse>();
        }
    }
}

using AutoMapper;
using SimpleGateway.Domain.Contracts.Response;

namespace SimpleGateway.Domain.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<SalesResponse, object>();
        }
    }
}

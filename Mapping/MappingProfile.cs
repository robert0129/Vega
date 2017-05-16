using AutoMapper;
using WebApplicationBasic.Controllers.Resources;
using WebApplicationBasic.Core.Models;

namespace WebApplicationBasic.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}
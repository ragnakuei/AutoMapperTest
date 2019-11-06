using AutoMapper;

namespace AutoMapperTest
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Class1, Class2>();
        }
    }
}
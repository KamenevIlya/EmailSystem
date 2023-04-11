using AutoMapper;

namespace EmailSystem.Application.Common.Mappings
{
    public interface IMapWith<T>
    {
        public void Mapping(Profile profile);
    }
}
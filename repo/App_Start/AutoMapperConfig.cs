using AutoMapper;
using repo.Models;
using repo.ViewModels;

public static class AutoMapperConfig
{
    public static void RegisterMappings()
    {
        Mapper.Initialize(cfg =>
        {
            cfg.CreateMap<Car, VM_Car>().ReverseMap();
        });

    }
}
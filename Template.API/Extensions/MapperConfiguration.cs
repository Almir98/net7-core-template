﻿namespace Template.API.Extensions;

/// <summary>
/// Represents a mapper configuration that defines how objects are mapped between different types. 
/// </summary>
public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        // <Model, Entity>

        CreateMap<TemplateEntity1Dto, TemplateEntity1>().ReverseMap();
        CreateMap<TemplateEntity2Dto, TemplateEntity2>().ReverseMap();
    }
}
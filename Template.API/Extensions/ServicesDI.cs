﻿namespace Template.API.Extensions;

public static class ServicesDI
{
    /// <summary>
    /// Registers application services with the specified service collection.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        // READ operations
        services.AddScoped<IBaseGetService<TemplateEntity2Dto>, BaseGetService<TemplateEntity2Dto>>();

        // CRUD operations
        services.AddScoped<IBaseCrudService<TemplateEntity2Dto>, BaseCrudService<TemplateEntity2Dto>>();
    }
}
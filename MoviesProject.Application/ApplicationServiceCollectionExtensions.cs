﻿using Microsoft.Extensions.DependencyInjection;
using MoviesProject.Application.Repositories;

namespace MoviesProject.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<IMovieRepository, MovieRepository>();
        return services;
    }
}

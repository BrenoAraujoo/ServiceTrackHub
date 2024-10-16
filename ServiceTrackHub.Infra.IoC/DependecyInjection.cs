﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceTrackHub.Domain.Interfaces;
using ServiceTrackHub.Infra.Data.Context;
using ServiceTrackHub.Infra.Data.Repositories;
using ServiceTrackHub.Application.Interfaces;
using ServiceTrackHub.Application.Interfaces.Auth;
using ServiceTrackHub.Application.Interfaces.Domain;
using ServiceTrackHub.Application.Services.Auth;
using ServiceTrackHub.Application.Services.Domain;

namespace ServiceTrackHub.Infra.IoC
{
    public  static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            
            services.AddScoped<ITasksRepository, TasksRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITaskTypeRepository, TaskTypeRepository>();
            
          
            services.AddScoped<ITasksService, TasksService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITaskTypeService, TaskTypeService>();
            

            //Auth
            services.AddScoped<IHashService, HashService>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IAuthService, AuthService>();
            return services;
        }
    }
}

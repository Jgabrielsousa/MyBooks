using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBook.Application.UseCases.Base;
using MyBook.Data.Context;
using MyBook.Data.Repository;
using MyBook.Domain.Interfaces.IRepository;
using System.Data;
using System.Reflection;

namespace MyBook.CrossCutting.Ioc
{
    public static class Bootstrap
    {
        private const string APPLICATION_NAMESPACE = "MyBook.Application";


        public static void AddMediatorServices(this IServiceCollection services)
        {
            var currentAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Command<>).GetTypeInfo().Assembly));
        }

        public static void AddIoCServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthorBookRepository, AuthorBookRepository>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<ISaleTypeRepository, SaleTypeRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ISaleTypeBookRepository, SaleTypeBookRepository>();
            services.AddTransient<ISubjectBookRepository, SubjectBookRepository>();
        }

        public static IServiceCollection AddSqlServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MyBook");

            services.AddTransient<IDbConnection>(b =>
            {
                return new SqlConnection(connectionString);
            });

            services.AddDbContextPool<MyBookDbContext>(options =>
            options.UseSqlServer(connectionString, b => b.MigrationsAssembly("MyBook.Data")));

            

            return services;
        }



    }
}

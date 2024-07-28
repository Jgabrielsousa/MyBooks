using Microsoft.Extensions.DependencyInjection;
using MyBook.Application.UseCases.Base;
using System.Reflection;

namespace MyBook.CrossCutting.Ioc
{
    public static class Bootstrap
    {
        private const string APPLICATION_NAMESPACE = "MyBook.Application";


        public static void RegisterMediatorServices(this IServiceCollection services)
        {
            var currentAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Command<>).GetTypeInfo().Assembly));
        }



    }
}

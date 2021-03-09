using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Business.Concrete;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.DataAccess.Concrete.EntityFramework.Repositories;

namespace TeknikServis.MVCUI.Extensions
{
    public static class ConfigureServiceExtension
    {
        public static void AdminConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<IAdminBs, AdminBs>();
            services.AddSingleton<IAdminRepository, AdminRepositoryEntityFramework>();
        }
        public static void RoleConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<IRoleBs, RoleBs>();
            services.AddSingleton<IRoleRepository, RoleRepositoryEntityFramework>();
        }
        public static void ServiceConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<IServiceBs, ServiceBs>();
            services.AddSingleton<IServiceRepository, ServiceRepositoryEntityFramework>();
        }
        public static void FaultConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<IFaultBs, FaultBs>();
            services.AddSingleton<IFaultRepository, FaultRepositoryEntityFramework>();
        }
        public static void DeviceStatusConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<IDeviceStatusBs, DeviceStatusBs>();
            services.AddSingleton<IDeviceStatusRepository, DeviceStatusRepositoryEntityFramework>();
        }
        public static void CustpmerTypeConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<ICustomerTypeBs, CustomerTypeBs>();
            services.AddSingleton<ICustomerTypeRepository, CustomerTypeRepositoryEntityFramework>();
        }
        public static void MessageConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<IMessageBs, MessageBs>();
            services.AddSingleton<IMessageRepository, MessageRepositoryEntityFramework>();
        }
        public static void SendMessageConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<ISendMessageBs, SendMessageBs>();
            services.AddSingleton<ISendMessageRepository, SendMessageRepositoryEntityFramework>();
        }
    }
}

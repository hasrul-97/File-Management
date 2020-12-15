using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UserProfile.Query.Abstraction.BusinessLogic;
using UserProfile.Query.Abstraction.DataAccess;
using UserProfile.Query.BusinessLogic;
using UserProfile.Query.DataAccess;

namespace UserProfile.Query.DependancyInjection
{
    public class DependancyResolver
    {
        public static void ConfigureService(IServiceCollection service)
        {
            service.AddScoped<IBusinessManager, BusinessManager>();
            service.AddScoped<IDataAccessManager, DataAccessManager>();
            service.AddScoped<IRepository, Repository>();
        }
    }
}

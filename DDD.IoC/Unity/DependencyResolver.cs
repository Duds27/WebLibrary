using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Repositories.Base;
using DDD.Domain.Interfaces.Services;
using DDD.Domain.Services;
using DDD.Infra.Persistence;
using DDD.Infra.Persistence.Repositories;
using DDD.Infra.Persistence.Repositories.Base;
using DDD.Infra.Transactions;
using Microsoft.EntityFrameworkCore;
using Unity;
using Unity.Lifetime;

namespace DDD.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, LibraryContext>(new HierarchicalLifetimeManager());
            
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            
            //Serviço de Domain
            container.RegisterType<IServiceBook, ServiceBook>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceExemplary, ServiceExemplary>(new HierarchicalLifetimeManager());
            
            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryBook, RepositoryBook>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryExemplary, RepositoryExemplary>(new HierarchicalLifetimeManager());
            
            

        }
    }
}
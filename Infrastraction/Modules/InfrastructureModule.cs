using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using WorldRank.Application.Interfaces;
using WorldRank.Infrastructure.Persistencies.Command.Players;

namespace WorldRank.Infrastructure.Modules
{
    public class InfrastructureModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CreatePlayerPersistence>().As<ICreatePlayerPersistence>().InstancePerLifetimeScope();

            builder.RegisterDecorator(typeof(CreatePlayersPersistenceCachingDecorator), typeof(ICreatePlayerPersistence));
        }
    }
}

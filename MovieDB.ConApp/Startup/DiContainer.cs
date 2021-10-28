using Autofac;
using MovieDB.ConApp.DataAccess;
using MovieDB.UI.DataSource;

namespace MovieDB.ConApp.Startup
{
    public class DiContainer
    {
        public IContainer Container()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MoviesModel>().AsSelf();
            builder.RegisterType<DataSource_Json>().SingleInstance();
            builder.RegisterType<MoviesDataAccessJson>()
                    .As<IDataAccess>()
                    .SingleInstance();
            return builder.Build();
        }
    }
}

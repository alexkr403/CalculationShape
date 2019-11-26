using CalculateShapeLibrary.Interfaces.Services;
using CalculateShapeLibrary.Services;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace CalculateShapeLibrary.Consumer.CompositeRoot.Modules
{
    public class ShapeServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITriangleService>()
                .To<TriangleService>()
                .InSingletonScope()
                ;

            Bind<ICircleService>()
                .To<CircleService>()
                .InSingletonScope()
                ;

            Bind<IShapeService>()
                .To<ShapeService>()
                .InSingletonScope()
                ;

            Bind<IShapeServiceFactory>()
                .ToFactory()
                ;
        }
    }
}

using CalculateShapeLibrary.Consumer.CompositeRoot.Modules;
using CalculateShapeLibrary.Consumer.Consumer;
using Ninject;

namespace CalculateShapeLibrary.Consumer.CompositeRoot
{
    public class Workstation : StandardKernel
    {
        public void Init()
        {
            Bind<IConsumerExample>()
                .To<ConsumerExample>()
                ;

            this.Load(new ShapeServiceModule());
        }
    }
}

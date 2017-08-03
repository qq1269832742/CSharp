using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ILogic;
using ILogics;
using IRepository;

namespace Logic.Installers
{
    public class HelloWorldLogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
         
            container.Register(
               Component.For<IHelloWorldLogic>().ImplementedBy<HelloWorldLogic>()
               );
            container.Register(
               Component.For<ITestCastleLogic>().ImplementedBy<TestCastleLogic>()
            );
            container.Register(
                 Component.For<IStudentLogic>().ImplementedBy<StudentLogic>()

               );
        }
    }
}
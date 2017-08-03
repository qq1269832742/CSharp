using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IRepository;

namespace Repository.Installers
{
    public class HelloWorldRepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
               Component.For<IHelloWorldRepository>()
               .ImplementedBy<HelloWorldRepository>()
               );
            container.Register(
               Component.For<IStudentRepository>()
               .ImplementedBy<StudentRepository>()
               );
        }
    }
}

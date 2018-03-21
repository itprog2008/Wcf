using Services;
using Services.Database;
using Unity;
using Unity.Wcf;

namespace TestWcfService
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            // register all your components with the container here
            container
               .RegisterType<ITestService, TestService>()
               .RegisterType<IWorkService, WorkService>()
               .RegisterType<IRepository, Repository>();
        }
    }    
}
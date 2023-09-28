using Autofac;

namespace RFA.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<AuthManager>().As<IAuthService>();
        }
    }
}

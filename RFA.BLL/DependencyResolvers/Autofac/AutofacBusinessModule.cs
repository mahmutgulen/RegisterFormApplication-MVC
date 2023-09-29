using Autofac;
using RFA.DAL.Abstract;
using RFA.DAL.Concrete;

namespace RFA.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegistrationInfoDal>().As<IRegistrationInfoDal>();
            builder.RegisterType<PaymentInfoDal>().As<IPaymentInfosDal>();
        }
    }
}

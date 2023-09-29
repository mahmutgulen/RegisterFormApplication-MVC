using Autofac;
using RFA.BLL.Abstract;
using RFA.BLL.Concrete;
using RFA.DAL.Abstract;
using RFA.DAL.Concrete;

namespace RFA.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegistrationInfoManager>().As<IRegistrationInfoService>();
            builder.RegisterType<PaymentInfoManager>().As<IPaymentInfoService>();


            builder.RegisterType<RegistrationInfoDal>().As<IRegistrationInfoDal>();
            builder.RegisterType<PaymentInfoDal>().As<IPaymentInfosDal>();
        }
    }
}

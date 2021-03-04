using System.Windows.Forms;
using Autofac;
using NotificationsTest.Application.Presentation.Presenters;
using NotificationsTest.Application.Presentation.Views;
using NotificationsTest.Utils;

namespace NotificationsTest.Infrastructure {
    internal class RootAutofacModule : Module {
        protected override void Load(ContainerBuilder builder) {
            builder
                .RegisterType<NotificationsForm>()
                .ExternallyOwned()
                .Keyed<Form>(ApplicationConstants.EntryForm)
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies)
                .As<INotificationView>().SingleInstance();
            builder
                .RegisterType<NotificationsPresenter>()
                .As<INotificationsPresenter>().InstancePerDependency();
        }
    }
}
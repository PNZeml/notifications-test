using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using NotificationsTest.Utils;

namespace NotificationsTest {
    internal static class Program {
        [STAThread]
        private static void Main() {
            using var compositionRoot = BuildCompositionRoot();
            using var applicationLifetimeScope = compositionRoot.BeginLifetimeScope();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var form = applicationLifetimeScope.ResolveKeyed<Form>(ApplicationConstants.EntryForm);
            System.Windows.Forms.Application.Run(form);
        }

        private static ILifetimeScope BuildCompositionRoot() {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            return builder.Build();
        }
    }
}
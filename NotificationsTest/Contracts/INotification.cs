using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAis.Desktop.Notifications.Exp.Contracts {
    internal interface INotification {
        long Id { get; }
        string Title { get; }
    }
}

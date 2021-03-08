using System;
using System.Collections.Generic;
using NotificationsTest.Domain;

namespace NotificationsTest.Application.Services.Dtos.NotificationDtos {
    internal abstract class NotificationBase {
        public long Id { get; set; }
        public NotificationType Type { get; set; }
        public bool IsCritical { get; set; }
        public DateTime DateTime { get; set; }

        public string ReadableDateTime => DateTime.ToString("f");
    }

    internal class NotificationIdsComparer : IEqualityComparer<NotificationBase> {
        public bool Equals(NotificationBase? x, NotificationBase? y) {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return x.Id == y.Id;
        }

        public int GetHashCode(NotificationBase obj) => obj.Id.GetHashCode();
    }
}

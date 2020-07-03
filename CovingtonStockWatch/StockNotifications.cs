using System;

namespace CovingtonStockWatch {

    public enum NotificationType { 
        UPPERLIMIT,
        LOWERLIMIT
    }

    public class StockNotification {
        public string Name;
        public double Price;
        public NotificationType Notification;
        public Guid ID;

        public StockNotification(string _name, double _price, NotificationType _notification) {
            Name = _name;
            Price = _price;
            Notification = _notification;
            ID = Guid.NewGuid();
        }

    }
}
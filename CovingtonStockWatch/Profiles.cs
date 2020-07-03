
using System;
using System.Collections.Generic;

namespace CovingtonStockWatch {
    public class Profile {
        public string Username { get; set; }

        public Dictionary<string, StockInfo> StockList;
        public Dictionary<Guid, StockNotification> NotificationList;

        public Profile(string name) {
            Console.WriteLine("Creating New Profile: " + name);
            Username = name;
            StockList = new Dictionary<string, StockInfo>();
            NotificationList = new Dictionary<Guid, StockNotification>();
        }

        public void AddStock(string stockName) {
            try
            {
                if (!StockList.ContainsKey(stockName))
                {
                    Console.WriteLine("Adding Stock: " + stockName + " to watch list.");
                    StockInfo stock = new StockInfo(stockName);
                    StockList.Add(stockName, stock);
                }
                else {
                    Console.WriteLine("Stock: " + stockName + " already exists in watch list.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Add Stock: " + ex.Message);
            }
        }

        public void RemoveStock(string stockName) {
            try
            {
                Console.WriteLine("Removing stock: " + stockName + " from watch list.");
                StockList.Remove(stockName);
            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to remove stock: " + stockName + ": " + ex.Message);
            }
        }

        public void AddNotification(string name, double price, NotificationType notificationType) {
            try
            {
                Console.WriteLine("Adding Notification to List");
                StockNotification notification = new StockNotification(name, price, notificationType);
                if(!NotificationList.ContainsKey(notification.ID))
                    NotificationList.Add(notification.ID, notification);

            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to add notification: " + ex.Message);
            }
        }

        public void RemoveNotification(Guid id) {
            try
            {
                Console.WriteLine("Removing Notification from list.");
                bool wasFound = NotificationList.Remove(id);
                if (!wasFound) {
                    Console.WriteLine("Notification Was Not Found in List");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Remove Notification from List: " + ex.Message);
            }
        }

        public void RemoveNotification(StockNotification notification) {
            try
            {
                Console.WriteLine("Removing Notification from list.");
                bool wasFound = NotificationList.Remove(notification.ID);
                if (!wasFound) {
                    Console.WriteLine("Notification was not found in list.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to Remove Notification from List: " + ex.Message);
            }
        }

        public void ClearAllStocks() {
            try
            {
                Console.WriteLine("Clearing All Stocks from Dictionary.");
                StockList.Clear();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Clear All Stocks: " + ex.Message);
            }
        }

        public void ClearAllNotifications() {
            try
            {
                Console.WriteLine("Clearing All Notifications from Dictionary.");
                NotificationList.Clear();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Clear All Notifications: " + ex.Message);
            }
        }
    
    }
}
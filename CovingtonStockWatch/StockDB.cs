using System;

namespace CovingtonStockWatch {
    public class DB
    {
        public class StockDB
        {
            public string username { get; set; }
            public string stockname { get; set; }

        }

        public class NotificationDB
        {
            public string name { get; set; }
            public double price { get; set; }
            public NotificationType type { get; set; }
        }



        public void Load() {
            try
            {
                LoadStocks();
                LoadNotifications();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Load from SqlLiteDB: " + ex.Message);
            }
        }

        public void LoadStocks() { }

        public void LoadNotifications() { }

        public void Save() {
            try
            {
                SaveStocks();
                SaveNotifications();
            }
            catch (Exception ex) {
                Console.Write("Error: Failed to Save to SqliteDB: " + ex.Message);
            }
        }

        public void SaveStocks() {
            try
            {

            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Save Stocks to SqliteDB: " + ex.Message);
            }
        }

        public void SaveNotifications() {
            try
            {

            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Save Notifications to SqliteDB: " + ex.Message);
            }
        }

        public void InsertStock(StockDB stock) {
            try
            {

            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Insert Stock to SqliteDB: " + ex.Message);
            }
        }

        public void InsertNotification(NotificationDB notification) {
            try { 
            
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: Failed to Insert Notification to SqliteDB: " + ex.Message);
            }
        }

        public void DeleteStock(StockDB stock)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to Delete Stock from SqliteDB: " + ex.Message);
            }
        }

        public void DeleteNotification(NotificationDB notification)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to Delete Notification from SqliteDB: " + ex.Message);
            }
        }

        public void Clear() {
            try
            {
                ClearStocks();
                ClearNotifications();
            }
            catch (Exception ex) {
                Console.Write("Error: Failed to Clear SqliteDB Tables: " + ex.Message);
            }
        }

        public void ClearStocks() {
            try
            {

            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Clear Stocks from SqliteDB: " + ex.Message);
            }
        }
        public void ClearNotifications() {
            try
            {

            }
            catch (Exception ex) {
                Console.WriteLine("Error: Failed to Clear Notifications from SqliteDB: " + ex.Message);
            }
        }
    }
}
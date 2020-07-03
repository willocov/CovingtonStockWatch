namespace CovingtonStockWatch {
    public class StockInfo { 
        public string StockName { get; set; }
        public float StockPrice { get; set; }

        public StockInfo() {}

        public StockInfo(string name) {
            StockName = name;
        }


    }
}